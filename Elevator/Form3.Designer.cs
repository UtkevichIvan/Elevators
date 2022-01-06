
namespace Elevator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDeliveredEach = new System.Windows.Forms.Label();
            this.labelDelivered = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of people in each lift :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of people : ";
            // 
            // labelDeliveredEach
            // 
            this.labelDeliveredEach.AutoSize = true;
            this.labelDeliveredEach.Location = new System.Drawing.Point(269, 18);
            this.labelDeliveredEach.Name = "labelDeliveredEach";
            this.labelDeliveredEach.Size = new System.Drawing.Size(0, 20);
            this.labelDeliveredEach.TabIndex = 19;
            // 
            // labelDelivered
            // 
            this.labelDelivered.AutoSize = true;
            this.labelDelivered.Location = new System.Drawing.Point(184, 65);
            this.labelDelivered.Name = "labelDelivered";
            this.labelDelivered.Size = new System.Drawing.Size(58, 20);
            this.labelDelivered.TabIndex = 20;
            this.labelDelivered.Text = "label13";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(160, 99);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(50, 20);
            this.labelTime.TabIndex = 22;
            this.labelTime.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Time simulation : ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDelivered);
            this.Controls.Add(this.labelDeliveredEach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDeliveredEach;
        private System.Windows.Forms.Label labelDelivered;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label5;
    }
}