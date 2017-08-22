namespace Movie_Ticketing.Forms
{
    partial class FrChooseMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGVSchedule = new System.Windows.Forms.DataGridView();
            this.Studio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbxTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Now Playing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVSchedule
            // 
            this.DGVSchedule.AllowUserToAddRows = false;
            this.DGVSchedule.AllowUserToDeleteRows = false;
            this.DGVSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Studio,
            this.Title,
            this.Time1,
            this.Time2,
            this.Time3,
            this.Time4,
            this.Time5});
            this.DGVSchedule.Location = new System.Drawing.Point(12, 80);
            this.DGVSchedule.Name = "DGVSchedule";
            this.DGVSchedule.ReadOnly = true;
            this.DGVSchedule.Size = new System.Drawing.Size(753, 238);
            this.DGVSchedule.TabIndex = 1;
            this.DGVSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSchedule_CellContentClick);
            // 
            // Studio
            // 
            this.Studio.HeaderText = "Studio";
            this.Studio.Name = "Studio";
            this.Studio.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Time1
            // 
            this.Time1.HeaderText = "Time1";
            this.Time1.Name = "Time1";
            this.Time1.ReadOnly = true;
            // 
            // Time2
            // 
            this.Time2.HeaderText = "Time2";
            this.Time2.Name = "Time2";
            this.Time2.ReadOnly = true;
            // 
            // Time3
            // 
            this.Time3.HeaderText = "Time3";
            this.Time3.Name = "Time3";
            this.Time3.ReadOnly = true;
            // 
            // Time4
            // 
            this.Time4.HeaderText = "Time4";
            this.Time4.Name = "Time4";
            this.Time4.ReadOnly = true;
            // 
            // Time5
            // 
            this.Time5.HeaderText = "Time5";
            this.Time5.Name = "Time5";
            this.Time5.ReadOnly = true;
            // 
            // TbxTicket
            // 
            this.TbxTicket.Location = new System.Drawing.Point(362, 336);
            this.TbxTicket.Name = "TbxTicket";
            this.TbxTicket.Size = new System.Drawing.Size(146, 23);
            this.TbxTicket.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Ticket";
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.Location = new System.Drawing.Point(277, 365);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(231, 38);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = "NEXT";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // FrChooseMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 422);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxTicket);
            this.Controls.Add(this.DGVSchedule);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrChooseMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Ticketing";
            this.Load += new System.EventHandler(this.FrChooseMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVSchedule;
        private System.Windows.Forms.TextBox TbxTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time5;
    }
}