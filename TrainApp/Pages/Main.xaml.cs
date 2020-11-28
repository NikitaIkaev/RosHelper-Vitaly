using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
//using Microsoft.Speech.Recognition;

namespace TrainApp.Pages
{
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
            //Page1_Shown();
        }

        //static TextBox Tx;
        //static TextBlock l;

        //static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //    if (e.Result.Confidence > 0.7) l.Text += e.Result.Text + " ";
        //}

        //private void Page1_Shown()
        //{
        //    l = label1;
        //    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-ru");
        //    SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);
        //    sre.SetInputToDefaultAudioDevice();
        //    sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
        //    Choices numbers = new Choices();
        //    numbers.Add(new string[] { "приказ номер пять ", "выполнен в девять ", "часов " });


        //    GrammarBuilder gb = new GrammarBuilder();
        //    gb.Culture = ci;
        //    gb.Append(numbers);


        //    Grammar g = new Grammar(gb);
        //    sre.LoadGrammar(g);

        //    sre.RecognizeAsync(RecognizeMode.Multiple);
        //}

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    textBox1.Text = l.Text;
        //}
    }
}

