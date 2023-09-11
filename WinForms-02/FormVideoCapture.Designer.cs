namespace WinForms_02
{
    partial class FormVideoCapture
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
            comboDevice = new ComboBox();
            btnStart = new Button();
            btnCapture = new Button();
            btnSave = new Button();
            btnExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            picPreview = new PictureBox();
            picCaptured = new PictureBox();
            btnClear = new Button();
            bgwRender = new System.ComponentModel.BackgroundWorker();
            labelSavedImage = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCaptured).BeginInit();
            SuspendLayout();
            // 
            // comboDevice
            // 
            comboDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDevice.FormattingEnabled = true;
            comboDevice.Location = new Point(12, 12);
            comboDevice.Name = "comboDevice";
            comboDevice.Size = new Size(198, 23);
            comboDevice.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(216, 11);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(297, 12);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(75, 23);
            btnCapture.TabIndex = 2;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(378, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save Image";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Location = new Point(537, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(picPreview, 0, 0);
            tableLayoutPanel1.Controls.Add(picCaptured, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(600, 288);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // picPreview
            // 
            picPreview.Dock = DockStyle.Fill;
            picPreview.Location = new Point(3, 3);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(294, 282);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 7;
            picPreview.TabStop = false;
            // 
            // picCaptured
            // 
            picCaptured.Dock = DockStyle.Fill;
            picCaptured.Location = new Point(303, 3);
            picCaptured.Name = "picCaptured";
            picCaptured.Size = new Size(294, 282);
            picCaptured.SizeMode = PictureBoxSizeMode.Zoom;
            picCaptured.TabIndex = 8;
            picCaptured.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(469, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // bgwRender
            // 
            bgwRender.WorkerReportsProgress = true;
            bgwRender.WorkerSupportsCancellation = true;
            bgwRender.DoWork += bgwRender_DoWork;
            bgwRender.ProgressChanged += bgwRender_ProgressChanged;
            // 
            // labelSavedImage
            // 
            labelSavedImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSavedImage.AutoSize = true;
            labelSavedImage.Location = new Point(12, 337);
            labelSavedImage.Name = "labelSavedImage";
            labelSavedImage.Size = new Size(0, 15);
            labelSavedImage.TabIndex = 7;
            // 
            // FormVideoCapture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 361);
            Controls.Add(labelSavedImage);
            Controls.Add(btnClear);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnCapture);
            Controls.Add(btnStart);
            Controls.Add(comboDevice);
            MinimumSize = new Size(640, 400);
            Name = "FormVideoCapture";
            Text = "Video Capture";
            FormClosing += FormVideoCapture_FormClosing;
            Load += FormVideoCapture_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCaptured).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboDevice;
        private Button btnStart;
        private Button btnCapture;
        private Button btnSave;
        private Button btnExit;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClear;
        private System.ComponentModel.BackgroundWorker bgwRender;
        private PictureBox picPreview;
        private PictureBox picCaptured;
        private Label labelSavedImage;
    }
}