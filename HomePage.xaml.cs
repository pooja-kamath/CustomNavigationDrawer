// ========================================================================
// Sivantos GmbH
// Copyright (c) 2015
// ========================================================================

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XYZ.Core.UILayer.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
      
        public HomePage()
        {
          InitializeComponent();
        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            if (stackLayout.Height == 0)
            {
                Action<double> callback = input => stackLayout.HeightRequest = input;
                double startingHeight = 0;
                double endingHeight = 200;
                uint rate = 16;
                uint length = 3000;
                Easing easing = Easing.CubicOut;
                stackLayout.Animate("invis", callback, startingHeight, endingHeight, rate, length, easing);
            }
            else
           {
                Action<double> callback = input => stackLayout.HeightRequest = input;
                double startingHeight = 200;
                double endingHeight = 0;
                uint rate = 16;
                uint length = 3000;
                Easing easing = Easing.CubicIn;
                stackLayout.Animate("inviss", callback, startingHeight, endingHeight, rate, length, easing);

            }
        }

    }
}
