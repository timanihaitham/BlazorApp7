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
            return new User();
        }
    }
}
