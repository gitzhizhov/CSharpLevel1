using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    class ComplexClass
    {
        private double re, im;

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }

        public ComplexClass()
        {
            Im = 0;
            Re = 0;
        }

        public ComplexClass(double re, double im)
        {
            this.Re = re;
            this.Im = im;
        }

        public override string ToString()
        {
            if (re == 0)
                return $"{im}i";
            if (im == 0)
                return $"{re}";
            if (im < 0)
                return $"{re} - {-im}i";
            return $"{re} + {im}i";
        }

        /// <summary>
        /// Суммирует комплексые числа
        /// </summary>
        /// <param name="cc2"></param>
        /// <returns>Complex</returns>
        public ComplexClass Plus(ComplexClass cc2)
        {
            ComplexClass res = new ComplexClass();
            res.re = cc2.re + Re;
            res.im = cc2.im + Im;
            return res;
        }

        /// <summary>
        /// Вычитает комплексные числа
        /// </summary>
        /// <param name="cc2"></param>
        /// <returns>Complex</returns>
        public ComplexClass Diff(ComplexClass cc2)
        {
            ComplexClass res = new ComplexClass();
            res.re = Re - cc2.re;
            res.im = Im - cc2.im;
            return res;
        }

        /// <summary>
        /// Перемножает коплексные числа
        /// </summary>
        /// <param name="cc2"></param>
        /// <returns>Complex</returns>
        public ComplexClass Multi(ComplexClass cc2)
        {
            ComplexClass res = new ComplexClass();
            res.re = Re * cc2.re - Im * cc2.im;
            res.im = Im * cc2.re + Re * cc2.im;
            return res;
        }
    }
}
