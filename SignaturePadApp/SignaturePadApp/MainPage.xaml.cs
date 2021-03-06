﻿using System;
using System.IO;
using SignaturePad.Forms;
using Xamarin.Forms;

namespace SignaturePadApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            Stream image = await PadView.GetImageStreamAsync(SignatureImageFormat.Jpeg);
            // you can add code here to save the Stream image.
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            PadView.Clear();
        }
    }
}
