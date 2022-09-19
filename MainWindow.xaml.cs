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

namespace PickACardUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            listOfCards.Items.Clear();
            foreach (string card in pickedCards)
            {
                listOfCards.Items.Add(card);
            }
        }
        class CardPicker
        {
            static Random random = new Random();

            public static string[] PickSomeCards(int numberOfCards)
            {
                string[] pickedCards = new string[numberOfCards];
                for (int i = 0; i < numberOfCards; i++)
                {
                    pickedCards[i] = RandomValue() + " " + RandomSuit();
                }
                return pickedCards;
            }

            private static string RandomValue()
            {
                int value = random.Next(1, 14);
                if (value == 1) return "As";
                if (value == 11) return "Walet";
                if (value == 12) return "Królowa";
                if (value == 13) return "Król";
                return value.ToString();
            }

            private static string RandomSuit()
            {
                int value = random.Next(1, 5);
                if (value == 1) return "Kier";
                if (value == 2) return "Serce";
                if (value == 3) return "Pik";
                return "Trefl";
            }
        }
    }
}
