using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConnectedDisconneted
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from Accounts", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);



                SqlDataReader sdr = cmd.ExecuteReader();
            
                con.Close();


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine("Acc no:" + dr["AccountNumber"] + " Current Balance :" + dr["CurrentBalance"]);
                }
                while (sdr.Read())
                {
                    Console.WriteLine("Acc no:" + sdr["AccountNumber"] + " Current Balance :" + sdr["CurrentBalance"]);
                }

            

        }

    }
}
