using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShips.GameObject
{
    class Block
    {
        public string Status { get; set; }
        /* Attacked атакованная область,
         * Clear пустая область,
         * DamagedShip попадание в корабль,
         * Ship клетка корабля,
         * Closed место запрещённое для установки кораблей*/
         public Block(int x=0, int y=0, string status="Clear")
        {
            Status = status;
        }
    }
}
