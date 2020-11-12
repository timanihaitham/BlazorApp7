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

        public static User CheckAndReturnUser(string Code, string PWD)
        {
            User Usr = null;
            using (SqlConnection Cn = new SqlConnection(ApplicatonInfo.SQLdbms.ConnectionString))
            {
                using (SqlCommand CM = new SqlCommand("SELECT * FROM ", Cn))
                {
                    Cn.Open();
                    SqlDataReader DR = CM.ExecuteReader();
                    if (DR.Read())
                    {
                        Usr = new User();
                        Usr.UserID = (int)DR[0];
                        Usr.Code = DR[1].ToString();
                        Usr.Name = DR[2].ToString();
                    }
                    Cn.Close();
                }
            }
            return Usr;
        }
    }
}
