using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaSystems.Application.Classes
{
    public class ApplicatonInfo
    {
        public static string AppName { get { return System.Reflection.Assembly.GetEntryAssembly().GetName().Name; } }

        public enum MessageType
        {
            Info = 0,
            Error = 1,
            Warning = 2,
            Success = 3
        }

       static public User LoggedUser;
    }

}
