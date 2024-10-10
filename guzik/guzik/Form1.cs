using System.Media;

namespace guzik
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();


        }



        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void MoveButton(object sender, EventArgs e)
        {
            label1.Visible = true;
            Button b = (Button)sender;
            Random r = new Random();
            
    
            int maxX = this.Size.Width;
            maxX += this.Size.Width;
            int maxY = this.Size.Height;
            maxY += this.Size.Height;

            int x = r.Next(200);
            int y = r.Next(200);

            Point p = new Point();
            p.X = r.Next(12, 713);
            p.Y = r.Next(12, 415);
            b.Location = p;
          

            this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            b.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            b.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }


    }
}

