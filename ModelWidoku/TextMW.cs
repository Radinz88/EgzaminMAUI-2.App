using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EgzaminMAUI_2.ModelWidoku
{
    class TextMW : INotifyPropertyChanged
    {
        private Model.TextModel model = new("");

        public string EdTextMW
        {
            get => model.EdText;
            set
            {
                model.EdText = value;
                onPropertyChanged(nameof(EdTextMW));
                LengthMW = model.Length;
                VowelsMW = model.Vowels;
                LblColorMW= model.LblColor;
            }
        }

        public int LengthMW
        {
            get => model.Length;
            set
            {
                onPropertyChanged(nameof(LengthMW));
            }
        }

        public int VowelsMW
        {
            get => model.Vowels;
            set
            {
                onPropertyChanged(nameof(VowelsMW));
            }
        }

        public Color LblColorMW
        {
            get { return model.LblColor; }
            set
            {
                onPropertyChanged(nameof(LblColorMW));
            }
        }

        //Implementacja interfejsu INotifyPropretyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        //Własność pola ICommand 
        //Instancja polecenia 'ZmianaZapisu'
        private ICommand zmianaNapisu;
        public ICommand ZmianaNapisu
        {
            get
            {
                //Zabezpieczenie przed powielaniem egzemplarzy klasy polecenia
                if (zmianaNapisu != null)
                { 
                    return zmianaNapisu; 
                }
                else
                {
                    zmianaNapisu = new PolecenieZmiany(this);
                }
                return zmianaNapisu;
            }
        }

    }
}
