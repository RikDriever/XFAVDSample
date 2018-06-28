using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFAVDSample.Droid;
using XFAVDSample.Views;

[assembly: ExportRenderer(typeof(AnimatedImageView), typeof(AnimatedImageViewRenderer))]
namespace XFAVDSample.Droid
{
    class AnimatedImageViewRenderer : ProgressBarRenderer
    {
        public AnimatedImageViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
        {
            base.OnElementChanged(e);
            CreateAnimatedImageView((AnimatedImageView)e.NewElement);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }

        private void CreateAnimatedImageView(AnimatedImageView animatedImageView)
        {
            if (Control != null)
            {
                var progressBar = Control as Android.Widget.ProgressBar;
                progressBar.IndeterminateDrawable = Context.GetDrawable(animatedImageView.SourceUrl);
                progressBar.Indeterminate = true;
            }
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
        }

    }
}