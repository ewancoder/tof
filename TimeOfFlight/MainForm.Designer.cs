﻿namespace TimeOfFlight
{
    partial class MainForm
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
            this.inputPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.boxMonitor = new System.Windows.Forms.RichTextBox();
            this.timerMonitor = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // inputPort
            // 
            this.inputPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPort.Location = new System.Drawing.Point(0, 0);
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(784, 20);
            this.inputPort.TabIndex = 0;
            this.inputPort.Text = "COM1";
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnect.Location = new System.Drawing.Point(0, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(784, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // boxMonitor
            // 
            this.boxMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxMonitor.Location = new System.Drawing.Point(0, 43);
            this.boxMonitor.Name = "boxMonitor";
            this.boxMonitor.ReadOnly = true;
            this.boxMonitor.Size = new System.Drawing.Size(784, 519);
            this.boxMonitor.TabIndex = 2;
            this.boxMonitor.Text = "";
            // 
            // timerMonitor
            // 
            this.timerMonitor.Enabled = true;
            this.timerMonitor.Tick += new System.EventHandler(this.timerMonitor_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.boxMonitor);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.inputPort);
            this.Name = "MainForm";
            this.Text = "Time of Flight model";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox boxMonitor;
        private System.Windows.Forms.Timer timerMonitor;
    }
}

