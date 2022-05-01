using System.Windows;
using System.Windows.Controls;
using System.Net;
using System.IO;
using System;

namespace Neirogoroscop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }
        static string sourceResponce = " ";

        static string GetInfo() 
        {
            string fullUri = "https://api.vk.com/method/wall.get?owner_id=-193489972&domain=neural_horo&offset=1&count=1&filter=owner&access_token=17e4a27817e4a27817e4a278501798ecf4117e417e4a2787580b4e4cac4860d5413f8f1&v=5.131"; // <- ссылка
    
            WebRequest request = WebRequest.Create(fullUri);

            using (WebResponse response = request.GetResponse())
            {

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    sourceResponce = reader.ReadToEnd();

                    reader.Close();
                }
                response.Close();
            }
            return sourceResponce;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetInfo();
            string Oven = "Овен";
            int indexOfOven = sourceResponce.IndexOf(Oven);
            string Telez = "Телец";
            int indexOfTelez = sourceResponce.IndexOf(Telez);
            string ForOven = sourceResponce.Substring(indexOfOven, indexOfTelez - indexOfOven - 6);

            string Blizneci = "Близнецы";
            int indexOfBlizneci = sourceResponce.IndexOf(Blizneci);
            string ForTelez = sourceResponce.Substring(indexOfTelez, indexOfBlizneci - indexOfTelez - 6);

            string Rak = "Рак";
            int indexOfRak = sourceResponce.IndexOf(Rak);
            string ForBlizneci = sourceResponce.Substring(indexOfBlizneci, indexOfRak - indexOfBlizneci - 6);

            string Lev = "Лев";
            int indexOfLev = sourceResponce.IndexOf(Lev);
            string ForRak = sourceResponce.Substring(indexOfRak, indexOfLev - indexOfRak - 6);

            string Deva = "Дева";
            int indexOfDeva = sourceResponce.IndexOf(Deva);
            string ForLev = sourceResponce.Substring(indexOfLev, indexOfDeva - indexOfLev - 6);

            string Vesi = "Весы";
            int indexOfVesi = sourceResponce.IndexOf(Vesi);
            string ForDeva = sourceResponce.Substring(indexOfDeva, indexOfVesi - indexOfDeva - 6);

            string Scorpion = "Скорпион";
            int indexOfScorpion = sourceResponce.IndexOf(Scorpion);
            string ForVesi = sourceResponce.Substring(indexOfVesi, indexOfScorpion - indexOfVesi - 6);
            
            string Strelec = "Стрелец";
            int indexOfStrelec = sourceResponce.IndexOf(Strelec);
            string ForScorpion = sourceResponce.Substring(indexOfScorpion, indexOfStrelec - indexOfScorpion - 6);


            string Kozerog = "Козерог";
            int indexOfKozerog = sourceResponce.IndexOf(Kozerog);
            string ForStrelec = sourceResponce.Substring(indexOfStrelec, indexOfKozerog - indexOfStrelec - 6);
      
            string Vodoley = "Водолей";
            int indexOfVodoley = sourceResponce.IndexOf(Vodoley);
            string ForKozerog = sourceResponce.Substring(indexOfKozerog, indexOfVodoley - indexOfKozerog - 6);

            string Ribi = "Рыбы";
            int indexOfRibi = sourceResponce.IndexOf(Ribi);
            string ForVodoley = sourceResponce.Substring(indexOfVodoley, indexOfRibi - indexOfVodoley - 6);

            string TheEnd = "post_source";
            int indexOfTheEnd = sourceResponce.IndexOf(TheEnd);
            string ForRibi = sourceResponce.Substring(indexOfRibi, indexOfTheEnd - indexOfRibi - 3);

            outputTextbox.Text = ForOven + "\n" + " " + "\n" + ForTelez + "\n" + " " + "\n" + ForBlizneci + "\n" + " " + "\n" + ForRak + "\n" + " " + "\n" + ForLev + "\n" + " " + "\n" + ForDeva + "\n" + " " + "\n" + ForVesi + "\n" + " " + "\n" + ForScorpion + "\n" + " " + "\n" + ForStrelec + "\n" + " " + "\n" + ForVodoley + "\n" + " " + "\n" + ForRibi;
        }
       
        private void OvenButton_Click(object sender, RoutedEventArgs e)
        {
            GetInfo();
            string Oven = "Овен";
            int indexOfOven = sourceResponce.IndexOf(Oven);
            string Telez = "Телец";
            int indexOfTelez = sourceResponce.IndexOf(Telez);
            string ForOven = sourceResponce.Substring(indexOfOven, indexOfTelez - indexOfOven -6);
            outputTextbox.Text = ForOven;
        }

        private void TelezButton_Click(object sender, RoutedEventArgs e)
        {
            GetInfo();
            string Telez = "Телец";
            int indexOfTelez = sourceResponce.IndexOf(Telez);
            string Blizneci = "Близнецы";
            int indexOfBlizneci = sourceResponce.IndexOf(Blizneci);
            string ForTelez = sourceResponce.Substring(indexOfTelez, indexOfBlizneci - indexOfTelez - 6);
            outputTextbox.Text = ForTelez;
        }
        private void BlizneziButton_Click(object sender, RoutedEventArgs e)
        {
            string Blizneci = "Близнецы";
            int indexOfBlizneci = sourceResponce.IndexOf(Blizneci);
            string Rak = "Рак";
            int indexOfRak = sourceResponce.IndexOf(Rak);
            string ForBlizneci = sourceResponce.Substring(indexOfBlizneci, indexOfRak - indexOfBlizneci - 6);
            outputTextbox.Text = ForBlizneci;
        }
        private void RakButton_Click(object sender, RoutedEventArgs e)
        {
            string Rak = "Рак";
            int indexOfRak = sourceResponce.IndexOf(Rak);
            string Lev = "Лев";
            int indexOfLev = sourceResponce.IndexOf(Lev);
            string ForRak = sourceResponce.Substring(indexOfRak, indexOfLev - indexOfRak - 6);
            outputTextbox.Text = ForRak;
        }
        private void LevButton_Click(object sender, RoutedEventArgs e)
        {
            string Lev = "Лев";
            int indexOfLev = sourceResponce.IndexOf(Lev);
            string Deva = "Дева";
            int indexOfDeva = sourceResponce.IndexOf(Deva);
            string ForLev = sourceResponce.Substring(indexOfLev, indexOfDeva - indexOfLev - 6);
            outputTextbox.Text = ForLev;
        }
        private void DevaButton_Click(object sender, RoutedEventArgs e)
        {
            string Deva = "Дева";
            int indexOfDeva = sourceResponce.IndexOf(Deva);
            string Vesi = "Весы";
            int indexOfVesi = sourceResponce.IndexOf(Vesi);
            string ForDeva = sourceResponce.Substring(indexOfDeva, indexOfVesi - indexOfDeva - 6);
            outputTextbox.Text = ForDeva;
        }
        private void VesiButton_Click(object sender, RoutedEventArgs e)
        {
            string Vesi = "Весы";
            int indexOfVesi = sourceResponce.IndexOf(Vesi);
            string Scorpion = "Скорпион";
            int indexOfScorpion = sourceResponce.IndexOf(Scorpion);
            string ForVesi = sourceResponce.Substring(indexOfVesi, indexOfScorpion - indexOfVesi - 6);
            outputTextbox.Text = ForVesi;
        }

        private void ScorpionButton_Click(object sender, RoutedEventArgs e)
        {
            string Scorpion = "Скорпион";
            int indexOfScorpion = sourceResponce.IndexOf(Scorpion);
            string Strelec = "Стрелец";
            int indexOfStrelec = sourceResponce.IndexOf(Strelec);
            string ForScorpion = sourceResponce.Substring(indexOfScorpion, indexOfStrelec - indexOfScorpion - 6);
            outputTextbox.Text = ForScorpion;
        }

        private void StrelecButton_Click(object sender, RoutedEventArgs e)
        {
            string Strelec = "Стрелец";
            int indexOfStrelec = sourceResponce.IndexOf(Strelec);
            string Kozerog = "Козерог";
            int indexOfKozerog = sourceResponce.IndexOf(Kozerog);
            string ForStrelec = sourceResponce.Substring(indexOfStrelec, indexOfKozerog - indexOfStrelec - 6);
            outputTextbox.Text = ForStrelec;  
        }

        private void KozerogButton_Click(object sender, RoutedEventArgs e)
        {
            string Kozerog = "Козерог";
            int indexOfKozerog = sourceResponce.IndexOf(Kozerog);
            string Vodoley = "Водолей";
            int indexOfVodoley = sourceResponce.IndexOf(Vodoley);
            string ForKozerog = sourceResponce.Substring(indexOfKozerog, indexOfVodoley - indexOfKozerog - 6);
            outputTextbox.Text = ForKozerog;
        }

        private void VodoleyButton_Click(object sender, RoutedEventArgs e)
        {
            string Vodoley = "Водолей";
            int indexOfVodoley = sourceResponce.IndexOf(Vodoley);
            string Ribi = "Рыбы";
            int indexOfRibi = sourceResponce.IndexOf(Ribi);
            string ForVodoley = sourceResponce.Substring(indexOfVodoley, indexOfRibi - indexOfVodoley - 6);
            outputTextbox.Text = ForVodoley;
        }

        private void RibiButton_Click(object sender, RoutedEventArgs e)
        {
            string Ribi = "Рыбы";
            int indexOfRibi = sourceResponce.IndexOf(Ribi);
            string TheEnd = "post_source";
            int indexOfTheEnd = sourceResponce.IndexOf(TheEnd);
            string ForRibi = sourceResponce.Substring(indexOfRibi, indexOfTheEnd - indexOfRibi - 3);
            outputTextbox.Text = ForRibi;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window1 = new Window1();
            window1.Show();
        }
    }
}