// See https://aka.ms/new-console-template for more information



//Pişti Oyunu 

using CardGame;

Console.WriteLine("Hello, World!");

Gamer.GamerCrete(3);   //3 oyuncu oluturuluyor 2 oyuncu 1 yer

Cards.CardsDelivery();    //kart karılıyor


while (Cards.kartlar.Count == 0)    //karılan kartlar biterse oyun biter
{
    for(int i = 0; i < 3; i++)      //ilk kartların dağıtılması
    {
        Gamer.Gamers[i].gamercards.AddRange(Cards.FourCard());

    }
        
    for(int i = 0; i < 4; i++)      //raundun oynanması
    {
        for(int a=0; a < 1; a++)

        Gamer.Gamers[i].Gaming();



    }

}



