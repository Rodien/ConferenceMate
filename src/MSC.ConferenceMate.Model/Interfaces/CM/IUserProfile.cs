// <auto-generated> - Template:ModelsBackedByDtoInterface, Version:1.1, Id:4d03f2c7-de27-4aae-a267-cad747c9606a
using System;
using System.Collections.Generic;

namespace MSC.ConferenceMate.Model.CM.Interface
{
	public partial interface IUserProfile
	{
		string AspNetUsersId { get; }
		string AvatarUrl { get; }
		string Biography { get; }
		System.DateTime? BirthDate { get; }
		string BlogUrl { get; }
		string CompanyName { get; }
		string CompanyWebsiteUrl { get; }
		string CreatedBy { get; }
		System.DateTime CreatedUtcDate { get; }
		int DataVersion { get; }
		string FirstName { get; }
		int? GenderTypeId { get; }
		bool IsDeleted { get; }
		string JobTitle { get; }
		System.DateTime LastLogin { get; }
		string LastName { get; }
		string LinkedInUrl { get; }
		string ModifiedBy { get; }
		System.DateTime ModifiedUtcDate { get; }
		System.Guid? PhotoBlobFileId { get; }
		int PreferredLanguageId { get; }
		string TwitterUrl { get; }
		int UserProfileId { get; }

		// Excluding 'AspNetUser' per configuration setting.
		IBlobFile BlobFile { get; }
		IGenderType GenderType { get; }
		ILanguageType LanguageType { get; }
		// Excluding 'Feedback' per configuration setting.
		// Excluding 'SessionLike' per configuration setting.
		// Excluding 'SessionSpeaker' per configuration setting.


	}
}
