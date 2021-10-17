using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDoc
{
    public partial class Form1 : Form
    {
        MyNewClass mnc;
        /// <summary>
        /// Initialise test MyNewClass as size 4
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            mnc = new MyNewClass(4);
        }
        /// <summary>
        /// add test data to MyNewClass.
        /// First test in bounds and extreme data 
        /// then out of bounds data
        /// Test passes when correct messages returned for
        /// Adding data
        /// And retreiving data
        /// </summary>
        /// <param name="sender">Loader object</param>
        /// <param name="e">Loading event</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            for(float f = 0; f < 6; f++)
            {
                int response = mnc.AddData(f);
                if (response >= 0)
                {
                    listBox1.Items.Add(f + " added to array.");
                }
                else
                {
                    listBox1.Items.Add(f + " could not be added - array full!");
                }
            }
            for(int i = 0; i < 5; i++)
            {
                float f = mnc.DataAt(i);
                if(!(f.Equals(float.NaN)))
                {
                    listBox1.Items.Add("Number at location "+ i + " is " + f);
                }
                else
                    listBox1.Items.Add(i + " is beyond the array boundary!");
            }
        }
    }
}
