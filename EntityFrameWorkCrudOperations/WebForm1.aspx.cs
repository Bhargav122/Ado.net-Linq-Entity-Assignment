using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace EntityFrameWorkTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        private void Display()
        {
            TestEntities1 testEntities = new TestEntities1();
            // GridView1.DataSource = testEntities.FootBallLeagues;
            GridView1.DataSource = (from em in testEntities.FootBallLeagues
                                    select em).ToList();
            GridView1.DataBind();
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Display();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TestEntities1 testEntities=new TestEntities1();
            FootBallLeague footBallLeague = new FootBallLeague
            {
                MatchId = Convert.ToInt32(TextBox1.Text),
                TeamName1 = TextBox2.Text,
                TeamName2 = TextBox3.Text,
                MatchStatus = TextBox4.Text,
                WinningTeam = TextBox5.Text,
                Points= Convert.ToInt32(TextBox6.Text)
            };
            testEntities.FootBallLeagues.Add(footBallLeague);
            testEntities.SaveChanges();
            Display();

        }

        private void Delete()
        {
            TestEntities1 testEntities1 = new TestEntities1();
           // int id = Convert.ToInt32(TextBox7.Text);
            
            FootBallLeague footBallLeague = testEntities1.FootBallLeagues.Find(Convert.ToInt32(TextBox7.Text));
            testEntities1.FootBallLeagues.Remove(footBallLeague);
            testEntities1.SaveChanges();
            
        }
        //Delete
        protected void Button3_Click(object sender, EventArgs e)
        {
            Delete();
        }
        //Updtae table
        protected void Button4_Click(object sender, EventArgs e)
        {
            Update();
          
        }

        private void Update()
        {

            TestEntities1 testEntities1 = new TestEntities1();

            FootBallLeague footBallLeague = testEntities1.FootBallLeagues.Find(Convert.ToInt32(TextBox8.Text));

            footBallLeague.TeamName1 = TextBox9.Text;
            footBallLeague.TeamName2 = TextBox10.Text;
            footBallLeague.MatchStatus = TextBox11.Text;
            footBallLeague.WinningTeam = TextBox12.Text;
            footBallLeague.Points = Convert.ToInt32(TextBox13.Text);
            testEntities1.SaveChanges();


        }
    }
}