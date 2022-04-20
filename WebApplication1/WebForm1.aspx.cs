using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NewMethod();
            
        }

        private void NewMethod()
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            GridView1.DataSource = data.FootBallLeagues;
            GridView1.DataBind();
        }


        protected void Japan_Click(object sender, EventArgs e)
        {
            NewMethod1();
        }

        private void NewMethod1()
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
           
            GridView1.DataSource = from football in data.FootBallLeagues
                                   where football.TeamName1 == "Japan" || football.TeamName2 == "Japan"
                                   select football;
            GridView1.DataBind();
        }

        protected void Win_Click(object sender, EventArgs e)
        {
            NewMethod2();
        }

        private void NewMethod2()
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            GridView1.DataSource = from football in data.FootBallLeagues
                                   where football.MatchStatus == "Win"
                                   select football;
            GridView1.DataBind();
        }

        protected void Draw_click(object sender, EventArgs e)
        {
            NewMethod3();
        }

        private void NewMethod3()
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            GridView1.DataSource = from football in data.FootBallLeagues
                                   where football.MatchStatus == "Draw"
                                   select football;
            GridView1.DataBind();
        }


    }
}