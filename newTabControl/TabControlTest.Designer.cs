namespace newTabControl
{
    partial class TabControlTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControlTest));
            this.button1 = new System.Windows.Forms.Button();
            this.msaTabControl1 = new newTabControl.MSATabControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD TAB MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msaTabControl1
            // 
            this.msaTabControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("msaTabControl1.BackgroundImage")));
            this.msaTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msaTabControl1.Location = new System.Drawing.Point(0, 0);
            this.msaTabControl1.Name = "msaTabControl1";
            this.msaTabControl1.SelectedPage = null;
            this.msaTabControl1.Size = new System.Drawing.Size(454, 251);
            this.msaTabControl1.TabIndex = 1;
            this.msaTabControl1.Text = "msaTabControl1";
            // 
            // TabControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msaTabControl1);
            this.Name = "TabControlTest";
            this.Text = "Tab Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MSATabControl msaTabControl1;
    }
}

