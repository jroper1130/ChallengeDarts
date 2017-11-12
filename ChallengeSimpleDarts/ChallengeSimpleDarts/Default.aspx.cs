using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //start game on btn click
            Game game = new Game("Player1", "Player2");
            //game method calls play method to start rounds; result to label
            string result = game.Play();
            Label1.Text = result;
        }
    }
}