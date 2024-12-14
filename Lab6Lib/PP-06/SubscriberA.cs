using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6Lib;

namespace PP_06
{
    public class SubscriberA : ISubscriber
    {
        public void Update(string eventname)
        {
            Console.WriteLine(string.Format("Subscriber:{0}, Event:{1}", "A", eventname));
        }
    }

}
