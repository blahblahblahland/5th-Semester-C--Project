namespace RealEstateManagement_Ahmed
{
    partial class status_screen
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sbnbox = new TextBox();
            sbibox = new TextBox();
            sblbox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            bookedgridview = new DataGridView();
            availablegridview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bookedgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availablegridview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Search by Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 123);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Search by PID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 236);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 2;
            label3.Text = "Search by Location:";
            // 
            // sbnbox
            // 
            sbnbox.Location = new Point(2, 37);
            sbnbox.Name = "sbnbox";
            sbnbox.Size = new Size(150, 31);
            sbnbox.TabIndex = 3;
            // 
            // sbibox
            // 
            sbibox.Location = new Point(2, 151);
            sbibox.Name = "sbibox";
            sbibox.Size = new Size(150, 31);
            sbibox.TabIndex = 4;
            // 
            // sblbox
            // 
            sblbox.Location = new Point(2, 264);
            sblbox.Name = "sblbox";
            sblbox.Size = new Size(150, 31);
            sblbox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(21, 74);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 188);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(21, 301);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 8;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(7, 368);
            button4.Name = "button4";
            button4.Size = new Size(156, 53);
            button4.TabIndex = 9;
            button4.Text = "Display All";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(214, 9);
            label4.Name = "label4";
            label4.Size = new Size(330, 48);
            label4.TabIndex = 10;
            label4.Text = "Booked Properties";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(214, 223);
            label5.Name = "label5";
            label5.Size = new Size(355, 48);
            label5.TabIndex = 11;
            label5.Text = "Available Properties";
            // 
            // bookedgridview
            // 
            bookedgridview.AllowUserToAddRows = false;
            bookedgridview.AllowUserToDeleteRows = false;
            bookedgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookedgridview.Location = new Point(214, 60);
            bookedgridview.Name = "bookedgridview";
            bookedgridview.ReadOnly = true;
            bookedgridview.RowHeadersWidth = 62;
            bookedgridview.Size = new Size(574, 164);
            bookedgridview.TabIndex = 12;
            // 
            // availablegridview
            // 
            availablegridview.AllowUserToAddRows = false;
            availablegridview.AllowUserToDeleteRows = false;
            availablegridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availablegridview.Location = new Point(214, 274);
            availablegridview.Name = "availablegridview";
            availablegridview.ReadOnly = true;
            availablegridview.RowHeadersWidth = 62;
            availablegridview.Size = new Size(574, 164);
            availablegridview.TabIndex = 13;
            // 
            // status_screen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(availablegridview);
            Controls.Add(bookedgridview);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sblbox);
            Controls.Add(sbibox);
            Controls.Add(sbnbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "status_screen";
            Text = "REMS v1.0";
            ((System.ComponentModel.ISupportInitialize)bookedgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)availablegridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox sbnbox;
        private TextBox sbibox;
        private TextBox sblbox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label5;
        private DataGridView bookedgridview;
        private DataGridView availablegridview;
    }
}