namespace GymDesktop
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            menuStrip1 = new MenuStrip();
            addMemberToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            viewMemberToolStripMenuItem = new ToolStripMenuItem();
            updateDeleteToolStripMenuItem = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addMemberToolStripMenuItem, viewMemberToolStripMenuItem, updateDeleteToolStripMenuItem, paymentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1335, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // addMemberToolStripMenuItem
            // 
            addMemberToolStripMenuItem.BackColor = Color.Silver;
            addMemberToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            addMemberToolStripMenuItem.Image = (Image)resources.GetObject("addMemberToolStripMenuItem.Image");
            addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            addMemberToolStripMenuItem.Size = new Size(135, 24);
            addMemberToolStripMenuItem.Text = "Add Member ";
            addMemberToolStripMenuItem.Click += addMemberToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(83, 26);
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // viewMemberToolStripMenuItem
            // 
            viewMemberToolStripMenuItem.Image = (Image)resources.GetObject("viewMemberToolStripMenuItem.Image");
            viewMemberToolStripMenuItem.Name = "viewMemberToolStripMenuItem";
            viewMemberToolStripMenuItem.Size = new Size(135, 24);
            viewMemberToolStripMenuItem.Text = "View Member";
            // 
            // updateDeleteToolStripMenuItem
            // 
            updateDeleteToolStripMenuItem.BackColor = Color.Silver;
            updateDeleteToolStripMenuItem.Image = (Image)resources.GetObject("updateDeleteToolStripMenuItem.Image");
            updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            updateDeleteToolStripMenuItem.Size = new Size(142, 24);
            updateDeleteToolStripMenuItem.Text = "Update/Delete";
            // 
            // paymentToolStripMenuItem
            // 
            paymentToolStripMenuItem.Image = (Image)resources.GetObject("paymentToolStripMenuItem.Image");
            paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            paymentToolStripMenuItem.Size = new Size(99, 24);
            paymentToolStripMenuItem.Text = "Payment";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1335, 692);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addMemberToolStripMenuItem;
        private ToolStripMenuItem viewMemberToolStripMenuItem;
        private ToolStripMenuItem updateDeleteToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}