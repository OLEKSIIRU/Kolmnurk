using System;
using System.Windows.Forms;

namespace Kolmnurk
{
    public class Triangle
    {
        public double A;
        public double B;
        public double C;
        public double S;
        public double H;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Triangle(double s, double h)
        {
            S = s;
            H = h;
        }

        public string TriangleType
        {
            get
            {
                if (ExistTriangle)
                {
                    if (A == B && B == C && A == C)
                    {
                        return "võrdkülgne";
                    }
                    else if (A == B || B == C || A == C)
                    {
                        return "võrdhaarne";
                    }
                    else
                    {
                        return "erikülgne";
                    }
                }
                else
                {
                    return "tundmatu tüüp";
                }
            }
        }

        public bool ExistTriangle
        {
            get
            {
                return A + B > C && A + C > B && B + C > A;
            }
        }

        public void ImageTriangleType(PictureBox pictureBox, CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                string triangleType = TriangleType.ToLower();
                switch (triangleType)
                {
                    case "võrdkülgne":
                        pictureBox.Image = Properties.Resources.ravnostr1;
                        break;
                    case "võrdhaarne":
                        pictureBox.Image = Properties.Resources.ravnobedr1;
                        break;
                    case "erikülgne":
                        pictureBox.Image = Properties.Resources.razno1;
                        break;
                    default:
                        Console.WriteLine("Неизвестный тип треугольника");
                        break;
                }
            }
            else
            {
                pictureBox.Image = null;
            }
        }

        public double GetSetA
        {
            get { return A; }
            set { A = value; }
        }

        public double GetSetB
        {
            get { return B; }
            set { B = value; }
        }

        public double GetSetC
        {
            get { return C; }
            set { C = value; }
        }

        public double GetSetS
        {
            get { return S; }
            set { S = value; }
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double PerimentrL()
        {
            return (A + B + C) / 2;
        }

        public double Area()
        {
            double s = 0;
            if (ExistTriangle)
            {
                double p = (A + B + C) / 2;
                s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            return s;
        }

        public string OutputA()
        {
            return A.ToString();
        }

        public string OutputB()
        {
            return B.ToString();
        }

        public string OutputC()
        {
            return C.ToString();
        }
    }
}
