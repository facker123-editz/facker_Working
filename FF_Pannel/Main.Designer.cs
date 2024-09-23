namespace FF_Pannel
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Expiry = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Key = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.hook = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Cyan;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Expiry
            // 
            this.Expiry.BackColor = System.Drawing.Color.Transparent;
            this.Expiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expiry.ForeColor = System.Drawing.Color.MintCream;
            this.Expiry.Location = new System.Drawing.Point(12, 53);
            this.Expiry.Name = "Expiry";
            this.Expiry.Size = new System.Drawing.Size(43, 18);
            this.Expiry.TabIndex = 2;
            this.Expiry.Text = "Expiry:";
            // 
            // Key
            // 
            this.Key.BackColor = System.Drawing.Color.Transparent;
            this.Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key.ForeColor = System.Drawing.Color.MintCream;
            this.Key.Location = new System.Drawing.Point(12, 29);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(69, 18);
            this.Key.TabIndex = 3;
            this.Key.Text = "Username:";
            // 
            // IP
            // 
            this.IP.BackColor = System.Drawing.Color.Transparent;
            this.IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.ForeColor = System.Drawing.Color.MintCream;
            this.IP.Location = new System.Drawing.Point(12, 77);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(18, 18);
            this.IP.TabIndex = 2;
            this.IP.Text = "IP:";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.MintCream;
            this.status.Location = new System.Drawing.Point(12, 101);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(43, 18);
            this.status.TabIndex = 2;
            this.status.Text = "Status:";
            this.status.Click += new System.EventHandler(this.guna2HtmlLabel1_Click_1);
            // 
            // hook
            // 
            this.hook.BackColor = System.Drawing.Color.Transparent;
            this.hook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hook.ForeColor = System.Drawing.Color.MintCream;
            this.hook.Location = new System.Drawing.Point(12, 125);
            this.hook.Name = "hook";
            this.hook.Size = new System.Drawing.Size(28, 18);
            this.hook.TabIndex = 4;
            this.hook.Text = "PID:";
            // 
            // exit
            // 
            this.exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(426, 12);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit.Size = new System.Drawing.Size(18, 19);
            this.exit.TabIndex = 5;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Aimbot";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(-15, -15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 220);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(468, 546);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.hook);
            this.Controls.Add(this.status);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.Expiry);
            this.Controls.Add(this.Key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Expiry;
        private Guna.UI2.WinForms.Guna2HtmlLabel Key;
        private Guna.UI2.WinForms.Guna2HtmlLabel IP;
        private Guna.UI2.WinForms.Guna2HtmlLabel status;
        private Guna.UI2.WinForms.Guna2HtmlLabel hook;
        private Guna.UI2.WinForms.Guna2CircleButton exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}