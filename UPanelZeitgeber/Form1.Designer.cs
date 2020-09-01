namespace UPanelZeitgeber
{
    partial class Zeitgeber
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
            this.CmdStart = new System.Windows.Forms.Button();
            this.PnlLO = new System.Windows.Forms.Panel();
            this.PnlRO = new System.Windows.Forms.Panel();
            this.PnlLU = new System.Windows.Forms.Panel();
            this.PnlRU = new System.Windows.Forms.Panel();
            this.TimPanelMove = new System.Windows.Forms.Timer(this.components);
            this.CmdReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(327, 60);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(120, 50);
            this.CmdStart.TabIndex = 0;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // PnlLO
            // 
            this.PnlLO.BackColor = System.Drawing.Color.DarkRed;
            this.PnlLO.Location = new System.Drawing.Point(357, 334);
            this.PnlLO.Name = "PnlLO";
            this.PnlLO.Size = new System.Drawing.Size(20, 20);
            this.PnlLO.TabIndex = 1;
            // 
            // PnlRO
            // 
            this.PnlRO.BackColor = System.Drawing.Color.LimeGreen;
            this.PnlRO.Location = new System.Drawing.Point(397, 334);
            this.PnlRO.Name = "PnlRO";
            this.PnlRO.Size = new System.Drawing.Size(20, 20);
            this.PnlRO.TabIndex = 2;
            // 
            // PnlLU
            // 
            this.PnlLU.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlLU.Location = new System.Drawing.Point(357, 374);
            this.PnlLU.Name = "PnlLU";
            this.PnlLU.Size = new System.Drawing.Size(20, 20);
            this.PnlLU.TabIndex = 3;
            // 
            // PnlRU
            // 
            this.PnlRU.BackColor = System.Drawing.Color.Orange;
            this.PnlRU.Location = new System.Drawing.Point(397, 374);
            this.PnlRU.Name = "PnlRU";
            this.PnlRU.Size = new System.Drawing.Size(20, 20);
            this.PnlRU.TabIndex = 4;
            // 
            // TimPanelMove
            // 
            this.TimPanelMove.Interval = 100;
            this.TimPanelMove.Tick += new System.EventHandler(this.TimPanelMove_Tick);
            // 
            // CmdReset
            // 
            this.CmdReset.Location = new System.Drawing.Point(327, 116);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(120, 50);
            this.CmdReset.TabIndex = 0;
            this.CmdReset.Text = "Reset";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // Zeitgeber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 729);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.PnlRU);
            this.Controls.Add(this.PnlLU);
            this.Controls.Add(this.PnlRO);
            this.Controls.Add(this.PnlLO);
            this.Controls.Add(this.CmdStart);
            this.Name = "Zeitgeber";
            this.Text = "Zeitgeber";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Panel PnlLO;
        private System.Windows.Forms.Panel PnlRO;
        private System.Windows.Forms.Panel PnlLU;
        private System.Windows.Forms.Panel PnlRU;
        private System.Windows.Forms.Timer TimPanelMove;
        private System.Windows.Forms.Button CmdReset;
    }
}

