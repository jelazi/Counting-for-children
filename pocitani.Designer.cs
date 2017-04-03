namespace pocitani
{
    partial class pocitani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pocitani));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zvukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapnoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vypnoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hudbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapnoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vypnoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(87, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sčítání";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(87, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Odečítání";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(87, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "Obojí";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastaveníToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zvukToolStripMenuItem,
            this.hudbaToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            // 
            // zvukToolStripMenuItem
            // 
            this.zvukToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapnoutToolStripMenuItem,
            this.vypnoutToolStripMenuItem});
            this.zvukToolStripMenuItem.Name = "zvukToolStripMenuItem";
            this.zvukToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.zvukToolStripMenuItem.Text = "Zvuk";
            // 
            // zapnoutToolStripMenuItem
            // 
            this.zapnoutToolStripMenuItem.Checked = true;
            this.zapnoutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zapnoutToolStripMenuItem.Name = "zapnoutToolStripMenuItem";
            this.zapnoutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.zapnoutToolStripMenuItem.Text = "Zapnout";
            this.zapnoutToolStripMenuItem.Click += new System.EventHandler(this.soundon);
            // 
            // vypnoutToolStripMenuItem
            // 
            this.vypnoutToolStripMenuItem.Name = "vypnoutToolStripMenuItem";
            this.vypnoutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.vypnoutToolStripMenuItem.Text = "Vypnout";
            this.vypnoutToolStripMenuItem.Click += new System.EventHandler(this.soundoff);
            // 
            // hudbaToolStripMenuItem
            // 
            this.hudbaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapnoutToolStripMenuItem1,
            this.vypnoutToolStripMenuItem1});
            this.hudbaToolStripMenuItem.Name = "hudbaToolStripMenuItem";
            this.hudbaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.hudbaToolStripMenuItem.Text = "Hudba";
            // 
            // zapnoutToolStripMenuItem1
            // 
            this.zapnoutToolStripMenuItem1.Name = "zapnoutToolStripMenuItem1";
            this.zapnoutToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.zapnoutToolStripMenuItem1.Text = "Zapnout";
            // 
            // vypnoutToolStripMenuItem1
            // 
            this.vypnoutToolStripMenuItem1.Name = "vypnoutToolStripMenuItem1";
            this.vypnoutToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.vypnoutToolStripMenuItem1.Text = "Vypnout";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(87, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 77);
            this.button4.TabIndex = 5;
            this.button4.Text = "Násobení";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pocitani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 530);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "pocitani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Počítání pro Anežku";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zvukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapnoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vypnoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hudbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapnoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vypnoutToolStripMenuItem1;
        private System.Windows.Forms.Button button4;
    }
}

