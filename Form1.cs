namespace MemeForm
{
    public partial class Simon : Form
    {
        public Simon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "Dondlod.mp4";
            axWindowsMediaPlayer1.URL = url;
            //Replay indefinitely
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
    }
}
