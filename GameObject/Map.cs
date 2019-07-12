using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShips.GameObject
{
    class Map
    {
        int[] ShipsSetCounter = { 4, 3, 2, 1 };
        public int ShipsCount = 0;
        public int[,] PlayedIntMap = new int[12, 12]; // Интовая мапа
        public Block[] Ships = new Block[10]; // Список кораблей

        public Map()
        {
            for(int i=0; i < 12; i++)
            {
                for(int j=0; j < 12; j++)
                {
                    PlayedIntMap[i, j] = 0;
                }
            }
        }

        public void SetShip(int x, int y, string orientation, int len)
        {
            int[,] thisShip = new int[4, 2];
            switch (orientation)
            {
                case "left":
                    for (int i = 0; i < len; i++)
                    {
                        if (ShipCheck(x, y - i, len) == true)
                        {
                            thisShip[i, 0] = x;
                            thisShip[i, 1] = y - i;
                        }
                        else
                        {
                            thisShip = new int[4, 2];
                            break;
                        }
                    }
                    break;

                case "right":
                    for (int i = 0; i < len; i++)
                    {
                        if (ShipCheck(x, y + i, len) == true)
                        {
                            thisShip[i, 0] = x;
                            thisShip[i, 1] = y + i;
                        }
                        else
                        {
                            thisShip = new int[4, 2];
                            break;
                        }
                    }
                    break;

                case "bottom":
                    for (int i = 0; i < len; i++)
                    {
                        if (ShipCheck(x + i, y, len) == true)
                        {
                            thisShip[i, 0] = x + i;
                            thisShip[i, 1] = y;
                        }
                        else
                        {
                            thisShip = new int[4, 2];
                            break;
                        }
                    }
                    break;

                case "top":
                    for (int i = 0; i < len; i++)
                    {
                        if (ShipCheck(x - i, y, len) == true)
                        {
                            thisShip[i, 0] = x - i;
                            thisShip[i, 1] = y;
                        }
                        else
                        {
                            thisShip = new int[4, 2];
                            break;
                        }
                        //PlayedMap[x - i, y] = new Block(status: "Ship");
                        //PlayedIntMap[x - i, y] = 1;
                    }
                    break;
            }
            ShipSetter(thisShip, len);
        }

        public int ShipsRead()
        {
            int result = 0;
            for(int i=1; i<=10; i++)
            {
                for(int j=1; j<=10; j++)
                {
                    if (PlayedIntMap[i, j] == 1)
                    {

                        result += 1;
                    }
                }
            }
        }

        /* Метод - установщик кораблей */
        private void ShipSetter(int[,] list, int len)
        {
            ShipsCount += 1;
            ShipsSetCounter[len - 1] -= 1;

            for (int i = 0; i < len; i++)
            {
                PlayedIntMap[list[i, 0], list[i, 1]] = 1;
            }
        }

        /* Вернёт true если туда МОЖНО установить корабль
         * false если нельзя*/
        private bool ShipCheck(int x, int y, int len)
        {
            if (
                GameReferee.PlayerReadyCheck() == true ||
                ShipsSetCounter[len - 1] <= 0 ||
                PlayedIntMap[x + 1, y] != 0 ||
                PlayedIntMap[x - 1, y] != 0 ||
                PlayedIntMap[x - 1, y - 1] != 0 ||
                PlayedIntMap[x - 1, y + 1] != 0 ||
                PlayedIntMap[x, y - 1] != 0 ||
                PlayedIntMap[x, y + 1] != 0 ||
                PlayedIntMap[x + 1, y + 1] != 0 ||
                PlayedIntMap[x + 1, y - 1] != 0 ||
                PlayedIntMap[x, y] != 0)
            {
                return false;
            }
            return true;
        }
    }
}
