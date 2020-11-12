namespace HexaSystems.Application.Classes
{
    
    public static class ApplicatonInfo
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
        static public DBMS.SQL SQLdbms;

    }

}
