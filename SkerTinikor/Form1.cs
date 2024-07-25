using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace SkerTinikor
{
    public partial class mainScreen : Form
    {
        string[,] seats = new string[5,10];
        public mainScreen()
        {
            InitializeComponent();
            initSeats(seats);
        }
        public void initSeats(string[,] s)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    s[row, col] = "*";
                }
            }
        }
        public int getX(char xS)
        {
            int x = 0;
            switch (xS)
            {
                case 'A':
                    x = 0;
                    break;
                case 'B':
                    x = 1;
                    break;
                case 'C':
                    x = 2;
                    break;
                case 'D':
                    x = 3;
                    break;
                case 'E':
                    x = 4;
                    break;
                case 'F':
                    x = 5;
                    break;
                case 'G':
                    break;
                    x = 6;
                case 'H':
                    x = 7;
                    break;
                case 'I':
                    x = 8;
                    break;
                case 'J':
                    x = 9;
                    break;
            }
                return x;
        }
        public int getY(char yS)
        {
            int y = int.Parse(yS + "") - 1;
            return y;
        }
        public bool isSeatBooked(string[,] s, int x, int y)
        {
            if (s[y, x].Equals("*")) { return false; }
            else 
            {
                MessageBox.Show("Seat is booked by " + s[y,x]);
                return true;
            }
        }
        public bool confirmUnbook(string[,] s, int x, int y)
        {
            DialogResult unbook = MessageBox.Show("Unbook this seat?", "Confirm Unbooking", MessageBoxButtons.YesNo);
            if (unbook == DialogResult.Yes)
            {
                unbookSeat(s, x, y);
                return true;
            }
            else { return false; }
        }
        public void bookSeat(string[,] s, int x, int y)
        {
                s[y,x] = Interaction.InputBox("Enter your name");
        }
        public void unbookSeat(string[,] s, int x, int y)
        {
            s[y, x] = "*";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button1.Text[0]), getY(button1.Text[1])))
            {
                bookSeat(seats, getX(button1.Text[0]), getY(button1.Text[1]));
                button1.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button1.Text[0]), getY(button1.Text[1])))
            {
                unbookSeat(seats, getX(button1.Text[0]), getY(button1.Text[1]));
                button1.BackColor = Color.LightGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button2.Text[0]), getY(button2.Text[1])))
            {
                bookSeat(seats, getX(button2.Text[0]), getY(button2.Text[1]));
                button2.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button2.Text[0]), getY(button2.Text[1])))
            {
                unbookSeat(seats, getX(button2.Text[0]), getY(button2.Text[1]));
                button2.BackColor = Color.LightGray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button3.Text[0]), getY(button3.Text[1])))
            {
                bookSeat(seats, getX(button3.Text[0]), getY(button3.Text[1]));
                button3.BackColor = Color.Red;
                button4.PerformClick();
                button4.Enabled = false;
            }
            else if (confirmUnbook(seats, getX(button3.Text[0]), getY(button3.Text[1])))
            {
                unbookSeat(seats, getX(button3.Text[0]), getY(button3.Text[1]));
                button3.BackColor = Color.LightGray;
                button4.Enabled = true;
                button4.PerformClick();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button4.Text[0]), getY(button4.Text[1])))
            {
                bookSeat(seats, getX(button4.Text[0]), getY(button4.Text[1]));
                button4.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button4.Text[0]), getY(button4.Text[1])))
            {
                unbookSeat(seats, getX(button4.Text[0]), getY(button4.Text[1]));
                button4.BackColor = Color.LightGray;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(!isSeatBooked(seats, getX(button5.Text[0]), getY(button5.Text[1])))
            {
                bookSeat(seats, getX(button5.Text[0]),getY(button5.Text[1]));
                button5.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button5.Text[0]), getY(button5.Text[1])))
            {
                unbookSeat(seats, getX(button5.Text[0]),getY(button5.Text[1]));
                button5.BackColor = Color.LightGray;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button6.Text[0]), getY(button6.Text[1])))
            {
                bookSeat(seats, getX(button6.Text[0]), getY(button6.Text[1]));
                button6.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button6.Text[0]), getY(button6.Text[1])))
            {
                unbookSeat(seats, getX(button6.Text[0]), getY(button6.Text[1]));
                button6.BackColor = Color.LightGray;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button21.Text[0]), getY(button21.Text[1])))
            {
                bookSeat(seats, getX(button21.Text[0]), getY(button21.Text[1]));
                button21.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button21.Text[0]), getY(button21.Text[1])))
            {
                unbookSeat(seats, getX(button21.Text[0]), getY(button21.Text[1]));
                button21.BackColor = Color.LightGray;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button22.Text[0]), getY(button22.Text[1])))
            {
                bookSeat(seats, getX(button22.Text[0]), getY(button22.Text[1]));
                button22.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button22.Text[0]), getY(button22.Text[1])))
            {
                unbookSeat(seats, getX(button22.Text[0]), getY(button22.Text[1]));
                button22.BackColor = Color.LightGray;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button23.Text[0]), getY(button23.Text[1])))
            {
                bookSeat(seats, getX(button23.Text[0]), getY(button23.Text[1]));
                button23.BackColor = Color.Red;
                button24.PerformClick();
                button24.Enabled = false;
            }
            else if (confirmUnbook(seats, getX(button23.Text[0]), getY(button23.Text[1])))
            {
                unbookSeat(seats, getX(button23.Text[0]), getY(button23.Text[1]));
                button23.BackColor = Color.LightGray;
                button24.Enabled = true;
                button24.PerformClick();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button24.Text[0]), getY(button24.Text[1])))
            {
                bookSeat(seats, getX(button24.Text[0]), getY(button24.Text[1]));
                button24.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button24.Text[0]), getY(button24.Text[1])))
            {
                unbookSeat(seats, getX(button24.Text[0]), getY(button24.Text[1]));
                button24.BackColor = Color.LightGray;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button25.Text[0]), getY(button25.Text[1])))
            {
                bookSeat(seats, getX(button25.Text[0]), getY(button25.Text[1]));
                button25.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button25.Text[0]), getY(button25.Text[1])))
            {
                unbookSeat(seats, getX(button25.Text[0]), getY(button25.Text[1]));
                button25.BackColor = Color.LightGray;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button26.Text[0]), getY(button26.Text[1])))
            {
                bookSeat(seats, getX(button26.Text[0]), getY(button26.Text[1]));
                button26.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button26.Text[0]), getY(button26.Text[1])))
            {
                unbookSeat(seats, getX(button26.Text[0]), getY(button26.Text[1]));
                button26.BackColor = Color.LightGray;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button41.Text[0]), getY(button41.Text[1])))
            {
                bookSeat(seats, getX(button41.Text[0]), getY(button41.Text[1]));
                button41.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button41.Text[0]), getY(button41.Text[1])))
            {
                unbookSeat(seats, getX(button41.Text[0]), getY(button41.Text[1]));
                button41.BackColor = Color.LightGray;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button42.Text[0]), getY(button42.Text[1])))
            {
                bookSeat(seats, getX(button42.Text[0]), getY(button42.Text[1]));
                button42.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button42.Text[0]), getY(button42.Text[1])))
            {
                unbookSeat(seats, getX(button42.Text[0]), getY(button42.Text[1]));
                button42.BackColor = Color.LightGray;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button43.Text[0]), getY(button43.Text[1])))
            {
                bookSeat(seats, getX(button43.Text[0]), getY(button43.Text[1]));
                button43.BackColor = Color.Red;
                button44.PerformClick();
                button44.Enabled = false;
            }
            else if (confirmUnbook(seats, getX(button43.Text[0]), getY(button43.Text[1])))
            {
                unbookSeat(seats, getX(button43.Text[0]), getY(button43.Text[1]));
                button43.BackColor = Color.LightGray;
                button44.Enabled = true;
                button44.PerformClick();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button44.Text[0]), getY(button44.Text[1])))
            {
                bookSeat(seats, getX(button44.Text[0]), getY(button44.Text[1]));
                button44.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button44.Text[0]), getY(button44.Text[1])))
            {
                unbookSeat(seats, getX(button44.Text[0]), getY(button44.Text[1]));
                button44.BackColor = Color.LightGray;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button45.Text[0]), getY(button45.Text[1])))
            {
                bookSeat(seats, getX(button45.Text[0]), getY(button45.Text[1]));
                button45.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button45.Text[0]), getY(button45.Text[1])))
            {
                unbookSeat(seats, getX(button45.Text[0]), getY(button45.Text[1]));
                button45.BackColor = Color.LightGray;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (!isSeatBooked(seats, getX(button46.Text[0]), getY(button46.Text[1])))
            {
                bookSeat(seats, getX(button46.Text[0]), getY(button46.Text[1]));
                button46.BackColor = Color.Red;
            }
            else if (confirmUnbook(seats, getX(button46.Text[0]), getY(button46.Text[1])))
            {
                unbookSeat(seats, getX(button46.Text[0]), getY(button46.Text[1]));
                button46.BackColor = Color.LightGray;
            }
        }
    }
}
