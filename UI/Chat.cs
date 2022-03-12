namespace TrackerUI
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int mouseX = 0;
        int mouseY = 0;
        int mouseinX = 0;
        int mouseinY = 0;
        bool mouseDown;
        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            textBox.Text = String.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}