using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnknownRealm.Match.BodyParts;
namespace UnknownRealm.Match
{
    //禁止在游戏准备前启用
    public class GameManager
    {
       private Dictionary<uint, RagDoll> ingameDolls;
        private GameStage stage;
       static GameManager instance;
        private GameManager() {
            ingameDolls = new Dictionary<uint, RagDoll>();
            instance = this;
            stage = GameStage.Ready;
        }

        public static GameManager getInstance()
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
}
