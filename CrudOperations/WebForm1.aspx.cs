using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudOperations
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Display()
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            GridView1.DataSource = data.FootBallLeagues;
            GridView1.DataBind();
        }
        //show data
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            GridView1.DataSource = data.FootBallLeagues;
            GridView1.DataBind();
        }
        //insert
        protected void Button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            FootBallLeague footBallLeague = new FootBallLeague
            {
                MatchId = Convert.ToInt32(TextBox1.Text),
                TeamName1 = TextBox2.Text,
                TeamName2 = TextBox3.Text,
                MatchStatus = TextBox4.Text,
                WinningTeam = TextBox5.Text,
                Points = Convert.ToInt32(TextBox6.Text)

            };
            data.FootBallLeagues.InsertOnSubmit(footBallLeague);
            data.SubmitChanges();

            Display();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            FootBallLeague footBallLeague=data.FootBallLeagues.SingleOrDefault(x=>x.MatchId == Convert.ToInt32(TextBox7.Text));
            data.FootBallLeagues.DeleteOnSubmit(footBallLeague);
            data.SubmitChanges();

            Display();
        }
        //update the data
        protected void Button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
           
            FootBallLeague footBallLeague = data.FootBallLeagues.SingleOrDefault(x => x.MatchId == Convert.ToInt32(TextBox8.Text));
            footBallLeague.TeamName1 = TextBox9.Text;
            footBallLeague.TeamName2 = TextBox10.Text;
            footBallLeague.MatchStatus = TextBox11.Text;
            footBallLeague.WinningTeam = TextBox12.Text;
            footBallLeague.Points=Convert.ToInt32(TextBox13.Text);
            data.SubmitChanges();

            Display();
        }
    }
}