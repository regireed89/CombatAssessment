namespace CombatForms
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
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.Attack = new System.Windows.Forms.Button();
            this.EndTurn = new System.Windows.Forms.Button();
            this.Party1 = new System.Windows.Forms.Label();
            this.Party2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player4 = new System.Windows.Forms.Label();
            this.Player5 = new System.Windows.Forms.Label();
            this.Player6 = new System.Windows.Forms.Label();
            this.PlayerTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Idle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(259, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(80, 28);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(259, 36);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(80, 28);
            this.load.TabIndex = 1;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 147);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(153, 27);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(29, 248);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(153, 27);
            this.progressBar2.TabIndex = 3;
            this.progressBar2.Value = 100;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(29, 348);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(153, 27);
            this.progressBar3.TabIndex = 4;
            this.progressBar3.Value = 100;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(414, 147);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(153, 27);
            this.progressBar4.TabIndex = 5;
            this.progressBar4.Value = 100;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(414, 248);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(153, 27);
            this.progressBar5.TabIndex = 6;
            this.progressBar5.Value = 100;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(414, 348);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(153, 27);
            this.progressBar6.TabIndex = 7;
            this.progressBar6.Value = 100;
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(130, 424);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(140, 55);
            this.Attack.TabIndex = 8;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // EndTurn
            // 
            this.EndTurn.Location = new System.Drawing.Point(316, 424);
            this.EndTurn.Name = "EndTurn";
            this.EndTurn.Size = new System.Drawing.Size(140, 55);
            this.EndTurn.TabIndex = 9;
            this.EndTurn.Text = "EndTurn";
            this.EndTurn.UseVisualStyleBackColor = true;
            this.EndTurn.Click += new System.EventHandler(this.EndTurn_Click);
            // 
            // Party1
            // 
            this.Party1.AutoSize = true;
            this.Party1.Location = new System.Drawing.Point(69, 44);
            this.Party1.Name = "Party1";
            this.Party1.Size = new System.Drawing.Size(40, 13);
            this.Party1.TabIndex = 10;
            this.Party1.Text = "Party 1";
            // 
            // Party2
            // 
            this.Party2.AutoSize = true;
            this.Party2.Location = new System.Drawing.Point(455, 44);
            this.Party2.Name = "Party2";
            this.Party2.Size = new System.Drawing.Size(40, 13);
            this.Party2.TabIndex = 11;
            this.Party2.Text = "Party 2";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(26, 131);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(45, 13);
            this.Player1.TabIndex = 12;
            this.Player1.Text = "Player 1";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(26, 232);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(45, 13);
            this.Player2.TabIndex = 13;
            this.Player2.Text = "Player 2";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(26, 332);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(45, 13);
            this.Player3.TabIndex = 14;
            this.Player3.Text = "Player 3";
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(411, 131);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(45, 13);
            this.Player4.TabIndex = 15;
            this.Player4.Text = "Player 4";
            // 
            // Player5
            // 
            this.Player5.AutoSize = true;
            this.Player5.Location = new System.Drawing.Point(411, 232);
            this.Player5.Name = "Player5";
            this.Player5.Size = new System.Drawing.Size(45, 13);
            this.Player5.TabIndex = 16;
            this.Player5.Text = "Player 5";
            // 
            // Player6
            // 
            this.Player6.AutoSize = true;
            this.Player6.Location = new System.Drawing.Point(411, 332);
            this.Player6.Name = "Player6";
            this.Player6.Size = new System.Drawing.Size(45, 13);
            this.Player6.TabIndex = 17;
            this.Player6.Text = "Player 6";
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.AutoSize = true;
            this.PlayerTurn.Location = new System.Drawing.Point(121, 78);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(61, 13);
            this.PlayerTurn.TabIndex = 19;
            this.PlayerTurn.Text = "Player Turn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Active Player State";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(153, 29);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(188, 94);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(97, 29);
            this.richTextBox2.TabIndex = 23;
            this.richTextBox2.Text = "";
            // 
            // Idle
            // 
            this.Idle.Location = new System.Drawing.Point(224, 485);
            this.Idle.Name = "Idle";
            this.Idle.Size = new System.Drawing.Size(140, 55);
            this.Idle.TabIndex = 24;
            this.Idle.Text = "Idle";
            this.Idle.UseVisualStyleBackColor = true;
            this.Idle.Click += new System.EventHandler(this.Idle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 548);
            this.Controls.Add(this.Idle);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.Player6);
            this.Controls.Add(this.Player5);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Party2);
            this.Controls.Add(this.Party1);
            this.Controls.Add(this.EndTurn);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Button EndTurn;
        private System.Windows.Forms.Label Party1;
        private System.Windows.Forms.Label Party2;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.Label Player4;
        private System.Windows.Forms.Label Player5;
        private System.Windows.Forms.Label Player6;
        private System.Windows.Forms.Label PlayerTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button Idle;
    }
}

