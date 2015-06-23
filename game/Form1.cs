using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyButton[] Butons = new MyButton[16];

        private void Form1_Load_1(object sender, EventArgs e)
        {
            int i = 0;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Butons[i] = new MyButton();                                 //новая кнопка
                    Butons[i].Size = new Size(50, 50);                          //размеры
                    Butons[i].Click += new EventHandler(Buttons_Click);         //действие нажатия кнопки
                    Butons[i].Location = new Point(20 + x * 60, 40 + y * 60);   //позиция кнопки в окне
                    Butons[i].Pozition = new Point(x, y);                       //матричная позиция
                    this.Controls.Add(Butons[i]);
                    Butons[i].Text = ((i++) + 1).ToString();                    //текст кнопки
                }
            }
            Butons[15].Visible = false;                                         //скрыть 16-ю кнопку
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            MyButton Now = (MyButton)sender;
            int x = Math.Abs(Now.Pozition.X - Butons[15].Pozition.X);
            int y = Math.Abs(Now.Pozition.Y - Butons[15].Pozition.Y);
            if ((x == 1 && y == 0) || (x == 0 && y == 1))
            {
                Point P = Now.Pozition;
                Now.Pozition = Butons[15].Pozition;
                Butons[15].Pozition = P;
                Now.Location = new Point(20 + Now.Pozition.X * 60, 40 + Now.Pozition.Y * 60);
                Butons[15].Location = new Point(20 + Butons[15].Pozition.X * 60, 40 + Butons[15].Pozition.Y * 60);
                if (victory()) MessageBox.Show("Победа!");
            }
        }


        private void Start_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (int y = 0; y < 4; y++)
                for (int x = 0; x < 4; x++)
                {
                    Butons[i].Location = new Point(20 + x * 60, 40 + y * 60);
                    Butons[i++].Pozition = new Point(x, y);
                }
            Random rand = new Random();
            for (int j = 0; j < 50; j++)
            {
                int a = rand.Next(0, 16);
                int b = rand.Next(0, 16);
                Point P = Butons[a].Pozition;
                Butons[a].Pozition = Butons[b].Pozition;
                Butons[b].Pozition = P;
                Butons[a].Location = new Point(20 + Butons[a].Pozition.X * 60, 40 + Butons[a].Pozition.Y * 60);
                Butons[b].Location = new Point(20 + Butons[b].Pozition.X * 60, 40 + Butons[b].Pozition.Y * 60);
            }
            int[] Mat = new Int32[16];
            int num = 0;
            for (int z = 0; z < 4; z++)
            {
                for (int s = 0; s < 4; s++)
                {

                    for (i = 0; i < 15; i++)
                        if (Butons[i].Location == new Point(20 + s * 60, 40 + z * 60))
                            Mat[num] = i;
                    num++;
                }
            }
            int Sum = 0;
            for (num = 0; num < 15; num++)
                for (int tik = num + 1; tik < 15; tik++)
                    if (Mat[num] > Mat[tik]) Sum++;
            Sum += Butons[15].Pozition.X;
            if (Sum % 2 != 0)
                MessageBox.Show("Нет решения.");
        }



        private void UI1_Click(object sender, EventArgs e)
        {
            do
            {
                for (int j = 0; j < 15; j++)
                {
                    if (finish(j) == false)
                    {
                        int x1 = Butons[j].Pozition.X - Butons[15].Pozition.X;
                        if (x1 > 1)
                        {
                            for (int i = 0; i < 15; i++)
                            {
                                if (i != j)
                                {
                                    int y = Butons[i].Pozition.X - Butons[15].Pozition.X;
                                    if (y == 1)
                                    {
                                        Point P = Butons[i].Pozition;
                                        Butons[i].Pozition = Butons[15].Pozition;
                                        Butons[15].Pozition = P;
                                    }
                                }
                            }
                        }
                        if (x1 < -1)
                        {
                            for (int i = 0; i < 15; i++)
                            {
                                if (i != j)
                                {
                                    int x = Butons[i].Pozition.X - Butons[15].Pozition.X;
                                    if (x == -1)
                                    {
                                        Point P = Butons[i].Pozition;
                                        Butons[i].Pozition = Butons[15].Pozition;
                                        Butons[15].Pozition = P;
                                    }

                                }
                            }
                        }

                        int y1 = Butons[j].Pozition.Y - Butons[15].Pozition.Y;
                        if (y1 > 1)
                        {
                            for (int i = 0; i < 15; i++)
                            {
                                if (i != j)
                                {
                                    int y = Butons[i].Pozition.Y - Butons[15].Pozition.Y;
                                    if (y == 1)
                                    {
                                        Point P = Butons[i].Pozition;
                                        Butons[i].Pozition = Butons[15].Pozition;
                                        Butons[15].Pozition = P;
                                    }
                                }
                            }
                        }
                        if (y1 < -1)
                        {
                            for (int i = 0; i < 15; i++)
                            {
                                if (i != j)
                                {
                                    int y = Butons[i].Pozition.Y - Butons[15].Pozition.Y;
                                    if (y == -1)
                                    {
                                        Point P = Butons[i].Pozition;
                                        Butons[i].Pozition = Butons[15].Pozition;
                                        Butons[15].Pozition = P;
                                    }
                                }
                            }
                        }

                        if ((x1 == 1 && y1 == 0) || (x1 == 0 && y1 == 1))
                        {
                            int l, k;
                            int m = 0;
                            for (l = 0; l < 4; l++)
                                for (k = 0; k < 4; k++)
                                {
                                    m++;
                                    if (m == j)
                                    {
                                        if (Math.Abs(Butons[j].Pozition.X - k) >= 1 || Math.Abs(Butons[j].Pozition.Y - l) >= 1)
                                        {
                                            Point P = Butons[j].Pozition;
                                            Butons[j].Pozition = Butons[15].Pozition;
                                            Butons[15].Pozition = P;
                                        }
                                    }
                                }
                        }
                        if ((x1 == -1 && y1 == 0) || (x1 == 0 && y1 == -1))
                        {
                            int l, k;
                            int m = 0;
                            for (l = 0; l < 4; l++)
                                for (k = 0; k < 4; k++)
                                {
                                    m++;
                                    if (m == j)
                                    {
                                        if (Math.Abs(k - Butons[j].Pozition.X) >= 1 || Math.Abs(l - Butons[j].Pozition.Y) >= 1)
                                        {
                                            Point P = Butons[j].Pozition;
                                            Butons[j].Pozition = Butons[15].Pozition;
                                            Butons[15].Pozition = P;
                                        }
                                    }
                                }
                        }
                    }
                    for (j = 0; j < 16; j++)
                    {
                        Butons[j].Location = new Point(20 + Butons[j].Pozition.X * 60, 40 + Butons[j].Pozition.Y * 60);
                    }

                }
            } while (victory() != true);

            MessageBox.Show("Победа.");
        }



        private bool victory()
        {
            int i = 0;
            for (int y = 0; y < 4; y++)
                for (int x = 0; x < 4; x++)
                    if (Butons[i++].Location != new Point(20 + x * 60, 40 + y * 60)) return false;
            return true;
        }

        private bool finish(int j)
        {

            for (int y = 0; y < 4; y++)
                for (int x = 0; x < 4; x++)
                    if (Butons[j].Location == new Point(20 + x * 60, 40 + y * 60)) return true;
            return false;
        }

        private void UI2_Click_1(object sender, EventArgs e)
        {
            do
            {
                Random rand = new Random();
                int i = rand.Next(0, 15);
                int x = Butons[i].Pozition.X - Butons[15].Pozition.X;
                int y = Butons[i].Pozition.Y - Butons[15].Pozition.Y;
                if ((x == 1 && y == 0) || (x == 0 && y == 1))
                {
                    int l, k;
                    int m = 0;
                    for (l = 0; l < 4; l++)
                        for (k = 0; k < 4; k++)
                        {
                            m++;
                            if (m == i)
                            {
                                if (Butons[i].Pozition.X - k >= 1 || Butons[i].Pozition.Y - l >= 1)
                                {
                                    Point P = Butons[i].Pozition;
                                    Butons[i].Pozition = Butons[15].Pozition;
                                    Butons[15].Pozition = P;
                                    Butons[i].Location = new Point(20 + Butons[i].Pozition.X * 60, 40 + Butons[i].Pozition.Y * 60);
                                    Butons[15].Location = new Point(20 + Butons[15].Pozition.X * 60, 40 + Butons[15].Pozition.Y * 60);
                                }
                            }
                        }
                }
                if ((x == -1 && y == 0) || (x == 0 && y == -1))
                {
                    int l, k;
                    int m = 0;
                    for (l = 0; l < 4; l++)
                        for (k = 0; k < 4; k++)
                        {
                            m++;
                            if (m == i)
                            {
                                if (k - Butons[i].Pozition.X >= 1 || l - Butons[i].Pozition.Y >= 1)
                                {
                                    Point P = Butons[i].Pozition;
                                    Butons[i].Pozition = Butons[15].Pozition;
                                    Butons[15].Pozition = P;
                                    Butons[i].Location = new Point(20 + Butons[i].Pozition.X * 60, 40 + Butons[i].Pozition.Y * 60);
                                    Butons[15].Location = new Point(20 + Butons[15].Pozition.X * 60, 40 + Butons[15].Pozition.Y * 60);
                                }
                            }
                        }
                }


            } while (victory() != true);
            MessageBox.Show("Победа.");

        }

    }
}
