using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Matchvs;
using System;

namespace UnknownRealm
{
    public class MyBehaviour : MonoBehaviour
    {
 
 


        protected MatchvsEngine getEngine() {
            return MatchvsEngine.getInstance();
        }
        protected UnknownRealm getApp() {
            return UnknownRealm.getInstance();
        }
        protected Config getCfg() {
 
            return getApp().getConfig();
        }
        protected void log(System.Object o) {
            Debug.Log(o);
        }

        protected void listen(string methodName, Delegate func) {
            getEngine().listen(methodName, func);

        }






 
    }
}
