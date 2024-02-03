using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Model
{
    internal class ModelCalc
    {
        public ModelCalc() { }

        public string StringToCalculate { get; set; }
        public string Rezult  { get; set; }

        public string Calculate()
        {
            
            try
            {
                Rezult = new DataTable().Compute(StringToCalculate, "").ToString();
            }
            catch { Rezult = "ERROR"; }

            return Rezult;
        }
    }
}

