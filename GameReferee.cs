using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarShips.GameObject;

namespace WarShips
{
    static class GameReferee
    {
        public static int PlayerCount = 0;
        public static Player[] PlayerCollection = new Player[10];
        public static Player NextAttacking;
        /*
         Вернёт true, если все готовы
         и false, если кто-то не готов
        */
        public static bool PlayerReadyCheck()
        {
            for(int i = 0; i < PlayerCount; i++)
            {
                if (PlayerCollection[i].Ready == false)
                    return false;
            }
            return true;
        }
        /* */
        public static bool PlayerTurn(Player player) => NextAttacking?.nickname == player.nickname;
    }
}
