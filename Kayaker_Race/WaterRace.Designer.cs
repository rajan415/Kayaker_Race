namespace Kayaker_Race
{
    partial class WaterRace
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
            this.btnGo = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownKayak = new System.Windows.Forms.NumericUpDown();
            this.lblMaxBet = new System.Windows.Forms.Label();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.lblDaxResult = new System.Windows.Forms.Label();
            this.lblAllanResult = new System.Windows.Forms.Label();
            this.lblSteveResult = new System.Windows.Forms.Label();
            this.lblKayakerNumber = new System.Windows.Forms.Label();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblMaxBetText = new System.Windows.Forms.Label();
            this.rbDax = new System.Windows.Forms.RadioButton();
            this.rbAllan = new System.Windows.Forms.RadioButton();
            this.rbSteve = new System.Windows.Forms.RadioButton();
            this.pbKayaker2 = new System.Windows.Forms.PictureBox();
            this.pbKayaker4 = new System.Windows.Forms.PictureBox();
            this.pbKayker1 = new System.Windows.Forms.PictureBox();
            this.pbKayaker3 = new System.Windows.Forms.PictureBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKayak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayaker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayaker4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayaker3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(757, 541);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 47);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(240, 603);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(215, 41);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Everyone Drowned, GO HOME!";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cyan;
            this.groupBox1.Controls.Add(this.numericUpDownKayak);
            this.groupBox1.Controls.Add(this.lblMaxBet);
            this.groupBox1.Controls.Add(this.numericUpDownBet);
            this.groupBox1.Controls.Add(this.lblDaxResult);
            this.groupBox1.Controls.Add(this.lblAllanResult);
            this.groupBox1.Controls.Add(this.lblSteveResult);
            this.groupBox1.Controls.Add(this.lblKayakerNumber);
            this.groupBox1.Controls.Add(this.lblBetAmount);
            this.groupBox1.Controls.Add(this.lblMaxBetText);
            this.groupBox1.Controls.Add(this.rbDax);
            this.groupBox1.Controls.Add(this.rbAllan);
            this.groupBox1.Controls.Add(this.rbSteve);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 460);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(663, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDownKayak
            // 
            this.numericUpDownKayak.Location = new System.Drawing.Point(228, 101);
            this.numericUpDownKayak.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownKayak.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownKayak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKayak.Name = "numericUpDownKayak";
            this.numericUpDownKayak.Size = new System.Drawing.Size(58, 26);
            this.numericUpDownKayak.TabIndex = 13;
            this.numericUpDownKayak.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaxBet
            // 
            this.lblMaxBet.Location = new System.Drawing.Point(240, 33);
            this.lblMaxBet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxBet.Name = "lblMaxBet";
            this.lblMaxBet.Size = new System.Drawing.Size(40, 24);
            this.lblMaxBet.TabIndex = 12;
            this.lblMaxBet.Text = "0";
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Location = new System.Drawing.Point(228, 62);
            this.numericUpDownBet.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(58, 26);
            this.numericUpDownBet.TabIndex = 10;
            // 
            // lblDaxResult
            // 
            this.lblDaxResult.Location = new System.Drawing.Point(327, 93);
            this.lblDaxResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDaxResult.Name = "lblDaxResult";
            this.lblDaxResult.Size = new System.Drawing.Size(252, 28);
            this.lblDaxResult.TabIndex = 9;
            this.lblDaxResult.Text = "Dax has not placed a bet.";
            // 
            // lblAllanResult
            // 
            this.lblAllanResult.Location = new System.Drawing.Point(324, 62);
            this.lblAllanResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllanResult.Name = "lblAllanResult";
            this.lblAllanResult.Size = new System.Drawing.Size(255, 24);
            this.lblAllanResult.TabIndex = 8;
            this.lblAllanResult.Text = "Allan has not placed a bet.";
            // 
            // lblSteveResult
            // 
            this.lblSteveResult.Location = new System.Drawing.Point(324, 33);
            this.lblSteveResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSteveResult.Name = "lblSteveResult";
            this.lblSteveResult.Size = new System.Drawing.Size(259, 27);
            this.lblSteveResult.TabIndex = 7;
            this.lblSteveResult.Text = "Steve has not placed a bet.";
            // 
            // lblKayakerNumber
            // 
            this.lblKayakerNumber.Location = new System.Drawing.Point(135, 101);
            this.lblKayakerNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKayakerNumber.Name = "lblKayakerNumber";
            this.lblKayakerNumber.Size = new System.Drawing.Size(70, 27);
            this.lblKayakerNumber.TabIndex = 6;
            this.lblKayakerNumber.Text = "Kayaker:";
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.Location = new System.Drawing.Point(135, 64);
            this.lblBetAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(70, 26);
            this.lblBetAmount.TabIndex = 5;
            this.lblBetAmount.Text = "Betting: $";
            // 
            // lblMaxBetText
            // 
            this.lblMaxBetText.Location = new System.Drawing.Point(135, 33);
            this.lblMaxBetText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxBetText.Name = "lblMaxBetText";
            this.lblMaxBetText.Size = new System.Drawing.Size(95, 27);
            this.lblMaxBetText.TabIndex = 4;
            this.lblMaxBetText.Text = "Max Bet:";
            // 
            // rbDax
            // 
            this.rbDax.AutoSize = true;
            this.rbDax.Location = new System.Drawing.Point(25, 100);
            this.rbDax.Margin = new System.Windows.Forms.Padding(2);
            this.rbDax.Name = "rbDax";
            this.rbDax.Size = new System.Drawing.Size(60, 24);
            this.rbDax.TabIndex = 3;
            this.rbDax.Text = "Dax";
            this.rbDax.UseVisualStyleBackColor = true;
            this.rbDax.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbAllan
            // 
            this.rbAllan.AutoSize = true;
            this.rbAllan.Location = new System.Drawing.Point(25, 69);
            this.rbAllan.Margin = new System.Windows.Forms.Padding(2);
            this.rbAllan.Name = "rbAllan";
            this.rbAllan.Size = new System.Drawing.Size(67, 24);
            this.rbAllan.TabIndex = 2;
            this.rbAllan.Text = "Allan";
            this.rbAllan.UseVisualStyleBackColor = true;
            this.rbAllan.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSteve
            // 
            this.rbSteve.AutoSize = true;
            this.rbSteve.Location = new System.Drawing.Point(25, 36);
            this.rbSteve.Margin = new System.Windows.Forms.Padding(2);
            this.rbSteve.Name = "rbSteve";
            this.rbSteve.Size = new System.Drawing.Size(72, 24);
            this.rbSteve.TabIndex = 1;
            this.rbSteve.Text = "Steve";
            this.rbSteve.UseVisualStyleBackColor = true;
            this.rbSteve.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // pbKayaker2
            // 
            this.pbKayaker2.BackColor = System.Drawing.Color.Transparent;
            this.pbKayaker2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKayaker2.Image = global::Kayaker_Race.Resource1.kayaker_top;
            this.pbKayaker2.Location = new System.Drawing.Point(434, 64);
            this.pbKayaker2.Margin = new System.Windows.Forms.Padding(2);
            this.pbKayaker2.Name = "pbKayaker2";
            this.pbKayaker2.Size = new System.Drawing.Size(83, 62);
            this.pbKayaker2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKayaker2.TabIndex = 4;
            this.pbKayaker2.TabStop = false;
            this.pbKayaker2.Click += new System.EventHandler(this.pbKayaker2_Click);
            // 
            // pbKayaker4
            // 
            this.pbKayaker4.BackColor = System.Drawing.Color.Transparent;
            this.pbKayaker4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbKayaker4.Image = global::Kayaker_Race.Resource1.kayaker_top;
            this.pbKayaker4.Location = new System.Drawing.Point(574, 64);
            this.pbKayaker4.Margin = new System.Windows.Forms.Padding(2);
            this.pbKayaker4.Name = "pbKayaker4";
            this.pbKayaker4.Size = new System.Drawing.Size(83, 62);
            this.pbKayaker4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKayaker4.TabIndex = 5;
            this.pbKayaker4.TabStop = false;
            this.pbKayaker4.Click += new System.EventHandler(this.pbKayaker4_Click);
            // 
            // pbKayker1
            // 
            this.pbKayker1.BackColor = System.Drawing.Color.Transparent;
            this.pbKayker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKayker1.Image = global::Kayaker_Race.Resource1.kayaker_top;
            this.pbKayker1.Location = new System.Drawing.Point(360, 64);
            this.pbKayker1.Margin = new System.Windows.Forms.Padding(2);
            this.pbKayker1.Name = "pbKayker1";
            this.pbKayker1.Size = new System.Drawing.Size(74, 62);
            this.pbKayker1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKayker1.TabIndex = 6;
            this.pbKayker1.TabStop = false;
            this.pbKayker1.Click += new System.EventHandler(this.pbKayker1_Click);
            // 
            // pbKayaker3
            // 
            this.pbKayaker3.BackColor = System.Drawing.Color.Transparent;
            this.pbKayaker3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbKayaker3.Image = global::Kayaker_Race.Resource1.kayaker_top;
            this.pbKayaker3.Location = new System.Drawing.Point(504, 64);
            this.pbKayaker3.Margin = new System.Windows.Forms.Padding(2);
            this.pbKayaker3.Name = "pbKayaker3";
            this.pbKayaker3.Size = new System.Drawing.Size(83, 62);
            this.pbKayaker3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKayaker3.TabIndex = 7;
            this.pbKayaker3.TabStop = false;
            this.pbKayaker3.Click += new System.EventHandler(this.pbKayaker3_Click);
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.Color.Black;
            this.btnBet.Location = new System.Drawing.Point(757, 460);
            this.btnBet.Margin = new System.Windows.Forms.Padding(2);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(100, 47);
            this.btnBet.TabIndex = 8;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // WaterRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Kayaker_Race.Resource1.Mexico_Waterfall_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 653);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.pbKayker1);
            this.Controls.Add(this.pbKayaker3);
            this.Controls.Add(this.pbKayaker4);
            this.Controls.Add(this.pbKayaker2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "WaterRace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKayak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayaker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayaker4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayaker3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDax;
        private System.Windows.Forms.RadioButton rbAllan;
        private System.Windows.Forms.RadioButton rbSteve;
        private System.Windows.Forms.PictureBox pbKayaker2;
        private System.Windows.Forms.PictureBox pbKayaker4;
        private System.Windows.Forms.PictureBox pbKayker1;
        private System.Windows.Forms.PictureBox pbKayaker3;
        private System.Windows.Forms.Label lblDaxResult;
        private System.Windows.Forms.Label lblAllanResult;
        private System.Windows.Forms.Label lblSteveResult;
        private System.Windows.Forms.Label lblKayakerNumber;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label lblMaxBetText;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.Label lblMaxBet;
        private System.Windows.Forms.NumericUpDown numericUpDownKayak;
        private System.Windows.Forms.Button btnBet;
    }
}

