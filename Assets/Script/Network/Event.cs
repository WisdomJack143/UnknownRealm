using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matchvs;
namespace UnknownRealm.Network
{
    public abstract class Event
    {
        public string name;
        public int id;
        public abstract string getName();
        public abstract int getId();
       protected Event() {
            this.name = getName();
            this.id=getId();
        }
    }
    
}
