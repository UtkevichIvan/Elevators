
namespace Elevator
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
            parentForm.Visible = true;
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.textInStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSlower = new System.Windows.Forms.Button();
            this.buttonFire = new System.Windows.Forms.Button();
            this.buttonFaster = new System.Windows.Forms.Button();
            this.textBoxСurrent = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.labelСurrent = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxPerson = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerSpeed = new System.Windows.Forms.Timer(this.components);
            this.timerDelete = new System.Windows.Forms.Timer(this.components);
            this.timerSpawn = new System.Windows.Forms.Timer(this.components);
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textInStatusBar});
            this.statusBar.Location = new System.Drawing.Point(0, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1482, 26);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // textInStatusBar
            // 
            this.textInStatusBar.Name = "textInStatusBar";
            this.textInStatusBar.Size = new System.Drawing.Size(253, 20);
            this.textInStatusBar.Text = "Time since the start of the simulation";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(30, 212);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(94, 29);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSlower
            // 
            this.buttonSlower.ForeColor = System.Drawing.Color.Black;
            this.buttonSlower.Location = new System.Drawing.Point(20, 307);
            this.buttonSlower.Name = "buttonSlower";
            this.buttonSlower.Size = new System.Drawing.Size(104, 29);
            this.buttonSlower.TabIndex = 2;
            this.buttonSlower.Text = "Slower";
            this.buttonSlower.UseVisualStyleBackColor = true;
            this.buttonSlower.Click += new System.EventHandler(this.buttonSlower_Click);
            // 
            // buttonFire
            // 
            this.buttonFire.Location = new System.Drawing.Point(20, 342);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(104, 29);
            this.buttonFire.TabIndex = 3;
            this.buttonFire.Text = "Fire Alarm";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // buttonFaster
            // 
            this.buttonFaster.Location = new System.Drawing.Point(20, 272);
            this.buttonFaster.Name = "buttonFaster";
            this.buttonFaster.Size = new System.Drawing.Size(104, 29);
            this.buttonFaster.TabIndex = 4;
            this.buttonFaster.Text = "Faster";
            this.buttonFaster.UseVisualStyleBackColor = true;
            this.buttonFaster.Click += new System.EventHandler(this.buttonFaster_Click);
            // 
            // textBoxСurrent
            // 
            this.textBoxСurrent.Location = new System.Drawing.Point(16, 124);
            this.textBoxСurrent.Name = "textBoxСurrent";
            this.textBoxСurrent.Size = new System.Drawing.Size(125, 27);
            this.textBoxСurrent.TabIndex = 5;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(16, 179);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(125, 27);
            this.textBoxTarget.TabIndex = 6;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(30, 156);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(86, 20);
            this.labelTarget.TabIndex = 7;
            this.labelTarget.Text = "Target floor";
            // 
            // labelСurrent
            // 
            this.labelСurrent.AutoSize = true;
            this.labelСurrent.Location = new System.Drawing.Point(35, 101);
            this.labelСurrent.Name = "labelСurrent";
            this.labelСurrent.Size = new System.Drawing.Size(93, 20);
            this.labelСurrent.TabIndex = 8;
            this.labelСurrent.Text = "Сurrent floor";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(20, 377);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(104, 29);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(20, 662);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 29);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxPerson
            // 
            this.listBoxPerson.FormattingEnabled = true;
            this.listBoxPerson.ItemHeight = 20;
            this.listBoxPerson.Location = new System.Drawing.Point(1277, 29);
            this.listBoxPerson.Name = "listBoxPerson";
            this.listBoxPerson.Size = new System.Drawing.Size(150, 404);
            this.listBoxPerson.TabIndex = 11;
            this.listBoxPerson.SelectedIndexChanged += new System.EventHandler(this.listBoxPerson_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 14;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerSpeed
            // 
            this.timerSpeed.Tick += new System.EventHandler(this.timerSpeed_Tick);
            // 
            // timerDelete
            // 
            this.timerDelete.Interval = 5000;
            this.timerDelete.Tick += new System.EventHandler(this.timerDelete_Tick);
            // 
            // timerSpawn
            // 
            this.timerSpawn.Tick += new System.EventHandler(this.timerSpawn_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxPerson);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.labelСurrent);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.textBoxСurrent);
            this.Controls.Add(this.buttonFaster);
            this.Controls.Add(this.buttonFire);
            this.Controls.Add(this.buttonSlower);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.statusBar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel textInStatusBar;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSlower;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.Button buttonFaster;
        private System.Windows.Forms.TextBox textBoxСurrent;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Label labelСurrent;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxPerson;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timerSpeed;
        private System.Windows.Forms.Timer timerDelete;
        private System.Windows.Forms.Timer timerSpawn;
    }
}