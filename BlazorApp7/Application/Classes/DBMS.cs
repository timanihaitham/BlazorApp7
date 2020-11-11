namespace HexaSystems.Application.Classes
{
    public class DBMS
    {
        class SQL
        {
            string Server { get; set; }

            string Database { get; set; }

            string User { get; set; }

            string PWD { get; set; }

            string ConnectionString
            {
                get
                {
                    return "Server=" + Server + ";Database=" + Database + ";User Id=" + User + ";Password=" + PWD + ";Application Name=" + ApplicatonInfo.AppName;
                }
            }

        }
    }
}
