using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model;

namespace WpfApp1.ViewModelNS
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private ModelCalc calculator;
        public ViewModel()
        {
            calculator = new ModelCalc();
            RezultVM = "0";
            StringToCalculateVM = "";
        }

        public string StringToCalculateVM { get; set; }

      /*  public string StringToCalculateVM
        {
            get {

                //calculator.StringToCalculate = StringToCalculateVM;
                //return calculator.StringToCalculate;
            };
            set
            {
                //calculator.StringToCalculate = value;
                //OnPropertyChanged("StringToCalculateVM");
            };
        }*/

        public string RezultVM  
        {
            get 
            {
                calculator.StringToCalculate = StringToCalculateVM;
                return calculator.Calculate();
                
            }
            set
            {
                calculator.Rezult = value;
                OnPropertyChanged("RezultVM");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}
