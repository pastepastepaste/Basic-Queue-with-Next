namespace BasicQueue
{
    partial class QueuingForm
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
            btnCashier = new Button();
            lblQueue = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.FromArgb(217, 222, 184);
            btnCashier.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(35, 44);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(85, 77);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(210, 90);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(84, 19);
            lblQueue.TabIndex = 1;
            lblQueue.Text = " P  - 10000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(192, 44);
            label2.Name = "label2";
            label2.Size = new Size(134, 19);
            label2.TabIndex = 2;
            label2.Text = "Position in Queue";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 214, 173);
            ClientSize = new Size(393, 181);
            Controls.Add(label2);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblQueue;
        private Label label2;
    }
}