using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminMAUI_2.Model
{
    public class TextModel
    {
        private string edText;
        private int lenght, vowels;
        private Color lblColor;

        public string EdText 
        { 
            get 
            { return EdText; } 
            set 
            { edText = value; } 
        }
        public int Length 
        { 
            get 
            {
                return lenght;
            }
            set 
            {
                lenght = edText.Length;
            }
        }
        public int Vowels 
        { 
            get { return vowels; } 
            set { vowels = edText.Count(c => "aąeęioóuy".Contains(c)); } 
        }
        public Color LblColor 
        {
            get { return lblColor; } 
            set 
            {
                if (lenght > 30)
                {
                    lblColor = Color.FromRgb(255, 0, 0);
                }
                else { lblColor = Color.FromRgb(0, 0, 0); }
            }
        }
    }
}
