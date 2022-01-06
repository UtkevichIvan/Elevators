using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    public partial class Form3 : Form
    {
        public Form3(int[] deliveredPeople, DateTime time)
        {
            InitializeComponent();
            int x = 0;
            for (int i = 0; i < deliveredPeople.Length; i++)
            {
                x += deliveredPeople[i];
                labelDeliveredEach.Text = labelDeliveredEach.Text + "Lift" + i.ToString() + ": " + deliveredPeople[i].ToString()+ ". ";
            }
            labelDelivered.Text = x.ToString();
            labelTime.Text = time.ToString("HH:mm:ss");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
