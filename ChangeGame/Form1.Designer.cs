namespace ChangeGame
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
            this.pennieLB = new System.Windows.Forms.Label();
            this.nickelLB = new System.Windows.Forms.Label();
            this.dimeLB = new System.Windows.Forms.Label();
            this.quarterLB = new System.Windows.Forms.Label();
            this.pennieTB = new System.Windows.Forms.TextBox();
            this.nickelTB = new System.Windows.Forms.TextBox();
            this.dimeTB = new System.Windows.Forms.TextBox();
            this.quarterTB = new System.Windows.Forms.TextBox();
            this.outputLB = new System.Windows.Forms.Label();
            this.gameBUT = new System.Windows.Forms.Button();
            this.randomizelimitsBUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pennieLB
            // 
            this.pennieLB.AutoSize = true;
            this.pennieLB.Location = new System.Drawing.Point(36, 13);
            this.pennieLB.Name = "pennieLB";
            this.pennieLB.Size = new System.Drawing.Size(51, 13);
            this.pennieLB.TabIndex = 0;
            this.pennieLB.Text = "Pennies: ";
            // 
            // nickelLB
            // 
            this.nickelLB.AutoSize = true;
            this.nickelLB.Location = new System.Drawing.Point(142, 13);
            this.nickelLB.Name = "nickelLB";
            this.nickelLB.Size = new System.Drawing.Size(48, 13);
            this.nickelLB.TabIndex = 1;
            this.nickelLB.Text = "Nickels: ";
            // 
            // dimeLB
            // 
            this.dimeLB.AutoSize = true;
            this.dimeLB.Location = new System.Drawing.Point(248, 13);
            this.dimeLB.Name = "dimeLB";
            this.dimeLB.Size = new System.Drawing.Size(42, 13);
            this.dimeLB.TabIndex = 2;
            this.dimeLB.Text = "Dimes: ";
            // 
            // quarterLB
            // 
            this.quarterLB.AutoSize = true;
            this.quarterLB.Location = new System.Drawing.Point(354, 14);
            this.quarterLB.Name = "quarterLB";
            this.quarterLB.Size = new System.Drawing.Size(53, 13);
            this.quarterLB.TabIndex = 3;
            this.quarterLB.Text = "Quarters: ";
            // 
            // pennieTB
            // 
            this.pennieTB.Location = new System.Drawing.Point(39, 30);
            this.pennieTB.Name = "pennieTB";
            this.pennieTB.Size = new System.Drawing.Size(100, 20);
            this.pennieTB.TabIndex = 4;
            this.pennieTB.TextChanged += new System.EventHandler(this.pennieTB_TextChanged);
            // 
            // nickelTB
            // 
            this.nickelTB.Location = new System.Drawing.Point(145, 30);
            this.nickelTB.Name = "nickelTB";
            this.nickelTB.Size = new System.Drawing.Size(100, 20);
            this.nickelTB.TabIndex = 5;
            this.nickelTB.TextChanged += new System.EventHandler(this.nickelTB_TextChanged);
            // 
            // dimeTB
            // 
            this.dimeTB.Location = new System.Drawing.Point(251, 30);
            this.dimeTB.Name = "dimeTB";
            this.dimeTB.Size = new System.Drawing.Size(100, 20);
            this.dimeTB.TabIndex = 6;
            this.dimeTB.TextChanged += new System.EventHandler(this.dimeTB_TextChanged);
            // 
            // quarterTB
            // 
            this.quarterTB.Location = new System.Drawing.Point(357, 30);
            this.quarterTB.Name = "quarterTB";
            this.quarterTB.Size = new System.Drawing.Size(100, 20);
            this.quarterTB.TabIndex = 7;
            this.quarterTB.TextChanged += new System.EventHandler(this.quarterTB_TextChanged);
            // 
            // outputLB
            // 
            this.outputLB.AutoSize = true;
            this.outputLB.Location = new System.Drawing.Point(231, 89);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(0, 13);
            this.outputLB.TabIndex = 8;
            // 
            // gameBUT
            // 
            this.gameBUT.Location = new System.Drawing.Point(39, 57);
            this.gameBUT.Name = "gameBUT";
            this.gameBUT.Size = new System.Drawing.Size(100, 23);
            this.gameBUT.TabIndex = 9;
            this.gameBUT.Text = "Limit Change";
            this.gameBUT.UseVisualStyleBackColor = true;
            this.gameBUT.Click += new System.EventHandler(this.gameBUT_Click);
            // 
            // randomizelimitsBUT
            // 
            this.randomizelimitsBUT.Location = new System.Drawing.Point(357, 57);
            this.randomizelimitsBUT.Name = "randomizelimitsBUT";
            this.randomizelimitsBUT.Size = new System.Drawing.Size(100, 23);
            this.randomizelimitsBUT.TabIndex = 10;
            this.randomizelimitsBUT.Text = "Randomize limits";
            this.randomizelimitsBUT.UseVisualStyleBackColor = true;
            this.randomizelimitsBUT.Visible = false;
            this.randomizelimitsBUT.Click += new System.EventHandler(this.randomizelimitsBUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 111);
            this.Controls.Add(this.randomizelimitsBUT);
            this.Controls.Add(this.gameBUT);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.quarterTB);
            this.Controls.Add(this.dimeTB);
            this.Controls.Add(this.nickelTB);
            this.Controls.Add(this.pennieTB);
            this.Controls.Add(this.quarterLB);
            this.Controls.Add(this.dimeLB);
            this.Controls.Add(this.nickelLB);
            this.Controls.Add(this.pennieLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pennieLB;
        private System.Windows.Forms.Label nickelLB;
        private System.Windows.Forms.Label dimeLB;
        private System.Windows.Forms.Label quarterLB;
        private System.Windows.Forms.TextBox pennieTB;
        private System.Windows.Forms.TextBox nickelTB;
        private System.Windows.Forms.TextBox dimeTB;
        private System.Windows.Forms.TextBox quarterTB;
        private System.Windows.Forms.Label outputLB;
        private System.Windows.Forms.Button gameBUT;
        private System.Windows.Forms.Button randomizelimitsBUT;
    }
}

