using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int c1=10;private int c2=10;private int c3=10;private int c4=10;private int c5 = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //method that Wait for 30 sec once user watered the Plant
        #region 
        async void disableButtonP1()
        {
           btnP1.Enabled = false; btnS1.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(30));
            btnP1.Enabled = true; btnS1.Enabled = true;
        }
        async void disableButtonP2()
        {
            btnP2.Enabled = false; btnS2.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(30));
            btnP2.Enabled = true; btnS2.Enabled = true;
        }
        async void disableButtonP3()
        {
            btnP3.Enabled = false; btnS3.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(30));
            btnP3.Enabled = true; btnS3.Enabled = true;
        }
        async void disableButtonP4()
        {
            btnP4.Enabled = false; btnS4.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(30));
            btnP4.Enabled = true; btnS4.Enabled = true;
        }
        async void disableButtonP5()
        {
            btnP5.Enabled = false; btnS5.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(30));
            btnP5.Enabled = true; btnS5.Enabled = true;
        }
        #endregion

        // Timer Tick event on Button click
        #region
        private void timer1_Tick(object sender, EventArgs e)
        {
            c1--; 
            if (c1 == 0)
            {
                timer1.Stop();
                btnP1.Text = "Start";               
                btnP1.Enabled = true;             
                c1=10;
                if (timer1.Enabled == false)
                { disableButtonP1(); }
            }        
            label3.Text = c1.ToString();          
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            c2--;
            if ( c2 == 0)
            {
                timer2.Stop();         
                btnP2.Text = "Start";   
                btnP2.Enabled = true;
                c2 = 10;
                if (timer1.Enabled == false)
                { disableButtonP2(); }
            }
           label7.Text = c2.ToString();            
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            c3--;
            if (c3 == 0)
            {
                timer3.Stop();
                btnP3.Text = "Start";
                btnP3.Enabled = true;
                c3 = 10;
                if (timer1.Enabled == false)
                { disableButtonP3(); }
            }
            label8.Text = c3.ToString();
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            c4--;
            if (c4 == 0)
            {
                timer4.Stop();
                btnP4.Text = "Start";
                btnP4.Enabled = true;
                c4 = 10;
                if (timer1.Enabled == false)
                { disableButtonP4(); }
            }
            label9.Text = c4.ToString();
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            c5--;
            if (c5 == 0)
            {
                timer5.Stop();
                btnP5.Text = "Start";
                btnP5.Enabled = true;
                c5 = 10;
                if (timer1.Enabled == false)
                { disableButtonP5(); }
            }
            label10.Text = c5.ToString();
        }
        #endregion

        // Start button Click
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick); /* Adds the event and the event handler for the method that will process the timer event to the timer. */
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            btnP1.Text = "Watering Plants...";
            btnP1.Enabled = false;
            label3.Text = c1.ToString();         
         }
        private void btnP2_Click(object sender, EventArgs e)
        {
            timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(timer2_Tick);  /* Adds the event and the event handler for the method that will process the timer event to the timer. */
            timer2.Interval = 1000; // 1 second
            timer2.Start();
            btnP2.Text = "Watering Plants...";
            btnP2.Enabled = false;
            label7.Text = c2.ToString(); 
        }
        private void btnP3_Click(object sender, EventArgs e)
        {
            timer3 = new System.Windows.Forms.Timer();
            timer3.Tick += new EventHandler(timer3_Tick);  /* Adds the event and the event handler for the method that will process the timer event to the timer. */
            timer3.Interval = 1000; // 1 second
            timer3.Start();
            btnP3.Text = "Watering Plants...";
            btnP3.Enabled = false;
            label8.Text = c3.ToString(); 
        }
        private void btnP4_Click(object sender, EventArgs e)
        {
            timer4 = new System.Windows.Forms.Timer();
            timer4.Tick += new EventHandler(timer4_Tick);  /* Adds the event and the event handler for the method that will process the timer event to the timer. */
            timer4.Interval = 1000; // 1 second
            timer4.Start();
            btnP4.Text = "Watering Plants...";
            btnP4.Enabled = false;
            label9.Text = c4.ToString(); 
        }
        private void btnP5_Click(object sender, EventArgs e)
        {
            timer5 = new System.Windows.Forms.Timer();
            timer5.Tick += new EventHandler(timer5_Tick);  /* Adds the event and the event handler for the method that will process the timer event to the timer. */
            timer5.Interval = 1000; // 1 second
            timer5.Start();
            btnP5.Text = "Watering Plants...";
            btnP5.Enabled = false;
            label10.Text = c5.ToString(); 
        }
        #endregion

        // Stop Button Click
        #region
        private void btnS1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnP1.Enabled = true; btnP1.Text = "Start";
        }
        private void btnS2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            btnP2.Enabled = true; btnP2.Text = "Start";
        }
        private void btnS3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            btnP3.Enabled = true; btnP3.Text = "Start";
        }
        private void btnS4_Click(object sender, EventArgs e)
        {
            timer4.Stop();
            btnP4.Enabled = true; btnP4.Text = "Start";
        }
        private void btnS5_Click(object sender, EventArgs e)
        {
            timer5.Stop();
            btnP5.Enabled = true; btnP5.Text = "Start";
        }
        #endregion
    }
}
