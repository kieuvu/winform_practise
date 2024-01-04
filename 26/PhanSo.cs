using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class PhanSo
    {
        private int tuso;
        private int mauso;

        public PhanSo(int tuso, int mauso)
        {
            if (mauso == 0)
            {
                throw new ArgumentException("Mau so phai khac 0.");
            }

            this.tuso = tuso;
            this.mauso = mauso;
        }

        public int getTuSo()
        {
            return tuso;
        }

        public int getMauSo()
        {
            return mauso;
        }

        private void RutGon()
        {
            int gcd = GCD(Math.Abs(tuso), Math.Abs(mauso));
            tuso /= gcd;
            mauso /= gcd;

            if (mauso < 0)
            {
                tuso = -tuso;
                mauso = -mauso;
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            int newTuso = a.tuso * b.mauso + b.tuso * a.mauso;
            int newMauso = a.mauso * b.mauso;
            PhanSo result = new PhanSo(newTuso, newMauso);
            result.RutGon();
            return result;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            int newTuso = a.tuso * b.mauso - b.tuso * a.mauso;
            int newMauso = a.mauso * b.mauso;
            PhanSo result = new PhanSo(newTuso, newMauso);
            result.RutGon();
            return result;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int newTuso = a.tuso * b.tuso;
            int newMauso = a.mauso * b.mauso;
            PhanSo result = new PhanSo(newTuso, newMauso);
            result.RutGon();
            return result;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.tuso == 0)
            {
                throw new DivideByZeroException("Khong the chia cho 0.");
            }

            int newTuso = a.tuso * b.mauso;
            int newMauso = a.mauso * b.tuso;
            PhanSo result = new PhanSo(newTuso, newMauso);
            result.RutGon();
            return result;
        }

        public override string ToString()
        {
            return tuso + "/" + mauso;
        }
    }
}
