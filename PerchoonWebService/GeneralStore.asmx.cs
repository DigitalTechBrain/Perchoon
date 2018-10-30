using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PerchoonWebService
{
    /// <summary>
    /// Summary description for GeneralStore
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GeneralStore : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataTable Get()
        {


            using (SqlConnection con = new SqlConnection("server=JACK-PC;UID=sa;Password=1234;Database=Testing"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "tbl";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
    }
}
