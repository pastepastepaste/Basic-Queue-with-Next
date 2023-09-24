namespace BasicQueue
{
    partial class Form3
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
            nxtQueue = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 0;
            label1.Text = "*Now Serving";
            // 
            // nxtQueue
            // 
            nxtQueue.AutoSize = true;
            nxtQueue.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nxtQueue.Location = new Point(190, 111);
            nxtQueue.Name = "nxtQueue";
            nxtQueue.Size = new Size(62, 23);
            nxtQueue.TabIndex = 1;
            nxtQueue.Text = "label2";
            nxtQueue.Click += nxtQueue_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 214, 173);
            ClientSize = new Size(422, 210);
            Controls.Add(nxtQueue);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nxtQueue;
    }
}