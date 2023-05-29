namespace StopWatch
{
    public partial class StopWatch : Form
    {
        private DateTime startTime;
        public StopWatch()
        {
            InitializeComponent();
        }

        private void Start_bttn_Click(object sender, EventArgs e)
        {
            //set a value that startstime
            startTime = DateTime.Now;

            //start the timer
            timer1.Start();
        }

        private void Stop_bttn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Reset_bttn_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            label1.Text = "00:00.00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - startTime;
            label1.Text = span.ToString(@"mm\:ss\.ff");
        }
    }
}