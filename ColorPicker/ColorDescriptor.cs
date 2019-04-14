using System;
using System.Drawing;

namespace ColorPicker
{
    class ColorDescriptor : IComparable
    {
        public string Token { get; set; }
        public string Name { get; set; }
        public Color RGB { get; set; }

        public string Hex
        {
            get
            {
                return string.Format("#{0:X2}{1:X2}{2:X2}", RGB.R, RGB.G, RGB.B);
            }
        }

        public int CompareTo(object obj)
        {
            if (!(obj is ColorDescriptor))
                return 1;
            ColorDescriptor other = (ColorDescriptor)obj;
            if (RGB.GetSaturation() < 0.01f && other.RGB.GetSaturation() < 0.01f)
                return RGB.GetBrightness().CompareTo(other.RGB.GetBrightness());
            if (RGB.GetSaturation() < 0.01f && other.RGB.GetSaturation() >= 0.01f)
                return -1;
            if (RGB.GetSaturation() >= 0.01f && other.RGB.GetSaturation() < 0.01f)
                return 1;
            var h = RGB.GetHue().CompareTo(other.RGB.GetHue());
            if (h != 0)
                return h;
            var v = RGB.GetBrightness().CompareTo(other.RGB.GetBrightness());
            if (v != 0)
                return v;
            return RGB.GetSaturation().CompareTo(other.RGB.GetSaturation());
        }
    }
}
