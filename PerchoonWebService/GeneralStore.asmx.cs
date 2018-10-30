using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

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


            using (SqlConnection con = new SqlConnection(@"server=USER-PC\SQLEXPRESS;UID=sa;Password=1234;Database=GeneralStore"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM UserRegistration"))
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

        // User Authentication

        public AuthUser User;

        [WebMethod]
        [SoapHeader("User", Required = true)]
        public string UserAuthentication()
        {
            if (User != null)
            {
                if (User.IsValid())
                    return "Hello " + User.UserName;
                else
                    return "Invalid User details!";
            }
            else
                return "Please provide User details!";
        }
    }

    public class AuthUser : System.Web.Services.Protocols.SoapHeader
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool IsValid()
        {
            int count = 0;

            //You can use database connection to check the userdetails valid or not
            //If user details found return true or else return false

            string config = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

            using (SqlConnection sqlcon = new SqlConnection(config))
            {
                SqlCommand sqlcmd = new SqlCommand("Select * from UserRegistration where Cphone ='" + UserName + "' and Cpwd ='" + Password + "'", sqlcon);
                sqlcmd.Connection.Open();
                count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                sqlcmd.Connection.Close();

                if (count > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
