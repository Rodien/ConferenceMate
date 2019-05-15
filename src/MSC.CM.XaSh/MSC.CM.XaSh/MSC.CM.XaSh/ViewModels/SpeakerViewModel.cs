﻿using MSC.CM.Xam.ModelObj.CM;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using MSC.CM.Xam;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using MSC.CM.XaSh.Services;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AppCenter.Crashes;
using GalaSoft.MvvmLight.Command;
using Xamarin.Essentials;

namespace MSC.CM.XaSh.ViewModels
{
    public class SpeakerViewModel : BaseViewModel
    {
        public SpeakerViewModel(IDataStore store = null, IDataLoader loader = null)
        {
            DataStore = store;
            DataLoader = loader;
            Title = "Speakers";
            Speakers = new ObservableCollection<SessionSpeaker>();
        }

        public IDataLoader DataLoader { get; set; }

        public IDataStore DataStore { get; set; }

        public ObservableCollection<SessionSpeaker> Speakers { get; private set; }

        public async Task RefreshListViewData()
        {
            if (IsBusy) { return; }

            IsBusy = true;

            try
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet && await DataLoader.HeartbeatCheck())
                {
                    //load SQLite from API or sample data
                    await DataLoader.LoadAnnouncementsAsync();
                }

                //clear local list
                Speakers.Clear();

                //populate local list
                var items = await DataStore.GetSpeakersAsync();
                foreach (var item in items)
                {
                    Speakers.Add(item);
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}