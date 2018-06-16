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
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.ApplicationModel;

namespace FanKit.Frames.Template
{
    public sealed partial class FlyoutTemplatePage : Page
    {
        public FlyoutTemplatePage()
        {
            this.InitializeComponent();
        }



        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.MarkdownText1.Text = await FanKit.Library.File.GetFile("ms-appx:///TXT/Template/FlyoutTemplateXaml.txt");
            this.MarkdownText2.Text = await FanKit.Library.File.GetFile("ms-appx:///TXT/Template/FlyoutTemplateStyle.txt");
        }
         


        private async void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Flyout.ShowAt(this.Button);
            await Task.Delay(500);
            this.Flyout.Hide();

            this.FlyoutLeft.ShowAt(this.ButtonLeft);
            await Task.Delay(500);
            this.FlyoutLeft.Hide();

            this.FlyoutTop.ShowAt(this.ButtonTop);
            await Task.Delay(500);
            this.FlyoutTop.Hide();

            this.FlyoutRight.ShowAt(this.ButtonRight);
            await Task.Delay(500);
            this.FlyoutBottom.Hide();

            this.FlyoutBottom.ShowAt(this.ButtonBottom);
            await Task.Delay(500);
            this.FlyoutBottom.Hide();
        }



    }
}
