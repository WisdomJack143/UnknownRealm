using UnityEngine.UI;
using Matchvs;
using UnityEngine;
namespace UnknownRealm.Lobby { 
public class StartMatch :MyBehaviour
{
       private bool matching = false;
      public Text label;
        private float counter = 0;

        private void Start()
        {

          //  getEngine().listen("", ((Roomrsp) => { }));
        }
        public void onClick()
    {
            
            if (matching) {
                this.GetComponentInChildren<Text>().text = "开始匹配";
                label.text = "没有匹配";
                matching = true;
                getEngine().leaveRoom(); 
                return;
            }

            matching = true;
            this.GetComponentInChildren<Text>().text = "停止匹配"; 
            getEngine().joinRandomRoom(4);
        
         
            
    }
        private void FixedUpdate()
        {
            if (matching)
            {
                counter = counter + Time.deltaTime;
                label.text = "匹配时间" + counter.ToString("0.0");
            }
        
        }
    }
}