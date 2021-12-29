﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class Cheque : Document, IOrganization
    {
        public int Sum
        {
            get;
            set;
        }
        public Cheque(int date, int numberOfGoods, int sum) : base(date, numberOfGoods)
        {
            Sum = sum;
        }
        public bool SignADoc()
        {
            Console.WriteLine("Подписан чек");
            return !Signed;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Переопределенный метод showinfo\nСумма: {Sum}");
        }
        public override string ToString()
        {
            return $"Класс Cheque";
        }
    }
}
