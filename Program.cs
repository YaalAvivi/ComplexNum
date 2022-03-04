using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CompleNum
{
    static class Program
    {
        public static double Det2a1(double[,] arr, double[] arr2)
        {
            double det = arr[0, 0] * arr[1, 1] - arr[1, 0] * arr[0, 1];
            double detX = arr2[0] * arr[1, 1] - arr[0, 1] * arr2[1];
            return detX / det;
        }
        public static double Det2a2(double[,] arr, double[] arr2)
        {
            double det = arr[0, 0] * arr[1, 1] - arr[1, 0] * arr[0, 1];
            double detX = arr[0,0] * arr2[1] - arr2[0] * arr[1,0];
            return detX / det;
        }
        public static double Det3a1(double[,] arr, double[] arr2)
        {
            double det = arr[0, 0] * arr[1, 1] * arr[2, 2] + arr[0, 1] * arr[1, 2] * arr[2, 0] + arr[1, 0] * arr[2, 1] * arr[0, 2] - (arr[0, 2] * arr[1, 1] * arr[2, 0] + arr[0, 1] * arr[1, 0] * arr[2, 2] + arr[2, 1] * arr[1, 2] * arr[0, 0]);
            double detX = arr2[0] * arr[1, 1] * arr[2, 2] + arr[0, 1] * arr[1, 2] * arr2[2] + arr2[1] * arr[2, 1] * arr[0, 2] - (arr[0, 2] * arr[1, 1] * arr2[2] + arr[0, 1] * arr2[1] * arr[2, 2] + arr[2, 1] * arr[1, 2] * arr2[0]);
            return detX / det;
        }
        public static double Det3a2(double[,] arr, double[] arr2)
        {
            double det = arr[0, 0] * arr[1, 1] * arr[2, 2] + arr[0, 1] * arr[1, 2] * arr[2, 0] + arr[1, 0] * arr[2, 1] * arr[0, 2] - (arr[0, 2] * arr[1, 1] * arr[2, 0] + arr[0, 1] * arr[1, 0] * arr[2, 2] + arr[2, 1] * arr[1, 2] * arr[0, 0]);
            double detX = arr[0, 0] * arr2[1] * arr[2, 2] + arr2[0] * arr[1, 2] * arr[2, 0] + arr[1, 0] * arr2[2] * arr[0, 2] - (arr[0, 2] * arr2[1] * arr[2, 0] + arr2[0] * arr[1, 0] * arr[2, 2] + arr2[2] * arr[1, 2] * arr[0, 0]);
            return detX / det;
        }
        public static double Det3a3(double[,] arr, double[] arr2)
        {
            double det = arr[0, 0] * arr[1, 1] * arr[2, 2] + arr[0, 1] * arr[1, 2] * arr[2, 0] + arr[1, 0] * arr[2, 1] * arr[0, 2] - (arr[0, 2] * arr[1, 1] * arr[2, 0] + arr[0, 1] * arr[1, 0] * arr[2, 2] + arr[2, 1] * arr[1, 2] * arr[0, 0]);
            double detX = arr[0, 0] * arr[1, 1] * arr2[2] + arr[0, 1] * arr2[1] * arr[2, 0] + arr[1, 0] * arr[2, 1] * arr2[0] - (arr2[0] * arr[1, 1] * arr[2, 0] + arr[0, 1] * arr[1, 0] * arr2[2] + arr[2, 1] * arr2[1] * arr[0, 0]);
            return detX / det;
        }
        public static string QadraticEquationPositive(string a, string b, string c)
        {
            string Delta = SubstractTwoComplex(MultiTwoComplex(b, b), MultiTwoComplex("4", MultiTwoComplex(a, c)));
            if (GetImaginryPart(Delta) == 0)
                Delta = "" + (Math.Sqrt(Convert.ToDouble(Delta)));
            else
                Delta = "" + Root(Delta);
            string s1 = MultiTwoComplex("-1", b);
            string s2 = AddTwoComplex(MultiTwoComplex("-1", b), Delta);
            string s3=DivideTwoComplex(AddTwoComplex(MultiTwoComplex("-1", b), Delta), MultiTwoComplex("2", a));
            return DivideTwoComplex(AddTwoComplex(MultiTwoComplex("-1", b), Delta), MultiTwoComplex("2", a));
        }
        public static string QadraticEquationNegtaive(string a, string b, string c)
        {
            string Delta = SubstractTwoComplex(MultiTwoComplex(b, b), MultiTwoComplex("4", MultiTwoComplex(a, c)));
            if (GetImaginryPart(Delta) == 0)
                Delta = "" + (Math.Sqrt(Convert.ToDouble(Delta)));
            else
                Delta = "" + Root(Delta);
            string s1 = MultiTwoComplex("-1", b);
            string s2 = AddTwoComplex(MultiTwoComplex("-1", b), Delta);
            string s3 = DivideTwoComplex(AddTwoComplex(MultiTwoComplex("-1", b), Delta), MultiTwoComplex("2", a));
            return DivideTwoComplex(SubstractTwoComplex(MultiTwoComplex("-1", b), Delta), MultiTwoComplex("2", a));
        }
        public static string Root(string z)
        {
            double a = GetRealPart(z);
            double b = GetImaginryPart(z);
            double y = Math.Sqrt((-a + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) / 2);
            double x=b/(2*y);
            return createImaginryNumber(x, y);

        }
        public static double GetR(string z)
        {
            return returnFullNum(Math.Sqrt(Math.Pow(GetRealPart(z), 2) + Math.Pow(GetImaginryPart(z), 2)));
        }
        public static double GetDegree(string z)
        {
            double real = GetRealPart(z), imaginry = GetImaginryPart(z),angle=0;
            
            if (real > 0)
            {
                if (imaginry >= 0)
                    angle=(Math.Atan(imaginry / real));
                else
                    angle = (Math.Atan(imaginry / real)) + 2 * Math.PI;
            }
            else if (real < 0)
                angle = (Math.Atan(imaginry / real)) + Math.PI;
            else if (real == 0)
                if (imaginry > 0)
                    angle = (Math.PI / 2);
                else if (imaginry < 0)
                    angle = (3 / 2) * (Math.PI);
                else
                    return 0;
            angle = returnFullNum((angle / Math.PI) * 180);
            return angle;
        }
        public static string createPolarImaginryNumberRad(double real, double imaginry)
        {
            double r = returnFullNum(Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginry, 2)));
            double angle=-1;
            if (real > 0)
            {
                if (imaginry >= 0)
                    angle = (Math.Atan(imaginry / real));
                else
                    angle = (Math.Atan(imaginry / real)) + 2 * Math.PI;
            }
            else if (real < 0)
                angle = (Math.Atan(imaginry / real)) + Math.PI;
            else if (real == 0)
                if (imaginry > 0)
                    angle = (Math.PI / 2);
                else if (imaginry < 0)
                    angle = (3 / 2) * (Math.PI);
                else
                    return "indeterminate";
            if(angle/Math.PI==returnFullNum(angle/Math.PI))
            {
                angle=angle/Math.PI;
                if(angle==0)
                    return (""+r+"cis("+angle+")");
                else if(angle==1)
                    return ("" + r + "cis(π)");
            }
            else
            {
                angle =returnFullNum(angle);
                return (""+r+"cis("+angle+")");
            }

            return ("" + r + "cis(" + angle + "π)");
        }
        public static string createPolarImaginryNumberDeg(double real, double imaginry)
        {
            double r = returnFullNum(Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginry, 2)));
            double angle = -1;
            if (real > 0)
            {
                if(imaginry>=0)
                    angle = (Math.Atan(imaginry / real));
                else
                    angle = (Math.Atan(imaginry / real))+2*Math.PI;
            }
            else if (real < 0)
                angle = (Math.Atan(imaginry / real)) + Math.PI;
            else if (real == 0)
                if (imaginry > 0)
                    angle = (Math.PI / 2);
                else if (imaginry < 0)
                    angle = (3/2)*(Math.PI);
                else
                    return "indeterminate";
            angle = returnFullNum((angle / Math.PI) * 180);
            return ("" + r + "cis("+angle+")");
        }
        public static double returnFullNum(double num)
        {
            int num2 = (int)(num * 100);
            double num3 = (double)(num2);
            double num4 = num3 / 100;
            return num4;
        }
        public static double GetImaginryPart(string z)
        {
            string Imaginry = "";
            int g=-1;
            for (int i = 0; i < z.Length; i++)
            {
                if ((z[i] != '0') && ((z[i] == '+') || (z[i] == '-'))&&(!((z[i]=='-')&&(i==0))))
                    g = i;
            }
            if (g == -1)
            {
                bool IfI = false;
                for (int i = 0; i < z.Length; i++)
                    if (z[i] == 'i')
                        IfI = true;
                if (IfI)
                {
                    if ((z.Length == 1)&&(z[0]=='i'))
                        return 1;
                    else if ((z.Length == 2) && (z[0] == '-') && (z[1]=='i'))
                        return -1;
                    else
                        return Convert.ToDouble(z.Substring(0, z.Length - 1));
                }
                else
                    return 0;
            }
            else
            {
                Imaginry = z.Substring(g, z.Length - g - 1);
                if (Imaginry == "+")
                    return 1;
                else if (Imaginry == "-")
                    return -1;
                return Convert.ToDouble(Imaginry);
            }
        }
        public static double GetRealPart(string z)
        {
            string Real = "";
            int g = -1;
            for (int i = 0; i < z.Length; i++)
            {
                if ((z[i] != 0) && ((z[i] == '+') || (z[i] == '-')))
                    g = i-1;
            }
            if (g == -1)
            {
                bool IfI = false;
                for (int i = 0; i < z.Length; i++)
                    if (z[i] == 'i') 
                        IfI=true;
                if (IfI)
                    return 0;
                else
                    return Convert.ToDouble(z);
            }

            else
            {
                Real = z.Substring(0, g + 1);
                return Convert.ToDouble(Real);
            }
        }
        public static string GetConjugate(string z)
        {
            double Imaginry = GetImaginryPart(z);
            if (Imaginry > 0)
                return Convert.ToString(GetRealPart(z) + "-" + Imaginry+"i");
            else if (Imaginry < 0)
                return Convert.ToString(GetRealPart(z) + "+" + (Imaginry * -1)+"i");
            else
                return Convert.ToString(GetRealPart(z) + "");
        }
        public static string createImaginryNumber(double real, double imaginry)
        {
            string complex = "";
            if (real == 0)
            {
                if (imaginry == 0)
                    complex += "0";
                else if (imaginry == 1)
                    complex += "i";
                else if (imaginry == -1)
                    complex += "-i";
                else
                    complex +=imaginry + "i";
            }
            else
            {
                complex += real + "";
                if (imaginry == 0)
                {
                }
                else if (imaginry == 1)
                    complex += "+i";
                else if (imaginry == -1)
                    complex += "-i";
                else if (imaginry < 0)
                    complex += imaginry + "i";
                else
                    complex += "+" + imaginry+"i";
            }
            return complex;
        }
        public static string AddTwoComplex(string z1, string z2)
    {
        double rz1 = GetRealPart(z1), rz2 = GetRealPart(z2), iz1 = GetImaginryPart(z1), iz2 = GetImaginryPart(z2);
        string z1z2 = createImaginryNumber(rz1 + rz2, iz1 + iz2);
        return z1z2;
    }
        public static string SubstractTwoComplex(string z1, string z2)
        {
            double rz1 = GetRealPart(z1), rz2 = GetRealPart(z2), iz1 = GetImaginryPart(z1), iz2 = GetImaginryPart(z2);
            string z1z2 = createImaginryNumber(rz1 - rz2, iz1 - iz2);
            return z1z2;
        }
        public static string MultiTwoComplex(string z1, string z2)
        {
            double rz1 = CompleNum.Program.GetRealPart(z1);
            double rz2 = CompleNum.Program.GetRealPart(z2);
            double iz1 = CompleNum.Program.GetImaginryPart(z1);
            double iz2 = CompleNum.Program.GetImaginryPart(z2);
            double real = rz1 * rz2 - iz1 * iz2;
            double imaginry = rz1 * iz2 + rz2 * iz1;
            string z1z2 = createImaginryNumber(real, imaginry);
            return z1z2;
        }
        public static string DivideTwoComplex(string z1, string z2)
        {
            string numerator = "", z1z2;
            string z2c = Program.GetConjugate(z2);
            double rz1, rz2, iz1, iz2, NumReal, NumImaginry, izc, divider, real, imaginry;
            rz1 = CompleNum.Program.GetRealPart(z1);
            rz2 = CompleNum.Program.GetRealPart(z2);
            iz1 = CompleNum.Program.GetImaginryPart(z1);
            iz2 = CompleNum.Program.GetImaginryPart(z2);
            izc = Program.GetImaginryPart(z2c);
            NumReal = rz1 * rz2 - iz1 * izc;
            NumImaginry = rz1 * izc + rz2 * iz1;
            numerator = Program.createImaginryNumber(NumReal, NumImaginry);
            divider = rz2 * rz2 - iz2 * izc;
            real =returnFullNum (NumReal / divider);
            imaginry = returnFullNum(NumImaginry / divider);
            z1z2 = Program.createImaginryNumber(real, imaginry);
            return z1z2;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
        }
    }
}
