namespace BasicQueuingCashier
{
    partial class Form2
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
            this.Queue1 = new System.Windows.Forms.Label();
            this.RunQueue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Queue1
            // 
            this.Queue1.AutoSize = true;
            this.Queue1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Queue1.Location = new System.Drawing.Point(52, 35);
            this.Queue1.Name = "Queue1";
            this.Queue1.Size = new System.Drawing.Size(156, 27);
            this.Queue1.TabIndex = 0;
            this.Queue1.Text = "*Now Serving";
            // 
            // RunQueue
            // 
            this.RunQueue.AutoSize = true;
            this.RunQueue.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunQueue.Location = new System.Drawing.Point(148, 105);
            this.RunQueue.Name = "RunQueue";
            this.RunQueue.Size = new System.Drawing.Size(164, 41);
            this.RunQueue.TabIndex = 1;
            this.RunQueue.Text = "P - 10001";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(350, 263);
            this.Controls.Add(this.RunQueue);
            this.Controls.Add(this.Queue1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Queue1;
        private System.Windows.Forms.Label lblRunQueue;
    }
}