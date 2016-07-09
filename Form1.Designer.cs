namespace MIC_Membership_Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pErsonalMembershipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lifetimeMembershipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corporateMembershipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonResidentMembershipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1587, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.addToolStripMenuItem.Text = "New Member";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pErsonalMembershipsToolStripMenuItem,
            this.lifetimeMembershipsToolStripMenuItem,
            this.corporateMembershipsToolStripMenuItem,
            this.nonResidentMembershipsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // pErsonalMembershipsToolStripMenuItem
            // 
            this.pErsonalMembershipsToolStripMenuItem.Name = "pErsonalMembershipsToolStripMenuItem";
            this.pErsonalMembershipsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.pErsonalMembershipsToolStripMenuItem.Text = "Personal Memberships";
            // 
            // lifetimeMembershipsToolStripMenuItem
            // 
            this.lifetimeMembershipsToolStripMenuItem.Name = "lifetimeMembershipsToolStripMenuItem";
            this.lifetimeMembershipsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.lifetimeMembershipsToolStripMenuItem.Text = "Lifetime Memberships";
            // 
            // corporateMembershipsToolStripMenuItem
            // 
            this.corporateMembershipsToolStripMenuItem.Name = "corporateMembershipsToolStripMenuItem";
            this.corporateMembershipsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.corporateMembershipsToolStripMenuItem.Text = "Corporate Memberships";
            // 
            // nonResidentMembershipsToolStripMenuItem
            // 
            this.nonResidentMembershipsToolStripMenuItem.Name = "nonResidentMembershipsToolStripMenuItem";
            this.nonResidentMembershipsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.nonResidentMembershipsToolStripMenuItem.Text = "Non Resident Memberships";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 668);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MIC Membership Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pErsonalMembershipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lifetimeMembershipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corporateMembershipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonResidentMembershipsToolStripMenuItem;
    }
}

