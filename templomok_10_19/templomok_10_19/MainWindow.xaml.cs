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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace templomok_10_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] templeImages = { "Belapatfalva.jpg", "Jak.jpg", "Kaposszentjakab.jpg" ,"Lebeny.jpg", "Lonya.jpg", "Ocsa.jpg", "Pannonhalma.jpg", "Szeged.jpg", "Tarnaszentmaria.jpg", "Turje.jpg","Kecsketemplom.jpg" };
        private string[] templeInfo = { "Nagyboldog Asszony templom; 1253; Bélapátfalva", "Szent György templom; 1256; Ják", "Bencés Apátság; 1061; Kaposszentjakab", "Szent Jakab apostol plébániatemplom; 1208; Lébény", "Péter Pál református templom; 1250; Lónya", "Boldogságos Szűz Mária református templom; 1250; Ócsa", "Pannonhalmi Bencés Főapátság; 1350; Pannonhalma", "Szent Demeter templom; 1000; Szeged", "Mária látogatása templom; 1108; Tarnaszentmária", "Gyümolcsoltó Boldogasszony prépostsági templom; 1250; Türje", "Bencés templom vagy Nagyboldogasszony-templom; 1270; Sopron" };
        private int currentIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            ShowTemple(currentIndex);
        }
        private void ShowTemple(int index)
        {
            if (index >= 0 && index < templeImages.Length)
            {
                Uri uri = new Uri(templeImages[index], UriKind.Relative);
                templeImage.Source = new BitmapImage(uri);

                // Az adatok megjelenítése
                templeInfoTextBlock.Text = templeInfo[index];
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = (currentIndex + 1) % templeImages.Length;
            ShowTemple(currentIndex);
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = (currentIndex - 1 + templeImages.Length) % templeImages.Length;
            ShowTemple(currentIndex);
        }
    }
}
