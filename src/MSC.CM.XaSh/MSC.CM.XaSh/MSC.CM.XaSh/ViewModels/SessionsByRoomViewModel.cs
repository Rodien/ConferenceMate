﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MSC.CM.Xam.ModelObj.CM;
using Xamarin.Forms;
using MSC.CM.Xam;
using MSC.CM.XaSh.Services;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Microsoft.AppCenter.Crashes;
using System.Diagnostics;

namespace MSC.CM.XaSh.ViewModels
{
    public class SessionsByRoomViewModel : BaseViewModel
    {
        public SessionsByRoomViewModel(IDataStore store = null, IDataLoader loader = null)
        {
            DataStore = store;
            DataLoader = loader;
            Title = "Sessions By Room";
            Sessions = new ObservableCollection<Session>();
        }

        public IDataLoader DataLoader { get; set; }

        public IDataStore DataStore { get; set; }

        public ObservableCollection<Session> Sessions { get; private set; }

        public async Task RefreshListViewData()
        {
            if (IsBusy) { return; }

            IsBusy = true;

            try
            {
                if ((Connectivity.NetworkAccess == NetworkAccess.Internet && await DataLoader.HeartbeatCheck()) || App.UseSampleDataStore)
                {
                    //load SQLite from API or sample data
                    var ctUsers = await DataLoader.LoadUsersAsync();
                    Debug.WriteLine($"Loaded {ctUsers} Users.");
                    var ctRooms = await DataLoader.LoadRoomsAsync();
                    Debug.WriteLine($"Loaded {ctRooms} Rooms.");
                    var ctSessions = await DataLoader.LoadSessionsAsync();
                    Debug.WriteLine($"Loaded {ctSessions} Sessions.");
                    var ctSessionSpeakers = await DataLoader.LoadSessionSpeakersAsync();
                    Debug.WriteLine($"Loaded {ctSessionSpeakers} SessionSpeakers.");
                }

                //clear local list
                Sessions.Clear();

                //populate local list
                var items = await DataStore.GetSessionsAsync();
                foreach (var item in items)
                {
                    Sessions.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                Crashes.TrackError(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}