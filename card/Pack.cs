using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CMP1903M_A01_2223
{
    class Pack
    {


        public static void shuffleCardPack(int typeOfShuffle, List<Card> Deck)
        {
            //Shuffles the pack based on the type of shuffle defined by user
        
            int DeckSize = Deck.Count;
            
            if (typeOfShuffle==0){
                Console.WriteLine("Fisher yates shuffle selected");
                Random Rand=new Random();
                var NewDeck = new List<Card>{};
                for (int Z=1; Z<=Deck.Count; Z++)
                {
                    var RandomCard= Deck[Rand.Next(1,Deck.Count)];
                    NewDeck.Add(RandomCard);
                    Deck.Remove(RandomCard);
                }
                Deck.AddRange(NewDeck);

            }

            else if (typeOfShuffle==1){
                Console.WriteLine("riffle/faro shuffle selected");
                //lists to contain the cards when they are split

                var halfA=new List<Card>{};
                var halfB=new List<Card>{};

                int HalfWay=Deck.Count/2;

                //loop used to split Deck

                for (int A = 0; A <= Deck.Count-1; A++)
                {
                    //switches from adding to halfA over to halfB once the loop has reached half way through the list of cards
                    if (A==HalfWay)
                    {
                    halfB.Add (Deck[A]);
                    }   
                    else
                    {
                        halfA.Add (Deck[A]);
                    }
                }
                //clears the deck ready for cards to be re-added
                Deck.Clear();
                for (int B=0; B <=halfB.Count-1; B++)
                {
                    Deck.Add (halfA[B]);
                    Deck.Add (halfB[B]);
                    var RemoveItA=halfA[B];
                    var RemoveItB=halfB[B];
                    halfA.Remove(RemoveItA);
                    halfB.Remove(RemoveItB);
                }


            }
            else{
                Console.WriteLine("No shuffle selected");
            }

        }
        public static void DealOne(List<Card> Deck, List<Card> PlayerHand)
        {
            //Deals one card
            var Dealt=(Card) Deck[0];
            
            PlayerHand.Add (Dealt);
            Deck.Remove(Dealt);
        }
        public static void DealMore(List<Card> Deck, List<Card> PlayerHand,int amount)
        {
            for (int i = 1; i <= amount; i++)
            {
                var Dealt=(Card) Deck[0];
                PlayerHand.Add (Dealt);
                Deck.Remove(Dealt);
            }

        }
    }
}