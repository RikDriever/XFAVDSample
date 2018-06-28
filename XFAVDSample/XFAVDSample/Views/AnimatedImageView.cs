using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFAVDSample.Views
{
    public class AnimatedImageView : ProgressBar
    {
        public static readonly BindableProperty SourceUrlProperty = BindableProperty.Create(
            propertyName: nameof(SourceUrl),
            returnType: typeof(string),
            declaringType: typeof(AnimatedImageView));
        public string SourceUrl
        {
            get => (string)GetValue(SourceUrlProperty);
            set => SetValue(SourceUrlProperty, value);
        }
    }
}
