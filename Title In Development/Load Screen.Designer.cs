namespace Title_In_Development
{
    partial class Load_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_Screen));
            this.LBIgnore = new System.Windows.Forms.Label();
            this.TBStartDebug = new System.Windows.Forms.TextBox();
            this.TMWait = new System.Windows.Forms.Timer(this.components);
            this.TMGraphic = new System.Windows.Forms.Timer(this.components);
            this.PLoadingGraphic = new System.Windows.Forms.Panel();
            this.LBLoadingGraphic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBIgnore
            // 
            this.LBIgnore.AutoSize = true;
            this.LBIgnore.Enabled = false;
            this.LBIgnore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBIgnore.Location = new System.Drawing.Point(250, 57);
            this.LBIgnore.Name = "LBIgnore";
            this.LBIgnore.Size = new System.Drawing.Size(37, 13);
            this.LBIgnore.TabIndex = 1;
            this.LBIgnore.Text = "Ignore";
            // 
            // TBStartDebug
            // 
            this.TBStartDebug.BackColor = System.Drawing.SystemColors.WindowText;
            this.TBStartDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBStartDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStartDebug.ForeColor = System.Drawing.Color.LimeGreen;
            this.TBStartDebug.Location = new System.Drawing.Point(0, 120);
            this.TBStartDebug.Multiline = true;
            this.TBStartDebug.Name = "TBStartDebug";
            this.TBStartDebug.ReadOnly = true;
            this.TBStartDebug.Size = new System.Drawing.Size(520, 280);
            this.TBStartDebug.TabIndex = 2;
            this.TBStartDebug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBStartDebug.Click += new System.EventHandler(this.Click);
            // 
            // TMWait
            // 
            this.TMWait.Interval = 2500;
            this.TMWait.Tick += new System.EventHandler(this.Wait);
            // 
            // TMGraphic
            // 
            this.TMGraphic.Interval = 1;
            this.TMGraphic.Tick += new System.EventHandler(this.Graphic);
            // 
            // PLoadingGraphic
            // 
            this.PLoadingGraphic.BackColor = System.Drawing.Color.Transparent;
            this.PLoadingGraphic.Enabled = false;
            this.PLoadingGraphic.Location = new System.Drawing.Point(0, 248);
            this.PLoadingGraphic.Name = "PLoadingGraphic";
            this.PLoadingGraphic.Size = new System.Drawing.Size(520, 24);
            this.PLoadingGraphic.TabIndex = 4;
            this.PLoadingGraphic.Paint += new System.Windows.Forms.PaintEventHandler(this.Loading_Graphic);
            // 
            // LBLoadingGraphic
            // 
            this.LBLoadingGraphic.BackColor = System.Drawing.Color.Transparent;
            this.LBLoadingGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLoadingGraphic.ForeColor = System.Drawing.Color.White;
            this.LBLoadingGraphic.Location = new System.Drawing.Point(210, 222);
            this.LBLoadingGraphic.Name = "LBLoadingGraphic";
            this.LBLoadingGraphic.Size = new System.Drawing.Size(100, 24);
            this.LBLoadingGraphic.TabIndex = 5;
            this.LBLoadingGraphic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLoadingGraphic.Paint += new System.Windows.Forms.PaintEventHandler(this.Loading_Text_Graphic);
            // 
            // Load_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(520, 520);
            this.Controls.Add(this.LBLoadingGraphic);
            this.Controls.Add(this.PLoadingGraphic);
            this.Controls.Add(this.LBIgnore);
            this.Controls.Add(this.TBStartDebug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Screen";
            this.Load += new System.EventHandler(this.Load_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBIgnore;
        private System.Windows.Forms.TextBox TBStartDebug;
        private System.Windows.Forms.Timer TMWait;
        private System.Windows.Forms.Timer TMGraphic;
        private System.Windows.Forms.Panel PLoadingGraphic;
        private System.Windows.Forms.Label LBLoadingGraphic;
    }
}

