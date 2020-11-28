using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Speech.Recognition;

//using Microsoft.Speech.Recognition;

namespace TrainApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Chat.xaml
    /// </summary>
    public partial class Chat : Page
    {

        //Нужно исправить создание новых объектов классов ( использование конструкторов )


        TextBlock textLabel;
        TextBlock DateLabel;
        TextBlock AuthorLabel;
        Border userAvatar;
        private SpeechRecognitionEngine sre_def;

        public Chat()
        {
            InitializeComponent();
           
        }

     

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence > 0.7)
            {

                tb_chat.Text += e.Result.Text + " ";
                //MessageBox.Show(e.Result.Text);
            }
            
        }

        private SpeechRecognitionEngine Recognition()
        {
            tb_chat.Text = " ";
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-ru");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
            Choices numbers = new Choices();
            // numbers.Add(new string[] { "приказ номер пять", "выполнен в девять ", "часов " });
            numbers.Add(new string[] { "приказ ", "приказу ", "приказы ","приказа "});
            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = ci;
            gb.Append(numbers);
            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);
            sre.RecognizeAsync(RecognizeMode.Multiple);
            return sre;
        }

        void StopMet (SpeechRecognitionEngine sre)
        {
            sre.Dispose();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            textLabel = new TextBlock();
            DateLabel= new TextBlock();
            AuthorLabel = new TextBlock();
            userAvatar = new Border();

            //Затычка, нужно из БД

            AuthorLabel.Text = "Виталий";  

            //Настройка тени

            DropShadowEffect textShadow = new DropShadowEffect();
            textShadow.BlurRadius = 1;
            textShadow.ShadowDepth = 3;
            textShadow.Opacity = 0.5;
            textShadow.Color = Colors.White;

            userAvatar.Height = 100;
            userAvatar.Width = 100;
            userAvatar.HorizontalAlignment = HorizontalAlignment.Left;
            userAvatar.CornerRadius = new CornerRadius(100);
            userAvatar.Margin = new Thickness(50, 0, 0, 0);


            Grid message = new Grid();


            message.ColumnDefinitions.Add(new ColumnDefinition());
            message.ColumnDefinitions.Add(new ColumnDefinition());
            message.ColumnDefinitions.Add(new ColumnDefinition());

            message.RowDefinitions.Add(new RowDefinition());
            message.RowDefinitions.Add(new RowDefinition());
            message.RowDefinitions.Add(new RowDefinition());
            message.Height = 200;

            //Grid info = new Grid();
            //info.ColumnDefinitions.Add(new ColumnDefinition());
            //info.ColumnDefinitions.Add(new ColumnDefinition());
            //info.Background = new SolidColorBrush(Colors.Red);

            Grid.SetColumn(userAvatar, 0);
            Grid.SetRowSpan(userAvatar, 3);

            Grid.SetColumn(textLabel, 1);
            Grid.SetColumnSpan(textLabel, 2);
            Grid.SetRow(textLabel, 1);

            Grid.SetColumn(DateLabel, 2);
            Grid.SetRow(DateLabel, 0);

            Grid.SetColumn(AuthorLabel, 1);
            Grid.SetRow(AuthorLabel, 0);


            message.Children.Add(userAvatar);
            message.Children.Add(textLabel);
            message.Children.Add(DateLabel);
            message.Children.Add(AuthorLabel);

            var filename = @"Assets\userChat.png";
            ImageBrush imageAvatar = new ImageBrush();
            imageAvatar.ImageSource = new BitmapImage(new Uri(filename, UriKind.Relative));   //
            userAvatar.Background = Brushes.AliceBlue;
            {
                textLabel.Text = tb_chat.Text;
                textLabel.TextWrapping = TextWrapping.Wrap;
                textLabel.VerticalAlignment = VerticalAlignment.Center;
                DateLabel.Effect = textShadow;
                AuthorLabel.Effect = textShadow;
                AuthorLabel.VerticalAlignment = VerticalAlignment.Bottom;
                DateLabel.VerticalAlignment = VerticalAlignment.Bottom;
                DateLabel.Text = DateTime.Now.ToString();
            }
            StackPanel1.Children.Add(message);
            tb_chat.Text = null;
            //sre_def = Recognition();



            if (sre_def!=null)
                StopMet(sre_def);

            tb_chat.Text = " ";
            //Love Ne


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sre_def=Recognition();
        }
       
    }
}
