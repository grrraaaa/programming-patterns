using Lab6Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_06
{
    public class SubscriberB : ISubscriber
    {
        public void Update(string eventname)
        {
            Console.WriteLine(string.Format("Subscriber:{0}, Event:{1}", "B", eventname));
        }
    }

}
