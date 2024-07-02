namespace RealEstateManagement_Ahmed
{
    partial class sell_screen
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
            addBtn = new Button();
            typeboxadd = new TextBox();
            nameboxadd = new TextBox();
            locationboxadd = new TextBox();
            numberboxadd = new TextBox();
            priceboxadd = new TextBox();
            idboxadd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(163, 396);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(289, 42);
            addBtn.TabIndex = 0;
            addBtn.Text = "Click here to list Property";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // typeboxadd
            // 
            typeboxadd.Location = new Point(38, 102);
            typeboxadd.Name = "typeboxadd";
            typeboxadd.Size = new Size(173, 31);
            typeboxadd.TabIndex = 1;
            // 
            // nameboxadd
            // 
            nameboxadd.Location = new Point(398, 102);
            nameboxadd.Name = "nameboxadd";
            nameboxadd.Size = new Size(173, 31);
            nameboxadd.TabIndex = 2;
            // 
            // locationboxadd
            // 
            locationboxadd.Location = new Point(38, 172);
            locationboxadd.Name = "locationboxadd";
            locationboxadd.Size = new Size(173, 31);
            locationboxadd.TabIndex = 3;
            // 
            // numberboxadd
            // 
            numberboxadd.Location = new Point(398, 172);
            numberboxadd.Name = "numberboxadd";
            numberboxadd.Size = new Size(173, 31);
            numberboxadd.TabIndex = 4;
            // 
            // priceboxadd
            // 
            priceboxadd.Location = new Point(38, 238);
            priceboxadd.Name = "priceboxadd";
            priceboxadd.Size = new Size(173, 31);
            priceboxadd.TabIndex = 5;
            // 
            // idboxadd
            // 
            idboxadd.Location = new Point(398, 238);
            idboxadd.Name = "idboxadd";
            idboxadd.Size = new Size(173, 31);
            idboxadd.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 70);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 7;
            label1.Text = "Type of Property";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 144);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 8;
            label2.Text = "Location Of Property";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 210);
            label3.Name = "label3";
            label3.Size = new Size(206, 25);
            label3.TabIndex = 9;
            label3.Text = "Asking Price Of Property";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 74);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 10;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 144);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 11;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 210);
            label6.Name = "label6";
            label6.Size = new Size(177, 25);
            label6.TabIndex = 12;
            label6.Text = "Property ID (5 digits)";
            // 
            // sell_screen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(641, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idboxadd);
            Controls.Add(priceboxadd);
            Controls.Add(numberboxadd);
            Controls.Add(locationboxadd);
            Controls.Add(nameboxadd);
            Controls.Add(typeboxadd);
            Controls.Add(addBtn);
            Name = "sell_screen";
            Text = "REMS v1.0 (SELL)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private TextBox typeboxadd;
        private TextBox nameboxadd;
        private TextBox locationboxadd;
        private TextBox numberboxadd;
        private TextBox priceboxadd;
        private TextBox idboxadd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}