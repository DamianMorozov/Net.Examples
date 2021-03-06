﻿using System.Windows;
using WPF.Net.Examples.ViewModels;
// ReSharper disable NotAccessedField.Local

namespace WPF.Net.Examples.Views
{
    public partial class PageProxy
    {
        #region Private fields and properties

        private AppSettings AppSettings { get; set; }

        #endregion

        #region Constructor and destructor

        public PageProxy()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        private void PageProxy_Loaded(object sender, RoutedEventArgs e)
        {
            AppSettings = ViewModels.Utils.GetSettings(this);
        }

        #endregion
    }
}
