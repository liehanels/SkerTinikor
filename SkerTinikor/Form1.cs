using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkerTinikor
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
            for (int i = 0; i < 16; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvSeats);
                for (int j = 0; j < 9; j++)
                {
                    newRow.Cells[j].Value = "Open";
                }
                dgvSeats.Rows.Add(newRow);
            }
        }
    }
}
