
namespace Elevator
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.comboBoxStrategy = new System.Windows.Forms.ComboBox();
            this.textBoxAvrpeople = new System.Windows.Forms.TextBox();
            this.textBoxElevators = new System.Windows.Forms.TextBox();
            this.textBoxFloors = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.labelAvrpeople = new System.Windows.Forms.Label();
            this.labelElevators = new System.Windows.Forms.Label();
            this.labelFloors = new System.Windows.Forms.Label();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(114, 360);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(532, 76);
            this.textBoxFile.Multiline = true;
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFile.Size = new System.Drawing.Size(148, 183);
            this.textBoxFile.TabIndex = 1;
            // 
            // labelFile
            // 
            this.labelFile.Location = new System.Drawing.Point(545, 45);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(122, 28);
            this.labelFile.TabIndex = 2;
            this.labelFile.Text = "Generation rules";
            // 
            // comboBoxStrategy
            // 
            this.comboBoxStrategy.FormattingEnabled = true;
            this.comboBoxStrategy.Location = new System.Drawing.Point(30, 45);
            this.comboBoxStrategy.Name = "comboBoxStrategy";
            this.comboBoxStrategy.Size = new System.Drawing.Size(269, 28);
            this.comboBoxStrategy.TabIndex = 3;
            // 
            // textBoxAvrpeople
            // 
            this.textBoxAvrpeople.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAvrpeople.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAvrpeople.Location = new System.Drawing.Point(96, 111);
            this.textBoxAvrpeople.Name = "textBoxAvrpeople";
            this.textBoxAvrpeople.Size = new System.Drawing.Size(125, 27);
            this.textBoxAvrpeople.TabIndex = 4;
            // 
            // textBoxElevators
            // 
            this.textBoxElevators.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxElevators.Location = new System.Drawing.Point(96, 173);
            this.textBoxElevators.Name = "textBoxElevators";
            this.textBoxElevators.Size = new System.Drawing.Size(125, 27);
            this.textBoxElevators.TabIndex = 5;
            this.textBoxElevators.TextChanged += new System.EventHandler(this.textBoxElevators_TextChanged);
            // 
            // textBoxFloors
            // 
            this.textBoxFloors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFloors.Location = new System.Drawing.Point(96, 232);
            this.textBoxFloors.Name = "textBoxFloors";
            this.textBoxFloors.Size = new System.Drawing.Size(125, 27);
            this.textBoxFloors.TabIndex = 6;
            this.textBoxFloors.TextChanged += new System.EventHandler(this.textBoxFloors_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(48, 274);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(171, 274);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(94, 29);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(493, 273);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(94, 29);
            this.buttonSaveFile.TabIndex = 9;
            this.buttonSaveFile.Text = "Save";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // labelAvrpeople
            // 
            this.labelAvrpeople.AutoSize = true;
            this.labelAvrpeople.Location = new System.Drawing.Point(67, 88);
            this.labelAvrpeople.Name = "labelAvrpeople";
            this.labelAvrpeople.Size = new System.Drawing.Size(189, 20);
            this.labelAvrpeople.TabIndex = 11;
            this.labelAvrpeople.Text = "Average People per minute";
            // 
            // labelElevators
            // 
            this.labelElevators.AutoSize = true;
            this.labelElevators.Location = new System.Drawing.Point(87, 150);
            this.labelElevators.Name = "labelElevators";
            this.labelElevators.Size = new System.Drawing.Size(145, 20);
            this.labelElevators.TabIndex = 12;
            this.labelElevators.Text = "Number of elevators";
            // 
            // labelFloors
            // 
            this.labelFloors.AutoSize = true;
            this.labelFloors.Location = new System.Drawing.Point(96, 209);
            this.labelFloors.Name = "labelFloors";
            this.labelFloors.Size = new System.Drawing.Size(127, 20);
            this.labelFloors.TabIndex = 13;
            this.labelFloors.Text = "Number od floors";
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(613, 273);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(94, 29);
            this.buttonLoadFile.TabIndex = 14;
            this.buttonLoadFile.Text = "Load";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.labelFloors);
            this.Controls.Add(this.labelElevators);
            this.Controls.Add(this.labelAvrpeople);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFloors);
            this.Controls.Add(this.textBoxElevators);
            this.Controls.Add(this.textBoxAvrpeople);
            this.Controls.Add(this.comboBoxStrategy);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.ComboBox comboBoxStrategy;
        private System.Windows.Forms.TextBox textBoxAvrpeople;
        private System.Windows.Forms.TextBox textBoxElevators;
        private System.Windows.Forms.TextBox textBoxFloors;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Label labelAvrpeople;
        private System.Windows.Forms.Label labelElevators;
        private System.Windows.Forms.Label labelFloors;
        private System.Windows.Forms.Button buttonLoadFile;
    }
}

