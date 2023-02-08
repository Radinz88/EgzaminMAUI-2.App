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
            { return edText; }
            set
            {
                edText = value;
                lenght = edText.Length;
                vowels = edText.Count(c => "aąeęioóuy".Contains(c));
                if (lenght > 30)
                {
                    lblColor = new Color(255, 0, 0);
                }
                else
                {
                    lblColor = new Color(0, 0, 0);
                }
            }
        }
        public int Length 
        { 
            get 
            {
                return lenght;
            }
        }
        public int Vowels 
        { 
            get { return vowels; } 
        }
        public Color LblColor 
        {
            get { return lblColor; } 
        }

        public TextModel(string edText)
        {
            this.EdText = edText;
        }
    }
}
