using UnityEngine.UI;
using Matchvs;
namespace UnknownRealm.Lobby { 
public class StartMatch :MyBehaviour
{
       private bool matching = false;
      // public Text label;
        private float counter = 0;
    public void onClick()
    {
            log("Clicked");
            if (!matching) {
                this.GetComponentInChildren<Text>().text = "开始匹配";
                matching = true;
                log("start match");
                getEngine().joinRandomRoom(4);
                return;
            }

            matching = false;
            this.GetComponentInChildren<Text>().text = "停止匹配";
            log("stop match");
            getEngine().leaveRoom();
         
            
    }
        private void FixedUpdate()
        {
            if (matching)
            {
                
            }
        
        }
    }
}