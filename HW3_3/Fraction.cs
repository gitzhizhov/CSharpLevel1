using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    class Fraction
    {
        private int num, den; // числитель, знаменатель

        public Fraction() { }

        public Fraction(int num, int den)
        {
            this.Num = num;
            this.Den = den;
        }

        public int Num { get => num; set => num = value; }
        public int Den
        {
            get { return den; }
            set { if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0"); else den = value; }
        }

        public override string ToString()
        {
            return $"{num}/{den}";
        }

        /// <summary>
        /// Упрощение дроби
        /// </summary>
        /// <param name="f"></param>
        /// <returns>Дробь</returns>
        private Fraction Reduce(ref Fraction f)
        {
            for (int i = 2; i < Math.Max(f.num, f.den); i++)
            {
                if (f.num % i == 0 && f.den % i == 0)
                {
                    f.num /= i;
                    f.den /= i;
                    i = 1;
                }
            }
            return f;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="f2"></param>
        /// <returns>Дробь</returns>
        public Fraction Plus(Fraction f2)
        {
            Fraction f3 = new Fraction
            {
                num = this.num * f2.den + f2.num * this.den,
                den = this.den * f2.den
            };
            Reduce(ref f3);
            return f3;
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="f2"></param>
        /// <returns>Дробь</returns>
        public Fraction Diff(Fraction f2)
        {
            Fraction f3 = new Fraction
            {
                num = this.num * f2.den - f2.num * this.den,
                den = this.den * f2.den
            };
            Reduce(ref f3);
            return f3;
        }

        /// <summary>
        /// Перемножение дробей
        /// </summary>
        /// <param name="f2"></param>
        /// <returns>Дробь</returns>
        public Fraction Multi(Fraction f2)
        {
            Fraction f3 = new Fraction
            {
                num = this.num * f2.num,
                den = this.den * f2.den
            };
            Reduce(ref f3);
            return f3;
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        /// <param name="f2"></param>
        /// <returns>Дробь</returns>
        public Fraction Divis(Fraction f2)
        {
            Fraction f3 = new Fraction
            {
                num = this.num * f2.den,
                den = this.den * f2.num
            };
            Reduce(ref f3);
            return f3;
        }
    }
}
