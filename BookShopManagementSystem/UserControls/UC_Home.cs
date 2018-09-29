using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagementSystem.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            var source = new List<RevenuModel>
            {
                new RevenuModel
                {
                    Day = "Sunday",
                    Revenue = 1000,
                },

                new RevenuModel
                {
                    Day = "Monday",
                    Revenue = 1500,
                },

                new RevenuModel
                {
                    Day = "Tuesday",
                    Revenue = 2000,
                },

                new RevenuModel
                {
                    Day = "Wednesday",
                    Revenue = 1700,
                },

                new RevenuModel
                {
                    Day = "Thursday",
                    Revenue = 1500,
                },

                new RevenuModel
                {
                    Day = "Friday",
                    Revenue = 2300,
                },

                new RevenuModel
                {
                    Day = "Saturday",
                    Revenue = 3000,
                },

            };
            salesChart.DataSource = source;

            salesChart.Series["Revenue"].XValueMember = "Day";

            salesChart.Series["Revenue"].YValueMembers = "Revenue";
            salesChart.Series["Revenue"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;





        }
    }

    class RevenuModel
    {
        public string Day { get; set; }
        public int Revenue { get; set; }
    }
}
