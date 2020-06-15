using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_16_2020_dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Georgia");
            comboBox1.Items.Add("North Carolina");
            comboBox1.Items.Add("Tennessee");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
            "https://www.zillow.com/homes/for_sale/?searchQueryState=%7B%22pagination%22%3A%7B%7D%2C%22" +
            "mapBounds%22%3A%7B%22west%22%3A-87.17266864731548%2C%22east%22%3A-80.74566669419048%2C%22south%22%3A32.962499414402274%2C%22north%22%3A36.72119073932386%7D%2C%22isMapVisible%22%3Atrue%2C%22mapZoom%22%3A8%2C%22filterState%22%3A%7B%22" +
            "price%22%3A%7B%22min%22%3A0%2C%22max%22%3A200000%" +
            "7D%2C%22mp%22%3A%7B%22min%22%3A0%2C%22max%22%3A714%7D%2C%22sort%22%3A%7B%22value%22%3A%22" +
            "lot%22%7D%2C%22lot%22%3A%7B%22min%22%3A2178000%7D%7D%2C%22isListVisible%22%3Atrue%2C%22customRegionId%22%3A%220aa965ebeeX1-CR1ngqaivvkzgxq_zwat1%22%7D");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] georgiaCounties = {
                "Dawson County",
                "Fannin County",
                "Gilmer County",
                "Habersham County",
                "Lumpkin County",
                "Pickins County",
                "Rabun County",
                "Stephens County",
                "Towns County",
                "Union County",
                "White County"
            };

            string[] ncCounties = {
                "Alleghany County",
                "Ashe County",
                "Avery County",
                "Buncombe County",
                "Burke County",
                "Caldwell County",
                "Cherokee County",
                "Clay County",
                "Graham County",
                "Haywood County",
                "Henderson County",
                "Jackson County",
                "Macon County",
                "Madison County",
                "McDowell County",
                "Mitchell County",
                "Polk County",
                "Rutherford County",
                "Swain County",
                "Transylvania County",
                "Watauga County",
                "Wilkes County",
                "Yancey County",
            };

            string[] tnCounties = {
                "All Counties",
            };

            comboBox2.Items.Clear();

            string stateInput = comboBox1.Text;

            if (stateInput == "Georgia")
            {
                foreach (string county in georgiaCounties)
                {
                    comboBox2.Items.Add(county);
                }
            }
            else if (stateInput == "North Carolina")
            {
                foreach (string county in ncCounties)
                {
                    comboBox2.Items.Add(county);
                }
            }
            else if (stateInput == "Tennessee")
            {
                foreach (string county in tnCounties)
                {
                    comboBox2.Items.Add(county);
                }
            }
        }

        private void countyButton_Click_1(object sender, EventArgs e)
        {
            string[] georgiaCounties = {
                "Dawson County",
                "Fannin County",
                "Gilmer County",
                "Habersham County",
                "Lumpkin County",
                "Pickins County",
                "Rabun County",
                "Stephens County",
                "Towns County",
                "Union County",
                "White County"
            };

            string[] ncCounties = {
                "Alleghany County",
                "Ashe County",
                "Avery County",
                "Buncombe County",
                "Burke County",
                "Caldwell County",
                "Cherokee County",
                "Clay County",
                "Graham County",
                "Haywood County",
                "Henderson County",
                "Jackson County",
                "Macon County",
                "Madison County",
                "McDowell County",
                "Mitchell County",
                "Polk County",
                "Rutherford County",
                "Swain County",
                "Transylvania County",
                "Watauga County",
                "Wilkes County",
                "Yancey County",
            };

            string[] tnCounties = {
                "All Counties",
            };

            string[] georgiaCountySites = {
                "Dawson County",
                "Fannin County",
                "Gilmer County",
                "Habersham County",
                "Lumpkin County",
                "Pickins County",
                "Rabun County",
                "Stephens County",
                "Towns County",
                "Union County",
                "White County"
            };

            string[] ncCountySites = {
                "Alleghany County",
                "Ashe County",
                "Avery County",
                "Buncombe County",
                "Burke County",
                "Caldwell County",
                "https://maps.cherokeecounty-nc.gov/GISweb/GISviewer/",
                "Clay County",
                "http://grahamconc.maps.arcgis.com/apps/Solutions/s2.html?appid=2a8aac7f18164a0389472dbe52f68ee0",
                "Haywood County",
                "Henderson County",
                "Jackson County",
                "Macon County",
                "Madison County",
                "McDowell County",
                "Mitchell County",
                "Polk County",
                "Rutherford County",
                "Swain County",
                "Transylvania County",
                "Watauga County",
                "Wilkes County",
                "Yancey County",
            };

            string[] tnCountySites = {
                "https://tnmap.tn.gov/assessment/",

            };

            string buttonInput = countyButton.Text;
            string[] counties = georgiaCounties;
            string[] stateSite = georgiaCountySites;

            if (comboBox1.Text == "Georgia")
            {
                counties = georgiaCounties;
            }
            else if (comboBox1.Text == "North Carolina")
            {
                counties = ncCounties;
            }
            else if (comboBox1.Text == "Tennessee")
            {
                counties = tnCounties;
            }

            if (comboBox1.Text == "Georgia")
            {
                stateSite = georgiaCountySites;
            } 
            else if (comboBox1.Text == "North Carolina")
            {
                stateSite = ncCountySites;
            }
            else if (comboBox1.Text == "Tennessee")
            {
                stateSite = tnCountySites;
            }


            if (stateSite[Array.IndexOf(counties, buttonInput)].Contains("http"))
            {
                Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                $"{stateSite[Array.IndexOf(counties, buttonInput)]}");
            } else
            {
                Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                "https://www.google.com/");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            countyButton.Text = comboBox2.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
