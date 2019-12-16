using System;
using System.Windows.Forms;
using System.Diagnostics; //Need it to use Windows Diagnostics tools.


namespace CpuMonitor
{
    

    public partial class Form1 : Form
    {
        //Take the current value from Windows Diagnostics.
        PerformanceCounter CpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter MemPerfCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter SysPerfCounter = new PerformanceCounter("System", "System Up Time");
 
        public Form1()
        {
            InitializeComponent();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Print CPU usage:
            progressBar1.Value = (int)(CpuPerfCounter.NextValue());          CPU.Text = progressBar1.Value.ToString() + " %";

            //Print Ram Memory Usage:
            RamAvailableByts.Text = (int)MemPerfCounter.NextValue() + "  MB";

            
            //Print Sytem Up Time:
            int SysPerfInMins = (int)SysPerfCounter.NextValue()/60;

            //If the value is greater than 120 convert to hours.
            if (SysPerfInMins < 120)
            {
                SystemUpTime.Text = SysPerfInMins.ToString() + "  Minutes"; 
            }
            else
            {
                SystemUpTime.Text = (SysPerfInMins / 60).ToString() + "  Hours";
            }
            


        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0" + Environment.NewLine + "Created by George Pappas");
        }
    }
}
