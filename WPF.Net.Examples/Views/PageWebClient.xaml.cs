﻿using System.Windows;
using WPF.Net.Examples.ViewModels;

// ReSharper disable UnusedMember.Global

namespace WPF.Net.Examples.Views
{
    public partial class PageWebClient
    {
        #region Private fields and properties

        private AppSettings _appSet;

        #endregion

        #region Constructor and destructor

        public PageWebClient()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        private void PageWebClient_Loaded(object sender, RoutedEventArgs e)
        {
            _appSet = ViewModels.Utils.GetSettings(this);
        }

        private void ButtonFileDownload_OnClick(object sender, RoutedEventArgs e)
        {
            _appSet.WebClient.Download(fieldOut, false, progressBar);
        }

        private void ButtonFileDownloadAsync_OnClick(object sender, RoutedEventArgs e)
        {
            _appSet.WebClient.Download(fieldOut, true, progressBar);
        }

        private void ButtonFileDownloadWithProgress_OnClick(object sender, RoutedEventArgs e)
        {
            _appSet.WebClient.DownloadWithBuffer(fieldOut, progressBar);
        }

        #endregion
    }
}
