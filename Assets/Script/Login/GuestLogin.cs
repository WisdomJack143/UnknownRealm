
using UnityEngine.SceneManagement;
using Matchvs;
namespace UnknownRealm.Login { 
public class GuestLogin :MyBehaviour
{

        private void Start()
        {
                    
        }
        void Update()
    {

    }
    public void onClick() {
            if (!hasAccount())
            {
                register();
            }
            else {

                login();
                loadLobby();
            }
         
    }
        private void loadLobby() {
            SceneManager.LoadScene("Lobby");
        }
        private bool hasAccount() {
            return getCfg().USER_ID != 0;
        }
        private void register()
        {
            getEngine().registerUser(user =>
            {
                getCfg().USER_ID = user.userid;
                getCfg().USER_TOKEN = user.token;
                getApp().saveConfig();
                log("Registered with" + getCfg().USER_ID + "|" + getCfg().USER_TOKEN);
                
            });
            getApp().saveConfig();
        }
        private void login()
        {

            getEngine().login(getCfg().USER_ID, getCfg().USER_TOKEN);
            
          //  Debug.Log("Now Login with" +Config.USER_ID+"|"+ Config.USER_TOKEN);
        }

    }
}