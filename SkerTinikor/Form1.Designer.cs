namespace SkerTinikor
{
    partial class mainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScreen = new System.Windows.Forms.Label();
            this.dgvSeats = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.Location = new System.Drawing.Point(439, 9);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(100, 31);
            this.lblScreen.TabIndex = 0;
            this.lblScreen.Text = "Screen";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSeats
            // 
            this.dgvSeats.AllowUserToAddRows = false;
            this.dgvSeats.AllowUserToDeleteRows = false;
            this.dgvSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E,
            this.F,
            this.G,
            this.H,
            this.I});
            this.dgvSeats.Location = new System.Drawing.Point(12, 43);
            this.dgvSeats.Name = "dgvSeats";
            this.dgvSeats.Size = new System.Drawing.Size(944, 395);
            this.dgvSeats.TabIndex = 1;
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // E
            // 
            this.E.HeaderText = "E";
            this.E.Name = "E";
            this.E.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // F
            // 
            this.F.HeaderText = "F";
            this.F.Name = "F";
            this.F.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // G
            // 
            this.G.HeaderText = "G";
            this.G.Name = "G";
            this.G.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // H
            // 
            this.H.HeaderText = "H";
            this.H.Name = "H";
            this.H.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // I
            // 
            this.I.HeaderText = "I";
            this.I.Name = "I";
            this.I.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.dgvSeats);
            this.Controls.Add(this.lblScreen);
            this.Name = "mainScreen";
            this.Text = "Book a seat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.DataGridView dgvSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn I;
    }
}

