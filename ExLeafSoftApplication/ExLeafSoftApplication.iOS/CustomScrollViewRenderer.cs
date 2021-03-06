﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExLeafSoftApplication.Common;
using ExLeafSoftApplication.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomScrollView), typeof(CustomScrollViewRenderer))]
namespace ExLeafSoftApplication.iOS
{
    public class CustomScrollViewRenderer: ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as CustomScrollView;
            element?.Render();
        }
    }
}