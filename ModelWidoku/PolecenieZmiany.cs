using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EgzaminMAUI_2.ModelWidoku
{
    internal class PolecenieZmiany : ICommand
    {
        private TextMW textMW;

        //Konstruktor 
        public PolecenieZmiany(TextMW text)
        {
            this.textMW = text;
            textMW.PropertyChanged += textMW_PropertyChanged;
        }

        private void textMW_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }


        //Elementy z interfejsu ICommand
        public event EventHandler CanExecuteChanged; //Zdarzenie CanExecuteChanged

        public bool CanExecute(object parameter)     //Metoda CanExecute
        {
            return true;
        }

        public void Execute(object parameter)        //Metoda Execute
        {
            textMW.EdTextMW = "Uniwersytet Mikołaja Kopernika";
        }
    }
}
