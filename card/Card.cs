using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CMP1903M_A01_2223
{
    class Card
    {

        private int PValue=0;

        private int Psuit=0;



        public int Value { get {return PValue;} set{PValue=value;}}

        public int Suit { get{return Psuit;} set{Psuit=value;}}

        public static void Generate(List<Card> PackUp)
        {
            for (int SUIT =1; SUIT<=4; SUIT++)
            {
                for (int VAL=1; VAL<=13; VAL++)
                {
                    Card CardMint=new Card();
                    CardMint.Suit=SUIT;
                    CardMint.Value=VAL;
                    PackUp.Add(CardMint);

                }
            }
            
        }
        
    }
}
