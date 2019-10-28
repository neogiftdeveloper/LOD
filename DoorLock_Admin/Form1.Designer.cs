namespace DoorLock_Admin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.OpenDoor_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoorStateDisplay_Label = new System.Windows.Forms.Label();
            this.CloseDoor_Button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataFetcher_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minimize_Button);
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 28);
            this.panel1.TabIndex = 0;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.ForeColor = System.Drawing.Color.Gray;
            this.Minimize_Button.Location = new System.Drawing.Point(720, 0);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(62, 28);
            this.Minimize_Button.TabIndex = 1;
            this.Minimize_Button.Text = "____";
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.ForeColor = System.Drawing.Color.Gray;
            this.Close_Button.Location = new System.Drawing.Point(782, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(56, 28);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.Text = "X";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // OpenDoor_Button
            // 
            this.OpenDoor_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenDoor_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDoor_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDoor_Button.ForeColor = System.Drawing.Color.Red;
            this.OpenDoor_Button.Location = new System.Drawing.Point(0, 0);
            this.OpenDoor_Button.Name = "OpenDoor_Button";
            this.OpenDoor_Button.Size = new System.Drawing.Size(425, 347);
            this.OpenDoor_Button.TabIndex = 2;
            this.OpenDoor_Button.Text = "OPEN";
            this.OpenDoor_Button.UseVisualStyleBackColor = true;
            this.OpenDoor_Button.Click += new System.EventHandler(this.OpenDoor_Button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DoorStateDisplay_Label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 75);
            this.panel2.TabIndex = 3;
            // 
            // DoorStateDisplay_Label
            // 
            this.DoorStateDisplay_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoorStateDisplay_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorStateDisplay_Label.ForeColor = System.Drawing.Color.Gray;
            this.DoorStateDisplay_Label.Location = new System.Drawing.Point(0, 0);
            this.DoorStateDisplay_Label.Name = "DoorStateDisplay_Label";
            this.DoorStateDisplay_Label.Size = new System.Drawing.Size(838, 75);
            this.DoorStateDisplay_Label.TabIndex = 0;
            this.DoorStateDisplay_Label.Text = "Door Is  --->  Open";
            this.DoorStateDisplay_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseDoor_Button
            // 
            this.CloseDoor_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseDoor_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseDoor_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseDoor_Button.ForeColor = System.Drawing.Color.Green;
            this.CloseDoor_Button.Location = new System.Drawing.Point(0, 0);
            this.CloseDoor_Button.Name = "CloseDoor_Button";
            this.CloseDoor_Button.Size = new System.Drawing.Size(413, 347);
            this.CloseDoor_Button.TabIndex = 4;
            this.CloseDoor_Button.Text = "CLOSE";
            this.CloseDoor_Button.UseVisualStyleBackColor = true;
            this.CloseDoor_Button.Click += new System.EventHandler(this.CloseDoor_Button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.OpenDoor_Button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 347);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CloseDoor_Button);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(425, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 347);
            this.panel4.TabIndex = 6;
            // 
            // DataFetcher_Timer
            // 
            this.DataFetcher_Timer.Enabled = true;
            this.DataFetcher_Timer.Interval = 2000;
            this.DataFetcher_Timer.Tick += new System.EventHandler(this.DataFetcher_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button OpenDoor_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DoorStateDisplay_Label;
        private System.Windows.Forms.Button CloseDoor_Button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer DataFetcher_Timer;
    }
}

