using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            helpBox.Text = "Initially, you can freely conquer 1 unclaimed piece of land. " +
                "Doing so takes 1 turn.\nEvery turn, you can click on a continent. " +
                "Clicking on one under your control increases its resources.\n" +
                "After turn 4.5, you may choose to invade another player's continent." +
                "Invading a continent costs you as much power as the continent has resources to invade it.\n" +
                "An invaded continent cannot yield any resources to the player that owns it.\n" +
                "If your land is being invaded, you can choose to defend it, costing you as much power as the continent has resources. " +
                "Doing so will reclaim the land. If you choose to leave it, the other player will conquer that continent.\n"+
                "To win, you must overthrow all enemy continents.";
        }

        private void startLocal_Click(object sender, EventArgs e)
        {
            mapView newView = new mapView();
            newView.Visible = true;
        }
    }
}
