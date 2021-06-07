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

namespace Tutorial7and8v1
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

        private void bGetCards_Click(object sender, RoutedEventArgs e)
        {
            var deck = new Deck();

            deck.Shuffle();

            List<Card> playerHand = deck.Sort(deck.TakeCards(13));

            foreach (Card playcard in playerHand)
            {
                playcard.cardImage = playcard.GetCardImagePath(playcard.cardSuit, playcard.cardNumber, false);
            }

            card1.Source = playerHand[0].cardImage;
            card2.Source = playerHand[0].cardImage;
            card3.Source = playerHand[0].cardImage;
            card4.Source = playerHand[0].cardImage;
            card5.Source = playerHand[0].cardImage;
            card6.Source = playerHand[0].cardImage;
            card7.Source = playerHand[0].cardImage;
            card8.Source = playerHand[0].cardImage;
            card9.Source = playerHand[0].cardImage;
            card10.Source = playerHand[0].cardImage;
            card11.Source = playerHand[0].cardImage;
            card12.Source = playerHand[0].cardImage;
            card13.Source = playerHand[0].cardImage;
        }

        private void bNewWindow_Click(object sender, RoutedEventArgs e)
        {

            OrganizedCards objOrganizedCards = new OrganizedCards();

            this.Close();
            objOrganizedCards.Show();

        }

    }
}
