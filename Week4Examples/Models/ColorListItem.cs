using System;
using Xamarin.Forms;

namespace Week4Examples.Models
{
    public class ColorListItem
    {
        public Color ColorValue
        {
            get;
            set;
        }

        public string ColorText
        {
            get;
            set;
        }

        public string ColorRGB
        {
            get
            {
                var RGBasString = $" R:{ColorValue.R.ToString()}, G:{ColorValue.B.ToString()}, B:{ColorValue.G.ToString()}";
                return RGBasString;
            }
        }
    }
}
