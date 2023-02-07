using static System.Net.Mime.MediaTypeNames;

namespace EgzaminMAUI_2;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void Ed1_TextChanged(object sender, TextChangedEventArgs e)
    {
        string edText = Ed1.Text;

        Lbl1.Text = edText;

        int lenght = edText.Length;
        Lbl2.Text = lenght.ToString();

        int vowels = edText.Count(c => "aąeęioóuy".Contains(c));
        Lbl3.Text = vowels.ToString();

        Color lblColor = Color.FromRgb(0, 0, 0);

        if (lenght > 30)
        {
            lblColor = Color.FromRgb(255, 0, 0);
        }

        Lbl1.TextColor = lblColor;
        Lbl2.TextColor = lblColor;
        Lbl3.TextColor = lblColor;
    }

    private void btn_Clicked(object sender, EventArgs e)
    {
        Ed1.Text = "Uniwersytet Mikołaja Kopernika";
    }
}

