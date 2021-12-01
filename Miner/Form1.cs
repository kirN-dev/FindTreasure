using Miner.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

			this.Text = "Кладоискатель";

            MapController.Init(this, panel1);
			MapController.OnDig += MapController_OnDig;
			MapController.OnFindTreasure += MapController_OnFindTreasure; 
        }

		private void MapController_OnFindTreasure(int treasureCount)
		{
			if (treasureCount == -1)
			{
				label2.Text = "?";
				return;
			}

			label2.Text = treasureCount.ToString();
		}

		private void MapController_OnDig(int shovelCount)
		{
            label1.Text = shovelCount.ToString();
		}
	}
}
