using System;
using System.Data.SqlClient;
using System.Data;

namespace MyPractice
{
    public class Class1
    {
        public static void Main()
        {
            string s="Data source=.;initial catalog=Test;integrated security=true";
            SqlConnection conn = new SqlConnection(s);  
            conn.Open();
            SqlCommand cmd =new SqlCommand("select * from Accounts", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet(); 
            adapter.Fill(ds); 

            SqlDataReader reader = cmd.ExecuteReader(); 

            // it can read if connection is not live
            foreach(DataRow d in ds.Tables[0].Rows)
            {
                Console.WriteLine("id ={0}",d["AccountNumber"]);
            }
            //Reads only When Connection is Live
            while (reader.Read())
            {
                Console.WriteLine("id= {0}",reader["AccountNumber"]);
            }
            conn.Close();
            


        }
    }

}
