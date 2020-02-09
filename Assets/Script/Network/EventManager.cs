using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;
using Matchvs;
using UnityEngine;
namespace UnknownRealm.Network
{
    class EventManager
    {
        MatchvsEngine engine=MatchvsEngine.getInstance();
        Dictionary<int, Event> events = new Dictionary<int, Event>();
        public void regEvent() { 
        }
        public void sendEvent(Event e)
        {
            String str = JsonMapper.ToJson(e);
            engine.sendEvent(str);
        }
        public void sendFrameEvent(Event e)
        {
            String str = JsonMapper.ToJson(e);
            engine.sendEvent(str);
        }


 
    }
}
