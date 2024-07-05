using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MenuChartBtn_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 0;
        }

        private void MenuDataBtn_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }

        private void MenuRuleBtn_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 2;
        }

        private void MenuApiBtn_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 3;
        }
    }
}
