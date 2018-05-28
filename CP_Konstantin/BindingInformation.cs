using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CP_Konstantin
{
    public class BindingInformation
    {
        public BindingInformation()
        {}
        private SolidColorBrush mouseOverColor = new SolidColorBrush();
        public SolidColorBrush MouseOverColor
        {
            get { return mouseOverColor; }
            set { mouseOverColor = value; }
        }
        private SolidColorBrush selectedColor = new SolidColorBrush();
        public SolidColorBrush SelectedColor
        {
            get { return selectedColor; }
            set { selectedColor = value; }
        }
        private string rGB;
        public string RGB
        {
            get {
                SetRGB();
                return rGB; }
            set { ; }
        }
        private string hEX;
        public string HEX
        {
            get {
                SetHEX();
                return hEX; }
            set { ; }
        }
        private string colorReport;
        public string ColorReport
        {
            get { return colorReport; }
            set {; }
        }

        private void SetRGB()
        {
            rGB = "Red, Green, Blue, Alpha = [" + mouseOverColor.Color.R + "," +
                mouseOverColor.Color.G + "," + mouseOverColor.Color.B + "," + mouseOverColor.Color.A + "]";
        }
        private void SetHEX()
        {
            hEX = ("HEX Code = #" + mouseOverColor.Color.R.ToString("X") +
               mouseOverColor.Color.G.ToString("X") + mouseOverColor.Color.B.ToString("X")).ToUpper();
        }
        public void SetBrightness(double Coeficient)
        {
            byte a = CheckLimitAndReturnValue(selectedColor.Color.A + Coeficient);
            byte r = CheckLimitAndReturnValue(selectedColor.Color.R + Coeficient);
            byte g = CheckLimitAndReturnValue(selectedColor.Color.G + Coeficient);
            byte b = CheckLimitAndReturnValue(selectedColor.Color.B + Coeficient);
            mouseOverColor.Color = Color.FromArgb(a, r, g, b);
        }
        public void SetLumia(double Coeficient)
        {
            byte a = CheckLimitAndReturnValue(selectedColor.Color.A);
            byte r = CheckLimitAndReturnValue(selectedColor.Color.R+0.299*Coeficient);
            byte g = CheckLimitAndReturnValue(selectedColor.Color.G+0.587*Coeficient);
            byte b = CheckLimitAndReturnValue(selectedColor.Color.B+0.73*Coeficient);
            mouseOverColor.Color = Color.FromArgb(a, r, g, b);
        }
        public void MakeColorReport()
        {
            double rPrim = ((double)mouseOverColor.Color.R ) / 255;
            double gPrim = ((double)mouseOverColor.Color.G )/ 255;
            double bPrim = ((double)mouseOverColor.Color.B )/ 255;
            double K = Compare(rPrim, gPrim, bPrim);
            StringBuilder report = new StringBuilder();
            report.Append("Color Report:\n\n");
            report.Append(rGB + "\n");
            report.Append(hEX+"\n");
            report.Append("Cyan , Magenta, Yellow, Black Key\n");
            report.Append(("(C,M,Y,K)  = ["+ K.ToString("0.####")+" , "+
                ((1-rPrim-K)/(1-K)).ToString("0.####") + " , " +
                ((1 - gPrim - K) / (1 - K)).ToString("0.####") + " , " +
                ((1 - bPrim - K) / (1 - K)).ToString("0.####") + "]\n\n")); //CMYK
            report.Append("Date :"+ DateTime.Now);
            colorReport = report.ToString();
        }
        private byte CheckLimitAndReturnValue(double ComponentValue)
        {
            byte temp = 0;
            if (ComponentValue <= 255 && ComponentValue >= 0)
                temp = (byte)(ComponentValue);
            else if (ComponentValue >= 255)
                temp = 255;
            else if (ComponentValue <= 0)
                temp = 0;
            return temp;
        }
        private double Compare(double r, double g, double b)
        {
            if (r - Math.Max(g,b) > 0.0001)
                 return r;
            if (g - Math.Max(r,b) > 0.0001)
                return g;
            if (b - Math.Max(g, r) > 0.0001)
                return b;
            else
                return 0;
        }
    }
}
