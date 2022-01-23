using System;
using System.Collections.Generic;
using System.Text;

namespace BPP.Utilities
{
    internal class BPPDebug
    {
        public static void Log(object message)
        {
           if(Config.isDebugBuild)
            {
                UnityEngine.Debug.Log(message);
            }

        }
    }
}
