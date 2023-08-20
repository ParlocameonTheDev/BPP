using System;
using System.Collections.Generic;
using System.Text;

namespace BPP.Utilities
{
    internal class BPPDebug
    {
        public static void Log(object message)
        {
           if(BPP.DebugMode)
            {
                UnityEngine.Debug.Log(message);
            }

        }
    }
}
