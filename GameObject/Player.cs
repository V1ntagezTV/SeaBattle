using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShips.GameObject
{
    class Player
    {
        public Player(string nickname, string color)
        {
            GameReferee.PlayerCollection[GameReferee.PlayerCount] = this;
            GameReferee.PlayerCount += 1;
            this.nickname = nickname;
        }
        
        public bool Ready = false;
        public readonly string nickname;
        public Map map = new Map();

        public void PlayerAtack(Player enemy, int x, int y)
        {
            if (!GameReferee.PlayerTurn(this) && GameReferee.NextAttacking != null)
                throw new Exception("Now not YOU PIDR...");

            if (enemy.map.PlayedIntMap[x, y] == 1) 
            {
                enemy.map.PlayedIntMap[x, y] = 2;
            }
            else
            {
                enemy.map.PlayedIntMap[x, y] = 9;
            }
            GameReferee.NextAttacking = enemy;

        }
        public void SetStatus()
        {
            Ready = !Ready;
        }
    }
}
