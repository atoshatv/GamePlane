using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GamePlane
{
    public partial class Form1 : Form

    {
        int choise = 0;
        int go = 0;
        int i = 0;
        private int maxi;
       







        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;





        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (jet.Visible == true)
            {

                go = 10;
            }
            else if (Plane.Visible == true)
            {
                go = (int)7.5;
            }

            else if (vint.Visible == true)
            {
                go = 5;










            }

            int speed = 7;
            Fon1.Top += speed;
            Fon2.Top += speed;

            int planespeed = go;
            Plane2.Top += planespeed;
            Plane3.Top += planespeed;

            if (Fon1.Top >= 800)
            {
                Fon1.Top = 0;
                Fon2.Top = -800;
            }
            if (Plane2.Top >= 800)
            {
                Plane2.Top = -150;
                Random rand = new Random();
                Plane2.Left = rand.Next(270, 450);
            }
            if (Plane3.Top >= 800)
            {
                Plane3.Top = -450;
                Random rand = new Random();
                Plane3.Left = rand.Next(550, 750);
            }
            if (Plane.Bounds.IntersectsWith(Plane2.Bounds) || Plane.Bounds.IntersectsWith(Plane3.Bounds) || vint.Bounds.IntersectsWith(Plane2.Bounds) || vint.Bounds.IntersectsWith(Plane3.Bounds) || jet.Bounds.IntersectsWith(Plane2.Bounds) || jet.Bounds.IntersectsWith(Plane3.Bounds))
            {
                GameOver.Visible = true;
                NweGame.Visible = true;
                timer1.Enabled = false;
                jet.Visible = false;
                Plane.Visible = false;
                vint.Visible = false;
                timer2.Enabled = false;

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 15;
            if ((e.KeyCode == Keys.Left) && Plane.Left > 270)
            {
                Plane.Left -= speed;
                vint.Left -= speed;
                jet.Left -= speed;
            }

            else if ((e.KeyCode == Keys.Right) && Plane.Right < 830)
            {
                Plane.Left += speed;
                vint.Left += speed;
                jet.Left += speed;



            }
        }

        private void NweGame_Click(object sender, EventArgs e)
        {
            Plane2.Top = -150;
            Plane3.Top = -450;
            GameOver.Visible = false;
            NweGame.Visible = false;
            kvjet.Visible = true;
            kvplane.Visible = true;
            kvvint.Visible = true;
            vint2.Visible = true;
            jet2.Visible = true;
            planeP.Visible = true;
            ВыбериС.Visible = true;
            i = 0;
            timertext.Text = i.ToString();




        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ВыбериС.Visible = true;
            timer1.Enabled = false;

            Plane.Visible = false;





        }

        private void kvvint_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            choise = button.TabIndex;
            if (choise == 8)
            {
                vint.Visible = true;
            }
            else if (choise == 9)
            {
                Plane.Visible = true;

            }
            else if (choise == 10)
            {
                jet.Visible = true;

            }
            ВыбериС.Visible = false;
            timer1.Enabled = true;
            kvjet.Visible = false;
            kvplane.Visible = false;
            kvvint.Visible = false;
            vint2.Visible = false;
            jet2.Visible = false;
            planeP.Visible = false;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            timertext.Text = i.ToString();
            label1.Text = "Рекорд: " + maxi.ToString();

            if (i > maxi)
            {
                maxi = i ;
            }



        }

        
    }
}