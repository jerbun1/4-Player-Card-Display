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
using System.Windows.Shapes;

namespace Tutorial7and8v1
{
    /// <summary>
    /// Interaction logic for OrganizedCards.xaml
    /// </summary>
    public partial class OrganizedCards : Window
    {
        public OrganizedCards()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the GetCards Method that takes 13 cards 
        /// from the deck and display it in the user hand
        /// </summary>
             //Method to get the cards from the deck
        private void bGetCards_Click(object sender, RoutedEventArgs e)
        {

            //Creates new deck objects
            var deck = new Deck();
            //shuffles the deck 
            deck.Shuffle();



            //List of cards for the 4 players
            List<Card> playerHand = deck.Sort(deck.TakeCards(13));
            List<Card> player2Hand = deck.Sort(deck.TakeCards(13));
            List<Card> player3Hand = deck.Sort(deck.TakeCards(13));
            List<Card> player4Hand = deck.Sort(deck.TakeCards(13));
            
            //Loops to make sure each player gets a different card from the deck 
            foreach (Card card in playerHand)
            {
                card.cardImage = card.GetCardImagePath(card.cardSuit, card.cardNumber, false);

            }

            foreach (Card card in player2Hand)
            {
                card.cardImage = card.GetCardImagePath(card.cardSuit, card.cardNumber, false);

            }

            foreach (Card card in player3Hand)
            {
                card.cardImage = card.GetCardImagePath(card.cardSuit, card.cardNumber, false);

            }

            foreach (Card card in player4Hand)
            {
                card.cardImage = card.GetCardImagePath(card.cardSuit, card.cardNumber, false);

            }
            //Hand for the first player
            card1.Source = playerHand[0].cardImage;
            card2.Source = playerHand[1].cardImage;
            card3.Source = playerHand[2].cardImage;
            card4.Source = playerHand[3].cardImage;
            card5.Source = playerHand[4].cardImage;
            card6.Source = playerHand[5].cardImage;
            card7.Source = playerHand[6].cardImage;
            card8.Source = playerHand[7].cardImage;
            card9.Source = playerHand[8].cardImage;
            card10.Source = playerHand[9].cardImage;
            card11.Source = playerHand[10].cardImage;
            card12.Source = playerHand[11].cardImage;
            card13.Source = playerHand[12].cardImage;

            //Hand for the second player
            player2card1.Source = player2Hand[0].cardImage;
            player2card2.Source = player2Hand[1].cardImage;
            player2card3.Source = player2Hand[2].cardImage;
            player2card4.Source = player2Hand[3].cardImage;
            player2card5.Source = player2Hand[4].cardImage;
            player2card6.Source = player2Hand[5].cardImage;
            player2card7.Source = player2Hand[6].cardImage;
            player2card8.Source = player2Hand[7].cardImage;
            player2card9.Source = player2Hand[8].cardImage;
            player2card10.Source = player2Hand[9].cardImage;
            player2card11.Source = player2Hand[10].cardImage;
            player2card12.Source = player2Hand[11].cardImage;
            player2card13.Source = player2Hand[12].cardImage;

            //Hand for the third player
            player3card1.Source = player3Hand[0].cardImage;
            player3card2.Source = player3Hand[1].cardImage;
            player3card3.Source = player3Hand[2].cardImage;
            player3card4.Source = player3Hand[3].cardImage;
            player3card5.Source = player3Hand[4].cardImage;
            player3card6.Source = player3Hand[5].cardImage;
            player3card7.Source = player3Hand[6].cardImage;
            player3card8.Source = player3Hand[7].cardImage;
            player3card9.Source = player3Hand[8].cardImage;
            player3card10.Source = player3Hand[9].cardImage;
            player3card11.Source = player3Hand[10].cardImage;
            player3card12.Source = player3Hand[11].cardImage;
            player3card13.Source = player3Hand[12].cardImage;

            //Hand for the fourth player
            player4card1.Source = player4Hand[0].cardImage;
            player4card2.Source = player4Hand[1].cardImage;
            player4card3.Source = player4Hand[2].cardImage;
            player4card4.Source = player4Hand[3].cardImage;
            player4card5.Source = player4Hand[4].cardImage;
            player4card6.Source = player4Hand[5].cardImage;
            player4card7.Source = player4Hand[6].cardImage;
            player4card8.Source = player4Hand[7].cardImage;
            player4card9.Source = player4Hand[8].cardImage;
            player4card10.Source = player4Hand[9].cardImage;
            player4card11.Source = player4Hand[10].cardImage;
            player4card12.Source = player4Hand[11].cardImage;
            player4card13.Source = player4Hand[12].cardImage;




        }

        //Method to place the card in the right spot for first player 
        private void imgPlayer1Played_Drop(object sender, DragEventArgs e)
        {

            Image img = e.Source as Image;
            img.Source = (BitmapSource)e.Data.GetData(DataFormats.Text);
        }

        

        //Method to place the card in the right spot for second player 
        private void imgPlayer2Played_Drop(object sender, DragEventArgs e)
        {

            Image img = e.Source as Image;
            img.Source = (BitmapSource)e.Data.GetData(DataFormats.Text);
        }

        //Method to place the card in the right spot for thrid player 
        private void imgPlayer3Played_Drop(object sender, DragEventArgs e)
        {

            Image img = e.Source as Image;
            img.Source = (BitmapSource)e.Data.GetData(DataFormats.Text);
        }

        //Method to place the card in the right spot for fourth player 
        private void imgPlayer4Played_Drop(object sender, DragEventArgs e)
        {

            Image img = e.Source as Image;
            img.Source = (BitmapSource)e.Data.GetData(DataFormats.Text);
        }

        //Methods to click down on the cards
        private void card1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card1.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }


        private void card3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }

        private void card13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = e.Source as Image;
            DataObject data = new DataObject(DataFormats.Text, img.Source);

            DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            card2.Source = Helper.GetImage("./Resources/cards/blankplayingcard.png");

        }





    }
}
