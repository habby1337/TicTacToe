namespace TicTacToe_Solution
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.player_pannel = new System.Windows.Forms.Panel();
            this.lPlayer2 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bReload = new System.Windows.Forms.Button();
            this.lPlayer1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lPlayerCur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lMaxPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.game_pannel = new System.Windows.Forms.Panel();
            this.slot_9 = new System.Windows.Forms.Button();
            this.slot_8 = new System.Windows.Forms.Button();
            this.slot_7 = new System.Windows.Forms.Button();
            this.slot_6 = new System.Windows.Forms.Button();
            this.slot_5 = new System.Windows.Forms.Button();
            this.slot_4 = new System.Windows.Forms.Button();
            this.slot_3 = new System.Windows.Forms.Button();
            this.slot_2 = new System.Windows.Forms.Button();
            this.slot_1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPoints = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.bGameStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.first_pannel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.player_pannel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.game_pannel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPoints)).BeginInit();
            this.first_pannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.player_pannel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.first_pannel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // player_pannel
            // 
            this.player_pannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.player_pannel.Controls.Add(this.lPlayer2);
            this.player_pannel.Controls.Add(this.bCancel);
            this.player_pannel.Controls.Add(this.bReload);
            this.player_pannel.Controls.Add(this.lPlayer1);
            this.player_pannel.Location = new System.Drawing.Point(0, 347);
            this.player_pannel.Name = "player_pannel";
            this.player_pannel.Size = new System.Drawing.Size(446, 103);
            this.player_pannel.TabIndex = 14;
            // 
            // lPlayer2
            // 
            this.lPlayer2.AutoSize = true;
            this.lPlayer2.ForeColor = System.Drawing.Color.White;
            this.lPlayer2.Location = new System.Drawing.Point(239, 16);
            this.lPlayer2.Name = "lPlayer2";
            this.lPlayer2.Size = new System.Drawing.Size(78, 13);
            this.lPlayer2.TabIndex = 4;
            this.lPlayer2.Text = "Giocatore 2: 0";
            // 
            // bCancel
            // 
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bCancel.Location = new System.Drawing.Point(91, 59);
            this.bCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 24);
            this.bCancel.TabIndex = 12;
            this.bCancel.Text = "Annulla";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bReload
            // 
            this.bReload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bReload.Location = new System.Drawing.Point(242, 59);
            this.bReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bReload.Name = "bReload";
            this.bReload.Size = new System.Drawing.Size(75, 24);
            this.bReload.TabIndex = 13;
            this.bReload.Text = "Riavvia";
            this.bReload.UseVisualStyleBackColor = true;
            this.bReload.Click += new System.EventHandler(this.bReload_Click);
            // 
            // lPlayer1
            // 
            this.lPlayer1.AutoSize = true;
            this.lPlayer1.ForeColor = System.Drawing.Color.White;
            this.lPlayer1.Location = new System.Drawing.Point(88, 16);
            this.lPlayer1.Name = "lPlayer1";
            this.lPlayer1.Size = new System.Drawing.Size(78, 13);
            this.lPlayer1.TabIndex = 3;
            this.lPlayer1.Text = "Giocatore 1: 0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.lPlayerCur);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lMaxPoints);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.game_pannel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 316);
            this.panel3.TabIndex = 2;
            // 
            // lPlayerCur
            // 
            this.lPlayerCur.AutoSize = true;
            this.lPlayerCur.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.lPlayerCur.ForeColor = System.Drawing.Color.White;
            this.lPlayerCur.Location = new System.Drawing.Point(344, 118);
            this.lPlayerCur.Name = "lPlayerCur";
            this.lPlayerCur.Size = new System.Drawing.Size(74, 20);
            this.lPlayerCur.TabIndex = 5;
            this.lPlayerCur.Text = "Giocatore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(362, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Turno:";
            // 
            // lMaxPoints
            // 
            this.lMaxPoints.AutoSize = true;
            this.lMaxPoints.ForeColor = System.Drawing.Color.White;
            this.lMaxPoints.Location = new System.Drawing.Point(139, 42);
            this.lMaxPoints.Name = "lMaxPoints";
            this.lMaxPoints.Size = new System.Drawing.Size(120, 13);
            this.lMaxPoints.TabIndex = 3;
            this.lMaxPoints.Text = "Punteggio massimo: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TIC TAC TOE";
            // 
            // game_pannel
            // 
            this.game_pannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.game_pannel.Controls.Add(this.slot_9);
            this.game_pannel.Controls.Add(this.slot_8);
            this.game_pannel.Controls.Add(this.slot_7);
            this.game_pannel.Controls.Add(this.slot_6);
            this.game_pannel.Controls.Add(this.slot_5);
            this.game_pannel.Controls.Add(this.slot_4);
            this.game_pannel.Controls.Add(this.slot_3);
            this.game_pannel.Controls.Add(this.slot_2);
            this.game_pannel.Controls.Add(this.slot_1);
            this.game_pannel.Location = new System.Drawing.Point(91, 89);
            this.game_pannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_pannel.Name = "game_pannel";
            this.game_pannel.Size = new System.Drawing.Size(224, 208);
            this.game_pannel.TabIndex = 1;
            // 
            // slot_9
            // 
            this.slot_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slot_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slot_9.ForeColor = System.Drawing.Color.White;
            this.slot_9.Location = new System.Drawing.Point(149, 139);
            this.slot_9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slot_9.Name = "slot_9";
            this.slot_9.Size = new System.Drawing.Size(67, 63);
            this.slot_9.TabIndex = 8;
            this.slot_9.Text = "9";
            this.slot_9.UseVisualStyleBackColor = true;
            this.slot_9.Click += new System.EventHandler(this.slot_9_Click);
            // 
            // slot_8
            // 
            this.slot_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slot_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slot_8.ForeColor = System.Drawing.Color.White;
            this.slot_8.Location = new System.Drawing.Point(76, 139);
            this.slot_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slot_8.Name = "slot_8";
            this.slot_8.Size = new System.Drawing.Size(67, 63);
            this.slot_8.TabIndex = 7;
            this.slot_8.Text = "8";
            this.slot_8.UseVisualStyleBackColor = true;
            this.slot_8.Click += new System.EventHandler(this.slot_8_Click);
            // 
            // slot_7
            // 
            this.slot_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slot_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slot_7.ForeColor = System.Drawing.Color.White;
            this.slot_7.Location = new System.Drawing.Point(3, 139);
            this.slot_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slot_7.Name = "slot_7";
            this.slot_7.Size = new System.Drawing.Size(67, 63);
            this.slot_7.TabIndex = 6;
            this.slot_7.Text = "7";
            this.slot_7.UseVisualStyleBackColor = true;
            this.slot_7.Click += new System.EventHandler(this.slot_7_Click);
            // 
            // slot_6
            // 
            this.slot_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slot_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slot_6.ForeColor = System.Drawing.Color.White;
            this.slot_6.Location = new System.Drawing.Point(149, 71);
            this.slot_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slot_6.Name = "slot_6";
            this.slot_6.Size = new System.Drawing.Size(67, 63);
            this.slot_6.TabIndex = 5;
            this.slot_6.Text = "6";
            this.slot_6.UseVisualStyleBackColor = true;
            this.slot_6.Click += new System.EventHandler(this.slot_6_Click);
            // 
            // slot_5
            // 
            this.slot_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slot_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slot_5.ForeColor = System.Drawing.Color.White;
            this.slot_5.Location = new System.Drawing.Point(76, 71);
            this.slot_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slot_5.Name = "slot_5";
            this.slot_5.Size = new System.Drawing.Size(67, 63);
            this.slot_5.TabIndex = 4;
            this.slot_5.Text = "5";
            this.slot_5.UseVisualStyleBackColor = true;
            this.slot_5.Click += new System.EventHandler(this.slot_5_Click);
            // 
            // slot_4
            // 
            this.slot_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slot_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slot_4.ForeColor = System.Drawing.Color.White;
            this.slot_4.Location = new System.Drawing.Point(3, 71);
            this.slot_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slot_4.Name = "slot_4";
            this.slot_4.Size = new System.Drawing.Size(67, 63);
            this.slot_4.TabIndex = 3;
            this.slot_4.Text = "4";
            this.slot_4.UseVisualStyleBackColor = true;
            this.slot_4.Click += new System.EventHandler(this.slot_4_Click);
            // 
            // slot_3
            // 
            this.slot_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slot_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slot_3.ForeColor = System.Drawing.Color.White;
            this.slot_3.Location = new System.Drawing.Point(149, 2);
            this.slot_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slot_3.Name = "slot_3";
            this.slot_3.Size = new System.Drawing.Size(67, 63);
            this.slot_3.TabIndex = 2;
            this.slot_3.Text = "3";
            this.slot_3.UseVisualStyleBackColor = true;
            this.slot_3.Click += new System.EventHandler(this.slot_3_Click);
            // 
            // slot_2
            // 
            this.slot_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slot_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slot_2.ForeColor = System.Drawing.Color.White;
            this.slot_2.Location = new System.Drawing.Point(76, 2);
            this.slot_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slot_2.Name = "slot_2";
            this.slot_2.Size = new System.Drawing.Size(67, 63);
            this.slot_2.TabIndex = 1;
            this.slot_2.Text = "2";
            this.slot_2.UseVisualStyleBackColor = true;
            this.slot_2.Click += new System.EventHandler(this.slot_2_Click);
            // 
            // slot_1
            // 
            this.slot_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slot_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slot_1.ForeColor = System.Drawing.Color.White;
            this.slot_1.Location = new System.Drawing.Point(3, 2);
            this.slot_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slot_1.Name = "slot_1";
            this.slot_1.Size = new System.Drawing.Size(67, 63);
            this.slot_1.TabIndex = 0;
            this.slot_1.Text = "1";
            this.slot_1.UseVisualStyleBackColor = true;
            this.slot_1.Click += new System.EventHandler(this.slot_1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.tbPoints);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bGameStart);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbPlayer2);
            this.panel2.Controls.Add(this.tbPlayer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(497, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 450);
            this.panel2.TabIndex = 1;
            // 
            // tbPoints
            // 
            this.tbPoints.Location = new System.Drawing.Point(99, 275);
            this.tbPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbPoints.Name = "tbPoints";
            this.tbPoints.Size = new System.Drawing.Size(100, 22);
            this.tbPoints.TabIndex = 11;
            this.tbPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(96, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Punti massimi:";
            // 
            // bGameStart
            // 
            this.bGameStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bGameStart.Location = new System.Drawing.Point(113, 352);
            this.bGameStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bGameStart.Name = "bGameStart";
            this.bGameStart.Size = new System.Drawing.Size(75, 24);
            this.bGameStart.TabIndex = 8;
            this.bGameStart.Text = "Comincia";
            this.bGameStart.UseVisualStyleBackColor = true;
            this.bGameStart.Click += new System.EventHandler(this.bGameStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(96, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giocatore 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(96, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giocatore 1:";
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPlayer2.Location = new System.Drawing.Point(99, 183);
            this.tbPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlayer2.MaxLength = 10;
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(100, 22);
            this.tbPlayer2.TabIndex = 1;
            this.tbPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPlayer1.Location = new System.Drawing.Point(99, 93);
            this.tbPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlayer1.MaxLength = 10;
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(100, 22);
            this.tbPlayer1.TabIndex = 0;
            this.tbPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // first_pannel
            // 
            this.first_pannel.Controls.Add(this.label7);
            this.first_pannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.first_pannel.Location = new System.Drawing.Point(0, 0);
            this.first_pannel.Name = "first_pannel";
            this.first_pannel.Size = new System.Drawing.Size(446, 450);
            this.first_pannel.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(149, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Aspettando le opzioni...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.player_pannel.ResumeLayout(false);
            this.player_pannel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.game_pannel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPoints)).EndInit();
            this.first_pannel.ResumeLayout(false);
            this.first_pannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button slot_1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lPlayer2;
        private System.Windows.Forms.Label lPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel game_pannel;
        private System.Windows.Forms.Button slot_9;
        private System.Windows.Forms.Button slot_8;
        private System.Windows.Forms.Button slot_7;
        private System.Windows.Forms.Button slot_6;
        private System.Windows.Forms.Button slot_5;
        private System.Windows.Forms.Button slot_4;
        private System.Windows.Forms.Button slot_3;
        private System.Windows.Forms.Button slot_2;
        private System.Windows.Forms.Button bGameStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bReload;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.NumericUpDown tbPoints;
        private System.Windows.Forms.Panel player_pannel;
        private System.Windows.Forms.Panel first_pannel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lMaxPoints;
        private System.Windows.Forms.Label lPlayerCur;
        private System.Windows.Forms.Label label2;
    }
}

