namespace MinimalTaskbar
{
    partial class Form1
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
            this.cmdStart = new System.Windows.Forms.Button();
            this.explorerKill = new System.Windows.Forms.Button();
            this.explorerStart = new System.Windows.Forms.Button();
            this.taskmgrStart = new System.Windows.Forms.Button();
            this.shutDown = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.BackColor = System.Drawing.SystemColors.ControlText;
            this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdStart.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdStart.Location = new System.Drawing.Point(12, 12);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(39, 22);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "cmd";
            this.cmdStart.UseVisualStyleBackColor = false;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // explorerKill
            // 
            this.explorerKill.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.explorerKill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.explorerKill.Location = new System.Drawing.Point(120, 12);
            this.explorerKill.Name = "explorerKill";
            this.explorerKill.Size = new System.Drawing.Size(29, 22);
            this.explorerKill.TabIndex = 1;
            this.explorerKill.Text = "kill";
            this.explorerKill.UseVisualStyleBackColor = false;
            this.explorerKill.Click += new System.EventHandler(this.explorerKill_Click);
            // 
            // explorerStart
            // 
            this.explorerStart.BackColor = System.Drawing.Color.LemonChiffon;
            this.explorerStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.explorerStart.Location = new System.Drawing.Point(66, 12);
            this.explorerStart.Name = "explorerStart";
            this.explorerStart.Size = new System.Drawing.Size(55, 22);
            this.explorerStart.TabIndex = 2;
            this.explorerStart.Text = "explorer";
            this.explorerStart.UseVisualStyleBackColor = false;
            this.explorerStart.Click += new System.EventHandler(this.explorerStart_Click);
            // 
            // taskmgrStart
            // 
            this.taskmgrStart.BackColor = System.Drawing.Color.DarkTurquoise;
            this.taskmgrStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskmgrStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taskmgrStart.Location = new System.Drawing.Point(166, 12);
            this.taskmgrStart.Name = "taskmgrStart";
            this.taskmgrStart.Size = new System.Drawing.Size(63, 22);
            this.taskmgrStart.TabIndex = 3;
            this.taskmgrStart.Text = "taskmgr";
            this.taskmgrStart.UseVisualStyleBackColor = false;
            this.taskmgrStart.Click += new System.EventHandler(this.taskmgrStart_Click);
            // 
            // shutDown
            // 
            this.shutDown.BackColor = System.Drawing.Color.Red;
            this.shutDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.shutDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shutDown.ForeColor = System.Drawing.Color.White;
            this.shutDown.Location = new System.Drawing.Point(300, 12);
            this.shutDown.Name = "shutDown";
            this.shutDown.Size = new System.Drawing.Size(84, 23);
            this.shutDown.TabIndex = 5;
            this.shutDown.Text = "shutdown";
            this.shutDown.UseVisualStyleBackColor = false;
            this.shutDown.Click += new System.EventHandler(this.shutDown_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart.ForeColor = System.Drawing.Color.White;
            this.restart.Location = new System.Drawing.Point(244, 12);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(57, 23);
            this.restart.TabIndex = 6;
            this.restart.Text = "restart";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 47);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.shutDown);
            this.Controls.Add(this.explorerStart);
            this.Controls.Add(this.taskmgrStart);
            this.Controls.Add(this.explorerKill);
            this.Controls.Add(this.cmdStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Minimal Taskbar";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button explorerKill;
        private System.Windows.Forms.Button explorerStart;
        private System.Windows.Forms.Button taskmgrStart;
        private System.Windows.Forms.Button shutDown;
        private System.Windows.Forms.Button restart;
    }
}

