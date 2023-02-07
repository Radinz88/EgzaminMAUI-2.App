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
        private Model.TextModel model;

        public string edTextMW
        {
            get => model.EdText;
            set
            {
                model.EdText = value;
                onPropertyChanged(nameof(edTextMW));
            }
        }

        public int LengthMW
        {
            get => model.Length;
            set
            {
                model.Length = value;
                onPropertyChanged(nameof(LengthMW));
            }
        }

        public int VowelsMW
        {
            get => model.Vowels;
            set
            {
                model.Vowels = value;
                onPropertyChanged(nameof(VowelsMW));
            }
        }

        public Color LblColorMW
        {
            get
            {
                if (model.Length > 30)
                {
                    return Color.FromRgb(255, 0, 0);
                }
                else { return Color.FromRgb(0, 0, 0); }
            }
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
        private ICommand ZmianaNapisu;
        public ICommand ZmianaNapisu
        {
            get
            {
                //Zabezpieczenie przed powielaniem egzemplarzy klasy polecenia
                if (ZmianaNapisu != "Uniwersytet Mikołaja Kopernika")
                {
                    ZmianaNapisu = new PolecenieZmiany(this);
                }
                return ZmianaNapisu;
            }
        }

    }
}
