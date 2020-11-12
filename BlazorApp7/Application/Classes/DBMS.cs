namespace HexaSystems.Application.Classes
{
    public class DBMS
    {
        public class SQL
        {
            public string Server { get; set; }

            public string Database { get; set; }

            public string User { get; set; }

            public string PWD { get; set; }

            public string ConnectionString
            {
                get
                {
                    return "Server=" + Server + ";Database=" + Database + ";User Id=" + User + ";Password=" + PWD + ";Application Name=" + ApplicatonInfo.AppName;
                }
            }

        }
    }
}
