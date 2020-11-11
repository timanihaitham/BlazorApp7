using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO.Enumeration;

namespace HexaSystems.Application.Classes
{
    public class User
    {
        //Class Members are not defined as static, because impersonation may be applied on later time

        public int UserID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        
        static void InsertLog(int USerID, string StepCode)
        {
           
        }


    }
}
