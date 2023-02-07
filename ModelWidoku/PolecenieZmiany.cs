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

        //Elementy z interfejsu ICommand
        public event EventHandler CanExecuteChanged; //Zdarzenie CanExecuteChanged

        public bool CanExecute(object parameter)     //Metoda CanExecute
        {
            return true;
        }

        public void Execute(object parameter)        //Metoda Execute
        {

        }

    }
}
