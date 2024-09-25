namespace PinPon
{
    public partial class Form2 : Form
    {
        private int TopXYon = 10;
        private int TopYYon = 10;
        int moveStep = 15;
        private System.Windows.Forms.Timer counterTimer1;
        private System.Windows.Forms.Timer counterTimer2;
        private int counterValue1 = 0;
        private int counterValue2 = 0;



        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            System.Windows.Forms.Timer topTimer = new System.Windows.Forms.Timer();
            topTimer.Interval = 50;
            topTimer.Tick += TopTimer_Tick;
            topTimer.Start();

            counterTimer1 = new System.Windows.Forms.Timer();
            counterTimer2 = new System.Windows.Forms.Timer();

            counterTimer1.Tick += CounterTimer1_Tick;
            counterTimer2.Tick += CounterTimer2_Tick;

            counterTimer1.Start();
            counterTimer2.Start();


            if (counterValue2 > 10 && counterValue2 < 30)
            {
                topTimer.Interval = 45;
            }
            if (counterValue2 > 30 && counterValue2 < 50)
            {
                topTimer.Interval = 40;
            }
            if (counterValue2 > 50 && counterValue2 < 70)
            {
                topTimer.Interval = 35;
            }
            if (counterValue2 > 70 && counterValue2 < 90)
            {
                topTimer.Interval = 30;
            }






            void CounterTimer2_Tick(object? sender, EventArgs e)
            {
                if (Top.Bounds.IntersectsWith(panel2.Bounds))
                {
                    counterValue2++;
                    label5.Text = "Gamer2 of Hits: " + counterValue2;
                }
            }

            void CounterTimer1_Tick(object? sender, EventArgs e)
            {
                if (Top.Bounds.IntersectsWith(panel1.Bounds))
                {
                    counterValue1++;
                    label1.Text = "Gamer1 of Hits: " + counterValue1;
                }
            }

            void TopTimer_Tick(object sender, EventArgs e)
            {
                Top.Left += TopXYon;
                Top.Top += TopYYon;

                if (Top.Left <= 0 || Top.Right >= ClientSize.Width)
                {
                    TopXYon = -TopXYon;
                }


                if (Top.Top <= 0)
                {
                    TopYYon = Math.Abs(TopYYon);
                    Top.Top = 1;
                }
                else if (Top.Bottom >= ClientSize.Height)
                {
                    TopYYon = -Math.Abs(TopYYon);
                    Top.Top = ClientSize.Height - Top.Height - 1;
                }


                if (Top.Bounds.IntersectsWith(panel1.Bounds) || Top.Bounds.IntersectsWith(panel2.Bounds))
                {
                    TopXYon = -TopXYon;


                    Random rnd = new Random();
                    TopYYon = rnd.Next(-10, 10);
                }


                if (Top.Bounds.IntersectsWith(boundaryTop.Bounds) || Top.Bounds.IntersectsWith(boundaryUp.Bounds))
                {
                    TopYYon = -TopYYon;
                }

                if (Top.Bounds.IntersectsWith(boundaryLeft.Bounds))
                {
                    topTimer.Stop();
                    MessageBox.Show("Oyuncu 1 Uduzdu! Yeniden Oyun ucun Enter-a basin!");
                    this.Close();

                }

                if (Top.Bounds.IntersectsWith(boundaryRight.Bounds))
                {
                    topTimer.Stop();
                    MessageBox.Show("Oyuncu 2 Uduzdu! Yeniden Oyun ucun Enter-a basin!");
                    this.Close();

                }
            }



            void Form1_KeyDown(object sender, KeyEventArgs e)
            {

                if (e.KeyCode == Keys.W && panel1.Top - moveStep >= boundaryTop.Bottom)
                {
                    panel1.Top -= moveStep;
                }
                else if (e.KeyCode == Keys.S && panel1.Bottom + moveStep <= boundaryUp.Top)
                {
                    panel1.Top += moveStep;
                }


                else if (e.KeyCode == Keys.Up && panel2.Top - moveStep >= boundaryTop.Bottom)
                {
                    panel2.Top -= moveStep;
                }
                else if (e.KeyCode == Keys.Down && panel2.Bottom + moveStep <= boundaryUp.Top)
                {
                    panel2.Top += moveStep;
                }

               
            }


        }
    }
}
