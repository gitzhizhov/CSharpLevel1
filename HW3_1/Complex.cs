using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    struct Complex
    {
        public double re, im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        // пергрузка метода 
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
        /// Cсумирование комплексных чисел
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Complex</returns>
        static public Complex Sum(Complex c1, Complex c2)
        {
            Complex res;
            res.im = c1.im + c2.im;
            res.re = c1.re + c2.re;
            return res;
        }

        // перегрузка операции +
        static public Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(
                re: c1.re + c2.re,
                im: c1.im + c2.im
                );
        }

        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Complex</returns>
        static public Complex Diff(Complex c1, Complex c2)
        {
            Complex res;
            res.im = c1.im - c2.im;
            res.re = c1.re - c2.re;
            return res;
        }
    }
}
