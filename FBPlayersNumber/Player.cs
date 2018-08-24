using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBPlayersNumber
{

    public class Player
    {
        Dictionary<int, string> types = new Dictionary<int, string>()
    {
        {1,"Volkan Demirel"},
        {2,"Kayitli Oyuncu yok"},
        {3,"Hasan Ali Kaldirim"},
        {4,"Mauricio Isla"},
        {5,"Mehmet Topal"},
        {6,"Ismail Koybasi"},
        {7,"Alper Potuk"},
        {8,"Ozan Tufan"},
        {9,"Roberto Soldado"},
        {10,"Kayitli Oyuncu yok"},
        {11,"Mehmet Ekici"},
        {12,"Sanli Fenerbahce Taraftari"},
        {13,"Carlos Kameni"},
        {14,"Kayitli Oyuncu yok"},
        {15,"Uygar Mert Zeybek"},
        {16,"Ferdi Kadıoğlu"},
        {17,"Nabil Dirar"},
        {18,"Carlos Kameni"},
        {19,"Sener Ozbayrakli"},
        {20,"Andre Ayew"},
        {21,"Kayitli Oyuncu yok"},
        {22,"Michael Frey"},
        {23,"Kayitli Oyuncu yok"},
        {24,"Barış Alıcı"},
        {25,"Berke Özer"},
        {26,"Kayitli Oyuncu yok"},
        {27,"Kayitli Oyuncu yok"},
        {28,"Mathieu Valbuena"},
        {29,"Kayitli Oyuncu yok"},
        {30,"Kayitli Oyuncu yok"},
        {31,"Islam Slimani"},
        {32,"Kayitli Oyuncu yok"},
        {33,"Roman Neustadter"},
        {34,"Kayitli Oyuncu yok"},
        {35,"Kayitli Oyuncu yok"},
        {36,"Kayitli Oyuncu yok"},
        {37,"Martin Skrtel"},
        {38,"Kayitli Oyuncu yok"},
        {39,"Kayitli Oyuncu yok"},
        {40,"Kayitli Oyuncu yok"},
        {41,"Kayitli Oyuncu yok"},
        {42,"Kayitli Oyuncu yok"},
        {43,"Kayitli Oyuncu yok"},
        {44,"Kayitli Oyuncu yok"},
        {45,"Kayitli Oyuncu yok"},
        {46,"Kayitli Oyuncu yok"},
        {47,"Kayitli Oyuncu yok"},
        {48,"Kayitli Oyuncu yok"},
        {49,"Kayitli Oyuncu yok"},
        {50,"Kayitli Oyuncu yok"},
        {51,"Kayitli Oyuncu yok"},
        {52,"Kayitli Oyuncu yok"},
        {53,"Yigithan Guveli"},
        {54,"Erten Ersu"},
        {55,"Kayitli Oyuncu yok"},
        {56,"Kayitli Oyuncu yok"},
        {57,"Kayitli Oyuncu yok"},
        {58,"Kayitli Oyuncu yok"},
        {59,"Kayitli Oyuncu yok"},
        {60,"Samed Karakoc"},
        {61,"Kayitli Oyuncu yok"},
        {62,"Kayitli Oyuncu yok"},
        {63,"Kayitli Oyuncu yok"},
        {64,"Kayitli Oyuncu yok"},
        {65,"Kayitli Oyuncu yok"},
        {66,"Kayitli Oyuncu yok"},
        {67,"Kayitli Oyuncu yok"},
        {68,"Serhat Kot"},
        {69,"Kayitli Oyuncu yok"},
        {70,"Kayitli Oyuncu yok"},
        {71,"Kayitli Oyuncu yok"},
        {72,"Kayitli Oyuncu yok"},
        {73,"Kayitli Oyuncu yok"},
        {74,"Kayitli Oyuncu yok"},
        {75,"Kayitli Oyuncu yok"},
        {76,"Kayitli Oyuncu yok"},
        {77,"Kayitli Oyuncu yok"},
        {78,"Kayitli Oyuncu yok"},
        {79,"Kayitli Oyuncu yok"},
        {80,"Kayitli Oyuncu yok"},
        {81,"Kayitli Oyuncu yok"},
        {82,"Kayitli Oyuncu yok"},
        {83,"Kayitli Oyuncu yok"},
        {84,"Kayitli Oyuncu yok"},
        {85,"Kayitli Oyuncu yok"},
        {86,"Kayitli Oyuncu yok"},
        {87,"Kayitli Oyuncu yok"},
        {88,"Kayitli Oyuncu yok"},
        {89,"Kayitli Oyuncu yok"},
        {90,"Kayitli Oyuncu yok"},
        {91,"Kayitli Oyuncu yok"},
        {92,"Aatif Chahechouhe"},
        {93,"Kayitli Oyuncu yok"},
        {94,"Kayitli Oyuncu yok"},
        {95,"Kayitli Oyuncu yok"},
        {96,"Kayitli Oyuncu yok"},
        {97,"Kayitli Oyuncu yok"},
        {98,"Kayitli Oyuncu yok"},
        {99,"Eljif Elmas"}
    };

        public string getPlayerName(int pNumber)
        {
            string PlayerName = types.FirstOrDefault(x => x.Key == pNumber).Value;
            return PlayerName;
        }

        public int getPlayerNumber(string cName)
        {
            int pNumber = types.FirstOrDefault(x => x.Value.ToLower() == cName.ToLower()).Key;

            return pNumber;
        }

    }

}
