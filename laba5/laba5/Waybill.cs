using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Waybill : Document, IOrganization
    {
        public double Fine
        {
            get;
            set;
        }
        public Waybill(int date, int numberOfGoods, double fine ): base(date, numberOfGoods)
        {
            Fine = fine;
        }
        public bool SignADoc()
        {
            return Signed = true;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Переопределенный метод showinfo\nНалог: " + Fine);
        }
        public override string ToString()
        {
            return $"Класс Waybill";
        }
    }
}
