namespace pocitani
{
    partial class FormPocitani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPocitani));
            this.lblAnswWrong = new System.Windows.Forms.Label();
            this.lblAnswRight = new System.Windows.Forms.Label();
            this.lblAnsw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Label();
            this.picSmile = new System.Windows.Forms.PictureBox();
            this.lblEval = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Label();
            this.btnNumber2 = new System.Windows.Forms.TextBox();
            this.btnNumber1 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnControl = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zvukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapnoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vypnoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sčítáníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSmile)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnswWrong
            // 
            this.lblAnswWrong.AutoSize = true;
            this.lblAnswWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAnswWrong.Location = new System.Drawing.Point(353, 201);
            this.lblAnswWrong.Name = "lblAnswWrong";
            this.lblAnswWrong.Size = new System.Drawing.Size(25, 25);
            this.lblAnswWrong.TabIndex = 71;
            this.lblAnswWrong.Text = "0";
            // 
            // lblAnswRight
            // 
            this.lblAnswRight.AutoSize = true;
            this.lblAnswRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAnswRight.Location = new System.Drawing.Point(353, 157);
            this.lblAnswRight.Name = "lblAnswRight";
            this.lblAnswRight.Size = new System.Drawing.Size(25, 25);
            this.lblAnswRight.TabIndex = 70;
            this.lblAnswRight.Text = "0";
            // 
            // lblAnsw
            // 
            this.lblAnsw.AutoSize = true;
            this.lblAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAnsw.Location = new System.Drawing.Point(353, 112);
            this.lblAnsw.Name = "lblAnsw";
            this.lblAnsw.Size = new System.Drawing.Size(25, 25);
            this.lblAnsw.TabIndex = 69;
            this.lblAnsw.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(212, 201);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Špatně:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(211, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Správně:";
            // 
            // Button
            // 
            this.Button.AutoSize = true;
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button.Location = new System.Drawing.Point(211, 112);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(126, 25);
            this.Button.TabIndex = 66;
            this.Button.Text = "Odpovědí: ";
            // 
            // picSmile
            // 
            this.picSmile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSmile.Image = global::pocitani.Properties.Resources.smiley_thinking_815;
            this.picSmile.Location = new System.Drawing.Point(229, 306);
            this.picSmile.Name = "picSmile";
            this.picSmile.Size = new System.Drawing.Size(134, 112);
            this.picSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSmile.TabIndex = 65;
            this.picSmile.TabStop = false;
            // 
            // lblEval
            // 
            this.lblEval.AutoSize = true;
            this.lblEval.BackColor = System.Drawing.Color.Aqua;
            this.lblEval.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEval.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEval.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEval.Location = new System.Drawing.Point(136, 463);
            this.lblEval.Name = "lblEval";
            this.lblEval.Size = new System.Drawing.Size(0, 55);
            this.lblEval.TabIndex = 64;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(146, 112);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 37);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sign.Location = new System.Drawing.Point(95, 36);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(31, 31);
            this.sign.TabIndex = 62;
            this.sign.Text = "+";
            // 
            // btnNumber2
            // 
            this.btnNumber2.Enabled = false;
            this.btnNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNumber2.Location = new System.Drawing.Point(134, 33);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(51, 35);
            this.btnNumber2.TabIndex = 61;
            this.btnNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNumber1
            // 
            this.btnNumber1.Enabled = false;
            this.btnNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNumber1.Location = new System.Drawing.Point(28, 33);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(52, 35);
            this.btnNumber1.TabIndex = 60;
            this.btnNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtResult.Location = new System.Drawing.Point(28, 114);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 35);
            this.txtResult.TabIndex = 59;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnControl
            // 
            this.btnControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnControl.Location = new System.Drawing.Point(87, 373);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(98, 45);
            this.btnControl.TabIndex = 58;
            this.btnControl.Text = "Kontrola";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btn0
            // 
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn0.Location = new System.Drawing.Point(28, 373);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(39, 45);
            this.btn0.TabIndex = 57;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn3.Location = new System.Drawing.Point(146, 306);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(39, 45);
            this.btn3.TabIndex = 56;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2.Location = new System.Drawing.Point(87, 306);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(39, 45);
            this.btn2.TabIndex = 55;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.Location = new System.Drawing.Point(28, 306);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(39, 45);
            this.btn1.TabIndex = 54;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn6.Location = new System.Drawing.Point(146, 242);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(39, 45);
            this.btn6.TabIndex = 53;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn5.Location = new System.Drawing.Point(87, 242);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(39, 45);
            this.btn5.TabIndex = 52;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn4.Location = new System.Drawing.Point(28, 242);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(39, 45);
            this.btn4.TabIndex = 51;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn9.Location = new System.Drawing.Point(146, 178);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(39, 45);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn8.Location = new System.Drawing.Point(87, 178);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(39, 45);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn7.Location = new System.Drawing.Point(28, 178);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(39, 45);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastaveníToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zvukToolStripMenuItem,
            this.sčítáníToolStripMenuItem,
            this.minusToolStripMenuItem});
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
            this.zvukToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zvukToolStripMenuItem.Text = "Zvuk";
            // 
            // zapnoutToolStripMenuItem
            // 
            this.zapnoutToolStripMenuItem.Checked = true;
            this.zapnoutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zapnoutToolStripMenuItem.Name = "zapnoutToolStripMenuItem";
            this.zapnoutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.zapnoutToolStripMenuItem.Text = "Zapnout";
            this.zapnoutToolStripMenuItem.Click += new System.EventHandler(this.zapnoutToolStripMenuItem_Click);
            // 
            // vypnoutToolStripMenuItem
            // 
            this.vypnoutToolStripMenuItem.Name = "vypnoutToolStripMenuItem";
            this.vypnoutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.vypnoutToolStripMenuItem.Text = "Vypnout";
            this.vypnoutToolStripMenuItem.Click += new System.EventHandler(this.vypnoutToolStripMenuItem_Click);
            // 
            // sčítáníToolStripMenuItem
            // 
            this.sčítáníToolStripMenuItem.Name = "sčítáníToolStripMenuItem";
            this.sčítáníToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sčítáníToolStripMenuItem.Text = "Rozmezí čísel";
            this.sčítáníToolStripMenuItem.Click += new System.EventHandler(this.rozmeziscit);
            // 
            // minusToolStripMenuItem
            // 
            this.minusToolStripMenuItem.CheckOnClick = true;
            this.minusToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.minusToolStripMenuItem.Name = "minusToolStripMenuItem";
            this.minusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minusToolStripMenuItem.Text = "Záporná čísla";
            this.minusToolStripMenuItem.Click += new System.EventHandler(this.minusToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(28, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 45);
            this.button1.TabIndex = 73;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPocitani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAnswWrong);
            this.Controls.Add(this.lblAnswRight);
            this.Controls.Add(this.lblAnsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.picSmile);
            this.Controls.Add(this.lblEval);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPocitani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picSmile)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswWrong;
        private System.Windows.Forms.Label lblAnswRight;
        private System.Windows.Forms.Label lblAnsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Button;
        private System.Windows.Forms.PictureBox picSmile;
        private System.Windows.Forms.Label lblEval;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.TextBox btnNumber2;
        private System.Windows.Forms.TextBox btnNumber1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zvukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapnoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vypnoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sčítáníToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem minusToolStripMenuItem;
    }
}

