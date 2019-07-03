﻿using CodeGenHero.Logging;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using MSC.ConferenceMate.Domain.Interface;
using MSC.ConferenceMate.Repository.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MSC.ConferenceMate.Domain
{
	public class AzureStorageManager : DomainBase, IAzureStorageManager
	{
		private readonly CloudBlobClient _blobClient;
		private readonly Lazy<CloudBlobContainer> _imageContainer;
		private readonly CloudStorageAccount _storageAccount;
		private readonly StorageCredentials _storageCredentials;
		private readonly Lazy<CloudBlobContainer> _thumbnailContainer;

		public AzureStorageManager(ILoggingService log, ICMRepository repository, IAzureStorageConfig azureStorageConfig)
			: base(log, repository)
		{
			AzureStorageConfig = azureStorageConfig;
			if (AzureStorageConfig == null || string.IsNullOrEmpty(AzureStorageConfig.AccountKey) || string.IsNullOrEmpty(AzureStorageConfig.AccountName)
				|| string.IsNullOrEmpty(AzureStorageConfig.ImageContainer))
			{
				throw new ArgumentNullException($"Null or empty AzureStorageConfig detected in Domain User class constructor.  Ensure you have values set for AccountKey, AccountName, and ImageContainer.");
			}

			_storageCredentials = new StorageCredentials(AzureStorageConfig.AccountName, AzureStorageConfig.AccountKey);
			_storageAccount = new CloudStorageAccount(_storageCredentials, true);
			_blobClient = _storageAccount.CreateCloudBlobClient();
			_imageContainer = new Lazy<CloudBlobContainer>(delegate { return _blobClient.GetContainerReference(AzureStorageConfig.ImageContainer); });
			_thumbnailContainer = new Lazy<CloudBlobContainer>(delegate { return _blobClient.GetContainerReference(AzureStorageConfig.ThumbnailContainer); });
		}

		private AzureStorageManager() : base(null, null)
		{
		}

		private IAzureStorageConfig AzureStorageConfig { get; set; }

		public async Task<bool> DeleteFileFromStorageAsync(Uri blobUri)
		{
			if (blobUri == null)
			{
				return false;
			}

			try
			{
				var blobToDelete = await _blobClient.GetBlobReferenceFromServerAsync(blobUri);
				if (blobToDelete != null)
				{
					await blobToDelete.DeleteIfExistsAsync();
				}
			}
			catch (StorageException sex)
			{
				Log.Error($"Unable to delete blobUri: {blobUri.ToString()} in {nameof(DeleteFileFromStorageAsync)}.", LogMessageType.Instance.Exception_Domain, sex);
			}

			return await Task.FromResult(true);
		}

		public async Task<bool> DeleteFileFromStorageAsync(string blobName, Enums.BlobContainerType containerType)
		{
			if (string.IsNullOrEmpty(blobName))
			{
				return false;
			}
			else
			{   // Limitation: Azure Storage names must be all lowercase.
				blobName = blobName.ToLowerInvariant();
			}

			try
			{
				CloudBlockBlob blockBlob = GetBlockBlobReference(blobName, containerType);
				blockBlob.DeleteIfExists();
			}
			catch (StorageException sex)
			{
				Log.Error($"Unable to delete blobName: {blobName.ToString()} in {nameof(DeleteFileFromStorageAsync)}.", LogMessageType.Instance.Exception_Domain, sex);
			}

			return await Task.FromResult(true);
		}

		public async Task<List<string>> GetThumbNailUrlsAsync()
		{
			List<string> thumbnailUrls = new List<string>();

			BlobContinuationToken continuationToken = null;
			BlobResultSegment resultSegment = null;

			// Call ListBlobsSegmentedAsync and enumerate the result segment returned, while the continuation token is non-null.
			// When the continuation token is null, the last page has been returned and execution can exit the loop.
			do
			{
				// This overload allows control of the page size. You can return all remaining results by passing null for the maxResults parameter, or by calling a different overload.
				resultSegment = await _thumbnailContainer.Value.ListBlobsSegmentedAsync("", true, BlobListingDetails.All, 10, continuationToken, null, null);

				foreach (var blobItem in resultSegment.Results)
				{
					thumbnailUrls.Add(blobItem.StorageUri.PrimaryUri.ToString());
				}

				continuationToken = resultSegment.ContinuationToken;  // Get the continuation token.
			} while (continuationToken != null);

			return await Task.FromResult(thumbnailUrls);
		}

		public async Task<string> UploadFileToStorageAsync(Stream fileStream, string blobName, Enums.BlobContainerType containerType)
		{
			if (string.IsNullOrEmpty(blobName))
			{
				return null;
			}
			else
			{   // Limitation: Azure Storage names must be all lowercase.
				blobName = blobName.ToLowerInvariant();
			}

			CloudBlockBlob blockBlob = GetBlockBlobReference(blobName, containerType);
			await blockBlob.UploadFromStreamAsync(fileStream);

			return blockBlob.StorageUri.PrimaryUri.ToString();
		}

		private CloudBlockBlob GetBlockBlobReference(string blobName, Enums.BlobContainerType containerType)
		{
			CloudBlockBlob retVal = null;
			if (containerType == Enums.BlobContainerType.Image)
			{
				retVal = _imageContainer.Value.GetBlockBlobReference(blobName);
			}
			else
			{
				retVal = _thumbnailContainer.Value.GetBlockBlobReference(blobName);
			}

			return retVal;
		}
	}
}