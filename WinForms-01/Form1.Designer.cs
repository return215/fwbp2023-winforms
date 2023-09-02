namespace WinForms_01
{
    partial class FormScore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelScoreSystem = new Label();
            comboScoreSystem = new ComboBox();
            labelW1 = new Label();
            labelTitle = new Label();
            tableScore = new TableLayoutPanel();
            labelW2 = new Label();
            labelW3 = new Label();
            labelW4 = new Label();
            labelW5 = new Label();
            labelW6 = new Label();
            labelH1 = new Label();
            labelH2 = new Label();
            labelH3 = new Label();
            numW1 = new NumericUpDown();
            numW2 = new NumericUpDown();
            numW3 = new NumericUpDown();
            numW4 = new NumericUpDown();
            numW5 = new NumericUpDown();
            numW6 = new NumericUpDown();
            numH1 = new NumericUpDown();
            numH2 = new NumericUpDown();
            numH3 = new NumericUpDown();
            tableSystem = new TableLayoutPanel();
            labelNormScoreText = new Label();
            labelNormScore = new Label();
            labelScoreText = new Label();
            labelScore = new Label();
            tableScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numW1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numW2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numW3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numW4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numW5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numW6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numH1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numH2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numH3).BeginInit();
            tableSystem.SuspendLayout();
            SuspendLayout();
            // 
            // labelScoreSystem
            // 
            labelScoreSystem.Anchor = AnchorStyles.Left;
            labelScoreSystem.AutoSize = true;
            labelScoreSystem.Location = new Point(3, 7);
            labelScoreSystem.Name = "labelScoreSystem";
            labelScoreSystem.Size = new Size(88, 15);
            labelScoreSystem.TabIndex = 1;
            labelScoreSystem.Text = "Scoring System";
            // 
            // comboScoreSystem
            // 
            comboScoreSystem.Anchor = AnchorStyles.Right;
            comboScoreSystem.FormattingEnabled = true;
            comboScoreSystem.Location = new Point(136, 3);
            comboScoreSystem.Name = "comboScoreSystem";
            comboScoreSystem.Size = new Size(121, 23);
            comboScoreSystem.TabIndex = 2;
            comboScoreSystem.SelectedIndexChanged += comboScoreSystem_SelectedIndexChanged;
            // 
            // labelW1
            // 
            labelW1.Anchor = AnchorStyles.Left;
            labelW1.AutoSize = true;
            labelW1.Location = new Point(3, 36);
            labelW1.Name = "labelW1";
            labelW1.Size = new Size(62, 15);
            labelW1.TabIndex = 3;
            labelW1.Text = "Marvelous";
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(151, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(171, 30);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Score Converter";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableScore
            // 
            tableScore.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableScore.AutoScroll = true;
            tableScore.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableScore.ColumnCount = 2;
            tableScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableScore.Controls.Add(labelScoreSystem, 0, 0);
            tableScore.Controls.Add(comboScoreSystem, 1, 0);
            tableScore.Controls.Add(labelW1, 0, 1);
            tableScore.Controls.Add(labelW2, 0, 2);
            tableScore.Controls.Add(labelW3, 0, 3);
            tableScore.Controls.Add(labelW4, 0, 4);
            tableScore.Controls.Add(labelW5, 0, 5);
            tableScore.Controls.Add(labelW6, 0, 6);
            tableScore.Controls.Add(labelH1, 0, 7);
            tableScore.Controls.Add(labelH2, 0, 8);
            tableScore.Controls.Add(labelH3, 0, 9);
            tableScore.Controls.Add(numW1, 1, 1);
            tableScore.Controls.Add(numW2, 1, 2);
            tableScore.Controls.Add(numW3, 1, 3);
            tableScore.Controls.Add(numW4, 1, 4);
            tableScore.Controls.Add(numW5, 1, 5);
            tableScore.Controls.Add(numW6, 1, 6);
            tableScore.Controls.Add(numH1, 1, 7);
            tableScore.Controls.Add(numH2, 1, 8);
            tableScore.Controls.Add(numH3, 1, 9);
            tableScore.Location = new Point(12, 52);
            tableScore.Name = "tableScore";
            tableScore.RowCount = 10;
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableScore.Size = new Size(260, 297);
            tableScore.TabIndex = 6;
            // 
            // labelW2
            // 
            labelW2.Anchor = AnchorStyles.Left;
            labelW2.AutoSize = true;
            labelW2.Location = new Point(3, 65);
            labelW2.Name = "labelW2";
            labelW2.Size = new Size(44, 15);
            labelW2.TabIndex = 5;
            labelW2.Text = "Perfect";
            // 
            // labelW3
            // 
            labelW3.Anchor = AnchorStyles.Left;
            labelW3.AutoSize = true;
            labelW3.Location = new Point(3, 94);
            labelW3.Name = "labelW3";
            labelW3.Size = new Size(35, 15);
            labelW3.TabIndex = 7;
            labelW3.Text = "Great";
            // 
            // labelW4
            // 
            labelW4.Anchor = AnchorStyles.Left;
            labelW4.AutoSize = true;
            labelW4.Location = new Point(3, 123);
            labelW4.Name = "labelW4";
            labelW4.Size = new Size(36, 15);
            labelW4.TabIndex = 9;
            labelW4.Text = "Good";
            // 
            // labelW5
            // 
            labelW5.Anchor = AnchorStyles.Left;
            labelW5.AutoSize = true;
            labelW5.Location = new Point(3, 152);
            labelW5.Name = "labelW5";
            labelW5.Size = new Size(27, 15);
            labelW5.TabIndex = 11;
            labelW5.Text = "Bad";
            // 
            // labelW6
            // 
            labelW6.Anchor = AnchorStyles.Left;
            labelW6.AutoSize = true;
            labelW6.Location = new Point(3, 181);
            labelW6.Name = "labelW6";
            labelW6.Size = new Size(31, 15);
            labelW6.TabIndex = 13;
            labelW6.Text = "Miss";
            // 
            // labelH1
            // 
            labelH1.Anchor = AnchorStyles.Left;
            labelH1.AutoSize = true;
            labelH1.Location = new Point(3, 210);
            labelH1.Name = "labelH1";
            labelH1.Size = new Size(52, 15);
            labelH1.TabIndex = 15;
            labelH1.Text = "Hold OK";
            // 
            // labelH2
            // 
            labelH2.Anchor = AnchorStyles.Left;
            labelH2.AutoSize = true;
            labelH2.Location = new Point(3, 239);
            labelH2.Name = "labelH2";
            labelH2.Size = new Size(60, 15);
            labelH2.TabIndex = 17;
            labelH2.Text = "Hold Miss";
            // 
            // labelH3
            // 
            labelH3.Anchor = AnchorStyles.Left;
            labelH3.AutoSize = true;
            labelH3.Location = new Point(3, 271);
            labelH3.Name = "labelH3";
            labelH3.Size = new Size(57, 15);
            labelH3.TabIndex = 19;
            labelH3.Text = "Hold Tick";
            // 
            // numW1
            // 
            numW1.Anchor = AnchorStyles.Right;
            numW1.Location = new Point(137, 32);
            numW1.Name = "numW1";
            numW1.Size = new Size(120, 23);
            numW1.TabIndex = 20;
            numW1.Maximum = decimal.MaxValue;
            numW1.ValueChanged += numW1_ValueChanged;
            // 
            // numW2
            // 
            numW2.Anchor = AnchorStyles.Right;
            numW2.Location = new Point(137, 61);
            numW2.Name = "numW2";
            numW2.Size = new Size(120, 23);
            numW2.TabIndex = 21;
            numW2.Maximum = decimal.MaxValue;
            numW2.ValueChanged += numW2_ValueChanged;
            // 
            // numW3
            // 
            numW3.Anchor = AnchorStyles.Right;
            numW3.Location = new Point(137, 90);
            numW3.Name = "numW3";
            numW3.Size = new Size(120, 23);
            numW3.TabIndex = 22;
            numW3.Maximum = decimal.MaxValue;
            numW3.ValueChanged += numW3_ValueChanged;
            // 
            // numW4
            // 
            numW4.Anchor = AnchorStyles.Right;
            numW4.Location = new Point(137, 119);
            numW4.Name = "numW4";
            numW4.Size = new Size(120, 23);
            numW4.TabIndex = 23;
            numW4.Maximum = decimal.MaxValue;
            numW4.ValueChanged += numW4_ValueChanged;
            // 
            // numW5
            // 
            numW5.Anchor = AnchorStyles.Right;
            numW5.Location = new Point(137, 148);
            numW5.Name = "numW5";
            numW5.Size = new Size(120, 23);
            numW5.TabIndex = 24;
            numW5.Maximum = decimal.MaxValue;
            numW5.ValueChanged += numW5_ValueChanged;
            // 
            // numW6
            // 
            numW6.Anchor = AnchorStyles.Right;
            numW6.Location = new Point(137, 177);
            numW6.Name = "numW6";
            numW6.Size = new Size(120, 23);
            numW6.TabIndex = 25;
            numW6.Maximum = decimal.MaxValue;
            numW6.ValueChanged += numW6_ValueChanged;
            // 
            // numH1
            // 
            numH1.Anchor = AnchorStyles.Right;
            numH1.Location = new Point(137, 206);
            numH1.Name = "numH1";
            numH1.Size = new Size(120, 23);
            numH1.TabIndex = 26;
            numH1.Maximum = decimal.MaxValue; 
            numH1.ValueChanged += numH1_ValueChanged;
            // 
            // numH2
            // 
            numH2.Anchor = AnchorStyles.Right;
            numH2.Location = new Point(137, 235);
            numH2.Name = "numH2";
            numH2.Size = new Size(120, 23);
            numH2.TabIndex = 27;
            numH2.Maximum = decimal.MaxValue;
            numH2.ValueChanged += numH2_ValueChanged;
            // 
            // numH3
            // 
            numH3.Anchor = AnchorStyles.Right;
            numH3.Location = new Point(137, 267);
            numH3.Name = "numH3";
            numH3.Size = new Size(120, 23);
            numH3.TabIndex = 28;
            numH3.Maximum = decimal.MaxValue;
            numH3.ValueChanged += numH3_ValueChanged;
            // 
            // tableSystem
            // 
            tableSystem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableSystem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableSystem.ColumnCount = 1;
            tableSystem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableSystem.Controls.Add(labelNormScoreText, 0, 0);
            tableSystem.Controls.Add(labelNormScore, 0, 1);
            tableSystem.Controls.Add(labelScoreText, 0, 2);
            tableSystem.Controls.Add(labelScore, 0, 3);
            tableSystem.Location = new Point(283, 52);
            tableSystem.Name = "tableSystem";
            tableSystem.RowCount = 4;
            tableSystem.RowStyles.Add(new RowStyle());
            tableSystem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableSystem.RowStyles.Add(new RowStyle());
            tableSystem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableSystem.Size = new Size(189, 110);
            tableSystem.TabIndex = 7;
            // 
            // labelNormScoreText
            // 
            labelNormScoreText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNormScoreText.AutoSize = true;
            labelNormScoreText.Location = new Point(3, 0);
            labelNormScoreText.Name = "labelNormScoreText";
            labelNormScoreText.Size = new Size(36, 15);
            labelNormScoreText.TabIndex = 0;
            labelNormScoreText.Text = "Score";
            // 
            // labelNormScore
            // 
            labelNormScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNormScore.AutoSize = true;
            labelNormScore.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNormScore.Location = new Point(162, 15);
            labelNormScore.Name = "labelNormScore";
            labelNormScore.Size = new Size(24, 28);
            labelNormScore.TabIndex = 1;
            labelNormScore.Text = "0";
            // 
            // labelScoreText
            // 
            labelScoreText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelScoreText.AutoSize = true;
            labelScoreText.Location = new Point(3, 55);
            labelScoreText.Name = "labelScoreText";
            labelScoreText.Size = new Size(61, 15);
            labelScoreText.TabIndex = 2;
            labelScoreText.Text = "Raw Score";
            // 
            // labelScore
            // 
            labelScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(162, 70);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(24, 28);
            labelScore.TabIndex = 3;
            labelScore.Text = "0";
            // 
            // FormScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(tableSystem);
            Controls.Add(tableScore);
            Controls.Add(labelTitle);
            MinimumSize = new Size(500, 400);
            Name = "FormScore";
            Text = "Form1";
            Load += Form1_Load;
            tableScore.ResumeLayout(false);
            tableScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numW1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numW2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numW3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numW4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numW5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numW6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numH1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numH2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numH3).EndInit();
            tableSystem.ResumeLayout(false);
            tableSystem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelScoreSystem;
        private ComboBox comboScoreSystem;
        private Label labelW1;
        private Label labelTitle;
        private TableLayoutPanel tableScore;
        private Label labelH3;
        private Label labelW6;
        private Label labelW5;
        private Label labelW4;
        private Label labelW3;
        private Label labelW2;
        private Label labelH1;
        private Label labelH2;
        private TableLayoutPanel tableSystem;
        private Label labelNormScoreText;
        private Label labelNormScore;
        private Label labelScoreText;
        private Label labelScore;
        private NumericUpDown numW1;
        private NumericUpDown numW2;
        private NumericUpDown numW3;
        private NumericUpDown numW4;
        private NumericUpDown numW5;
        private NumericUpDown numW6;
        private NumericUpDown numH1;
        private NumericUpDown numH2;
        private NumericUpDown numH3;
    }
}