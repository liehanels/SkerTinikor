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
                unbookSeat(seats, getX(button1.Text[0]), getX(button1.Text[1]));
                button1.BackColor = Color.LightGray;
            }
        }
    }
}
