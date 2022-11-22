using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Gamer
    {
        public List<int> gamercards = new List<int>();                        //oyuncunun kart listesi

        public int pisticounter = 0;

        static public List<Gamer> Gamers = new List<Gamer>();                 //oyuncu listesi

        public readonly int id;                                              //oyuncu id'si         

        public List<int> gains=new List<int>();

        public Gamer()
        {
            Gamer.Gamers.Add(this);                                           //oyuncu nesnelerini otamatik listeye atıyor
            id = Gamer.Gamers.Count - 1;                                      //id ataması

        }

        static public void GamerCrete(int number)                       //parametre sayısına göre oyuncu nesnesi oluşturuyor
        {
            for (int i = 0; i < number; i++)
            {
                Gamer gamer = new Gamer();

            }

        }
        public void Gaming()
        {

            int endcard = Gamer.Gamers[3].gamercards[Gamer.Gamers[3].gamercards.Count-1];   //yerdeki kart

            if (this.gamercards.Contains(endcard))                  //yerdeki karta göre kart atılması yerdeki kartların alınması pişti kontrolü
            {
                if (Gamer.Gamers[3].gamercards.Count==1)
                {
                    this.pisticounter++;

                }
                this.gamercards.Remove(endcard);

                this.gains.Add(endcard);

                this.gains.AddRange(Gamer.Gamers[3].gamercards);

                Gamer.Gamers[3].gamercards.RemoveRange(0, Gamer.Gamers[3].gamercards.Count);
            }
            else
            {
                Random rand = new Random();                         //eşleşen kart yoksa rastagele kart atılması

                int a=rand.Next(0,this.gamercards.Count);

                this.gamercards.Remove(a);

                Gamer.Gamers[3].gamercards.Add(a);

            }
            
            



        }
        
        



    }
}
