using System;
using System.Data.SqlClient;

namespace HexaSystems.Application.Classes
{
    public class User
    {
        //Class Members are not defined as static, because impersonation may be applied on later time
        public int UserID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public static User CheckAndReturnUser(string Code, string PWD)
        {
            User Usr = null;
            string Stmt= " SELECT  Usr_Code ,Usr_ID, Usr_Name,Usr_PWD,Usr_State FROM    dbo.tbl_Users WHERE   Usr_Code = '" + Code.Replace("'","''") +"' AND Usr_PWD = '" + PWD.Replace("'","''") + "'";

            using (SqlConnection Cn = new SqlConnection(ApplicatonInfo.SQLdbms.ConnectionString))
            {
                using (SqlCommand CM = new SqlCommand(Stmt, Cn))
                {
                    Cn.Open();
                    SqlDataReader DR = CM.ExecuteReader();
                    if (DR.Read())
                    {
                        Usr = new User();
                        Usr.UserID = (int)DR["Usr_ID"];
                        Usr.Code = DR["Usr_Code"].ToString();
                        Usr.Name = DR["Usr_Name"].ToString();
                        Usr.Active = (bool)DR["Usr_State"];
                    }
                    Cn.Close();
                }
            }
            return Usr;
        }
    }
}
