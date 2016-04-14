﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SQLiteSample
{
    public enum AddItemResult
    {
        SUCCESS,
        FAIL,
        CANCELL,
        NOTHING
    }
    public sealed partial class AddItemDialog : ContentDialog
    {
        public AddItemResult Result { get; set; }
        public String ItemContent { get; set; }
        public AddItemDialog()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            this.Result = AddItemResult.SUCCESS;
            this.ItemContent = tbxItem.Text;
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            this.Result = AddItemResult.CANCELL;
        }
    }
}
