namespace RealEstateManagement_Ahmed
{
    partial class Start_Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Heading_1 = new Label();
            buy_button = new Button();
            sell_button = new Button();
            label2 = new Label();
            Status_btn = new Button();
            SuspendLayout();
            // 
            // Heading_1
            // 
            Heading_1.AutoSize = true;
            Heading_1.BackColor = SystemColors.ActiveCaption;
            Heading_1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Heading_1.Location = new Point(29, 67);
            Heading_1.Name = "Heading_1";
            Heading_1.Size = new Size(759, 41);
            Heading_1.TabIndex = 0;
            Heading_1.Text = "Welcome to the Real Estate Management System";
            // 
            // buy_button
            // 
            buy_button.Location = new Point(112, 200);
            buy_button.Name = "buy_button";
            buy_button.Size = new Size(172, 141);
            buy_button.TabIndex = 1;
            buy_button.Text = "BUY";
            buy_button.UseVisualStyleBackColor = true;
            buy_button.Click += buy_button_Click;
            // 
            // sell_button
            // 
            sell_button.Location = new Point(527, 200);
            sell_button.Name = "sell_button";
            sell_button.Size = new Size(172, 141);
            sell_button.TabIndex = 2;
            sell_button.Text = "SELL";
            sell_button.UseVisualStyleBackColor = true;
            sell_button.Click += sell_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(259, 136);
            label2.Name = "label2";
            label2.Size = new Size(287, 25);
            label2.TabIndex = 7;
            label2.Text = "Please Select The Preferred Option:";
            // 
            // Status_btn
            // 
            Status_btn.Location = new Point(320, 200);
            Status_btn.Name = "Status_btn";
            Status_btn.Size = new Size(172, 141);
            Status_btn.TabIndex = 8;
            Status_btn.Text = "STATUS";
            Status_btn.UseVisualStyleBackColor = true;
            Status_btn.Click += Status_btn_Click;
            // 
            // Start_Screen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(Status_btn);
            Controls.Add(label2);
            Controls.Add(sell_button);
            Controls.Add(buy_button);
            Controls.Add(Heading_1);
            Name = "Start_Screen";
            Text = "REMS v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Heading_1;
        private Button buy_button;
        private Button sell_button;
        private Label label2;
        private Button Status_btn;
    }
}
