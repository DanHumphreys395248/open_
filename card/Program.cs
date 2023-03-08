using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CMP1903M_A01_2223
{
    class Test
    {
        static void Main(string[] args)
        {
            var Hand=new List<Card>{};
            var CardDeck=new List<Card>{};
            Card.Generate(CardDeck);

            Console.Write (CardDeck);
            //asks user for inputs
            Console.Write ("enter number of shuffle");
            var Input1= Console.ReadLine();
            //converts input to integar so it can be used by the method
            int ShuffleType = Convert.ToInt32(Input1);

            Pack.shuffleCardPack(ShuffleType,CardDeck);

            Console.Write ("dealing 1 card");

            Pack.DealOne(CardDeck,Hand);
            for (int g =0; g<=Hand.Count-1; g++)
            {
                Console.WriteLine(Hand[g]);
            }

            Console.Write("enter number of cards to be dealt");

            var Input2=Console.ReadLine();
            int cardnumber = Convert.ToInt32(Input2);


            Pack.DealMore(CardDeck,Hand,cardnumber);
            for (int h =0; h<=Hand.Count-1; h++)
            {
                Console.WriteLine(Hand[h]);
            }


        }
    }
}
