using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                OnPropertyChanged(nameof(edTextMW));
            }
        }

        public int LengthMW
        {
            get => model.Length;
            set
            {
                model.Length = value;
                OnPropertyChanged(nameof(LenghtMW));
            }
        }

        public int VowelsMW
        {
            get => model.Vowels;
            set
            {
                model.Vowels = value;
                OnPropertyChanged(nameof(VowelsMW));
            }
        }


    }
}
