using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Cards
    {   
        public static int fourCardCounter=0;

        public static List<int> kartlar = new List<int>();
        public static void CardsDelivery()              //deste karılması
        {
            for (int f = 0; f < 52; f++)
            {
                kartlar.Add(f + 1);
            }

            Random random = new Random();     //kartlar karıştırlıyor

            var keyList = kartlar.OrderBy(item => random.Next()).Take(52).ToList();

            kartlar = keyList;

            
        }

        static public List<int> FourCard()   //karılan desteden 4 kart dağıtılması
        {
            fourCardCounter++;

            var fourcard = new List<int>();

            for (int i= 0; i<4; i++)
            {
                fourcard.Add(kartlar[i]);
            }

            kartlar.RemoveRange(0, 4);

            return fourcard;
        }



        }

    }

