using BookShopManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagementSystem.Forms
{
    public partial class Dashboard : Form
    {

        int PanelWidth;
        bool isCollapsed;

        public Dashboard()
        {
            InitializeComponent();
            PanelWidth = homePanel.Width;
            isCollapsed = false;


            UC_Home uC_Home = new UC_Home();
            AddControlsPanel(uC_Home);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                homePanel.Width += 10;
                if (homePanel.Width >= PanelWidth)
                {
                    timer.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                homePanel.Width -= 10;
                if (homePanel.Width < 78)
                {
                    timer.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void shutDownButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void MoveSidePanel(Control btn)
        {
            sidePanel.Top = btn.Top;
            sidePanel.Height = btn.Height;
        }

        private void AddControlsPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            controlsPanel.Controls.Clear();
            controlsPanel.Controls.Add(c);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(homeButton);
            UC_Home uC_Home = new UC_Home();
            AddControlsPanel(uC_Home);
        }

        private void SalebooksButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(salebooksButton);
            UC_Sales uC_Sales = new UC_Sales();
            AddControlsPanel(uC_Sales);

        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(purchaseButton);

        }

        private void ExpensesButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(expensesButton);

        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(usersButton);

        }

        private void viewSalesButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(viewSalesButton);

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(settingsButton);

        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
