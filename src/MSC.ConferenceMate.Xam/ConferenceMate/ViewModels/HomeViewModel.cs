﻿using GalaSoft.MvvmLight.Command;
using ConferenceMate.Interfaces;
using ConferenceMate.Mappers;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using MSC.CM.Xam.ModelObj.CM;

namespace ConferenceMate.ViewModels
{
	public class HomeViewModel : CustomViewModelBase
	{
		private User _selectedUser;
		private ObservableCollection<User> _user;

		public HomeViewModel(INavigationService navService, IDataLoadService dataLoadService, IDataRetrievalService dataRetrievalService)
			: base(navService, dataLoadService, dataRetrievalService)
		{
		}

		public RelayCommand AboutCommand
		{
			get
			{
				return new RelayCommand(async () =>
				{
					await NavService.NavigateTo<AboutViewModelMVVMDI>();
				});
			}
		}

		public RelayCommand AccountCommand
		{
			get
			{
				return new RelayCommand(async () =>
				{
					await NavService.NavigateTo<AccountViewModel>();
				});
			}
		}

		public RelayCommand FeedbackCommand
		{
			get
			{
				return new RelayCommand(async () =>
				{
					//we don't want to require permissions...just check them
					await Helpers.Helpers.CheckLocationPermissions();

					await NavService.NavigateTo<FeedbackViewModel>();
				});
			}
		}

		public RelayCommand MapCommand
		{
			get
			{
				return new RelayCommand(async () =>
				{
					if (await Helpers.Helpers.CheckLocationPermissions())
					{
						await NavService.NavigateTo<MapViewModel>();
					}
				});
			}
		}

		public User SelectedUser
		{
			get { return _selectedUser; }
			set
			{
				if (Set(nameof(SelectedUser), ref _selectedUser, value))
				{
					if (SelectedUser != null)
					{
						DataRetrievalService.SetCurrentUserId(SelectedUser.UserId);
					}
				}
			}
		}

		public ObservableCollection<User> UserList
		{
			get { return _user; }
			set { Set(nameof(UserList), ref _user, value); }
		}

		public RelayCommand UserLocationCommand
		{
			get
			{
				return new RelayCommand(async () =>
				{
					if (await Helpers.Helpers.CheckLocationPermissions())
					{
						await NavService.NavigateTo<UserLocationViewModel>();
					}
				});
			}
		}

		public async override Task Init()
		{
			await base.CheckAppCenter();
			await base.CheckBadQueuedRecords();

			UserList = (await DataRetrievalService.GetAllUsers()).ToObservableCollection();
			if (UserList.Any()) { SelectedUser = UserList[0]; }
		}
	}
}