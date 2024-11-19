namespace ImageProcessingActivity
{
    partial class Form1
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
            processedPanel = new TableLayoutPanel();
            processed = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            feature = new ComboBox();
            go = new Button();
            export = new Button();
            imagePanel = new TableLayoutPanel();
            chosenImageText = new Label();
            chosenImage = new PictureBox();
            chooseImage = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            chosenPanel = new TableLayoutPanel();
            cameraPanel = new TableLayoutPanel();
            cameras = new ComboBox();
            toggleCamera = new Button();
            backgroundPanel = new TableLayoutPanel();
            chosenBackgroundText = new Label();
            chosenBackground = new PictureBox();
            chooseBackground = new Button();
            processedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)processed).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chosenImage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            chosenPanel.SuspendLayout();
            cameraPanel.SuspendLayout();
            backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chosenBackground).BeginInit();
            SuspendLayout();
            // 
            // processedPanel
            // 
            processedPanel.ColumnCount = 1;
            processedPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            processedPanel.Controls.Add(processed, 0, 0);
            processedPanel.Controls.Add(tableLayoutPanel2, 1, 0);
            processedPanel.Dock = DockStyle.Fill;
            processedPanel.Location = new Point(271, 24);
            processedPanel.Margin = new Padding(0);
            processedPanel.Name = "processedPanel";
            processedPanel.Padding = new Padding(8);
            processedPanel.RowCount = 2;
            processedPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            processedPanel.RowStyles.Add(new RowStyle());
            processedPanel.Size = new Size(494, 503);
            processedPanel.TabIndex = 5;
            // 
            // processed
            // 
            processed.BorderStyle = BorderStyle.FixedSingle;
            processed.Dock = DockStyle.Fill;
            processed.Location = new Point(8, 8);
            processed.Margin = new Padding(0);
            processed.Name = "processed";
            processed.Size = new Size(478, 458);
            processed.SizeMode = PictureBoxSizeMode.Zoom;
            processed.TabIndex = 0;
            processed.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(feature, 0, 0);
            tableLayoutPanel2.Controls.Add(go, 1, 0);
            tableLayoutPanel2.Controls.Add(export, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(8, 466);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(478, 29);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // feature
            // 
            feature.DisplayMember = "1";
            feature.Dock = DockStyle.Left;
            feature.DropDownStyle = ComboBoxStyle.DropDownList;
            feature.FormattingEnabled = true;
            feature.Items.AddRange(new object[] { "Basic Copy", "Color Inversion", "Greyscale", "Histogram", "Sepia", "Subtraction", "Gaussian Blur", "Sharpen", "Mean Removal", "Emboss", "Emboss Laplascian", "Horz/Vertical", "All Directions", "Lossy", "Horizontal Only", "Vertical Only", "Edge Detection", "Edge Enhance" });
            feature.Location = new Point(0, 0);
            feature.Margin = new Padding(0);
            feature.Name = "feature";
            feature.Size = new Size(328, 23);
            feature.TabIndex = 1;
            feature.SelectedIndexChanged += feature_SelectedIndexChanged;
            // 
            // go
            // 
            go.Dock = DockStyle.Fill;
            go.Location = new Point(328, 0);
            go.Margin = new Padding(0);
            go.Name = "go";
            go.Size = new Size(75, 29);
            go.TabIndex = 0;
            go.Text = "Go";
            go.UseVisualStyleBackColor = true;
            go.Click += go_Click;
            // 
            // export
            // 
            export.Dock = DockStyle.Fill;
            export.Location = new Point(403, 0);
            export.Margin = new Padding(0);
            export.Name = "export";
            export.Size = new Size(75, 29);
            export.TabIndex = 2;
            export.Text = "Export";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
            // 
            // imagePanel
            // 
            imagePanel.ColumnCount = 1;
            imagePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            imagePanel.Controls.Add(chosenImageText, 0, 0);
            imagePanel.Controls.Add(chosenImage, 0, 1);
            imagePanel.Controls.Add(chooseImage, 1, 2);
            imagePanel.Dock = DockStyle.Fill;
            imagePanel.Location = new Point(0, 29);
            imagePanel.Margin = new Padding(0);
            imagePanel.Name = "imagePanel";
            imagePanel.Padding = new Padding(8);
            imagePanel.RowCount = 2;
            imagePanel.RowStyles.Add(new RowStyle());
            imagePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            imagePanel.RowStyles.Add(new RowStyle());
            imagePanel.Size = new Size(247, 237);
            imagePanel.TabIndex = 4;
            // 
            // chosenImageText
            // 
            chosenImageText.AutoSize = true;
            chosenImageText.Location = new Point(8, 8);
            chosenImageText.Margin = new Padding(0, 0, 0, 3);
            chosenImageText.Name = "chosenImageText";
            chosenImageText.Size = new Size(103, 15);
            chosenImageText.TabIndex = 3;
            chosenImageText.Text = "No chosen image.";
            // 
            // chosenImage
            // 
            chosenImage.BorderStyle = BorderStyle.FixedSingle;
            chosenImage.Dock = DockStyle.Fill;
            chosenImage.Location = new Point(8, 26);
            chosenImage.Margin = new Padding(0);
            chosenImage.Name = "chosenImage";
            chosenImage.Size = new Size(231, 174);
            chosenImage.SizeMode = PictureBoxSizeMode.Zoom;
            chosenImage.TabIndex = 1;
            chosenImage.TabStop = false;
            // 
            // chooseImage
            // 
            chooseImage.Dock = DockStyle.Fill;
            chooseImage.Location = new Point(8, 200);
            chooseImage.Margin = new Padding(0);
            chooseImage.Name = "chooseImage";
            chooseImage.Size = new Size(231, 29);
            chooseImage.TabIndex = 2;
            chooseImage.Text = "Choose Image";
            chooseImage.UseVisualStyleBackColor = true;
            chooseImage.Click += chooseImage_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AccessibleRole = AccessibleRole.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.66667F));
            tableLayoutPanel1.Controls.Add(chosenPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(processedPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(24);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(789, 571);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // chosenPanel
            // 
            chosenPanel.ColumnCount = 1;
            chosenPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chosenPanel.Controls.Add(cameraPanel, 0, 0);
            chosenPanel.Controls.Add(imagePanel, 0, 1);
            chosenPanel.Controls.Add(backgroundPanel, 0, 2);
            chosenPanel.Dock = DockStyle.Fill;
            chosenPanel.Location = new Point(24, 24);
            chosenPanel.Margin = new Padding(0);
            chosenPanel.Name = "chosenPanel";
            chosenPanel.RowCount = 3;
            chosenPanel.RowStyles.Add(new RowStyle());
            chosenPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            chosenPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            chosenPanel.Size = new Size(247, 503);
            chosenPanel.TabIndex = 7;
            // 
            // cameraPanel
            // 
            cameraPanel.AutoSize = true;
            cameraPanel.ColumnCount = 2;
            cameraPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cameraPanel.ColumnStyles.Add(new ColumnStyle());
            cameraPanel.ColumnStyles.Add(new ColumnStyle());
            cameraPanel.Controls.Add(cameras, 0, 0);
            cameraPanel.Controls.Add(toggleCamera, 1, 0);
            cameraPanel.Dock = DockStyle.Fill;
            cameraPanel.Location = new Point(0, 0);
            cameraPanel.Margin = new Padding(0);
            cameraPanel.Name = "cameraPanel";
            cameraPanel.RowCount = 1;
            cameraPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cameraPanel.Size = new Size(247, 29);
            cameraPanel.TabIndex = 7;
            // 
            // cameras
            // 
            cameras.DisplayMember = "1";
            cameras.Dock = DockStyle.Left;
            cameras.DropDownStyle = ComboBoxStyle.DropDownList;
            cameras.FormattingEnabled = true;
            cameras.Location = new Point(0, 0);
            cameras.Margin = new Padding(0);
            cameras.Name = "cameras";
            cameras.Size = new Size(172, 23);
            cameras.TabIndex = 1;
            // 
            // toggleCamera
            // 
            toggleCamera.Dock = DockStyle.Fill;
            toggleCamera.Location = new Point(172, 0);
            toggleCamera.Margin = new Padding(0);
            toggleCamera.Name = "toggleCamera";
            toggleCamera.Size = new Size(75, 29);
            toggleCamera.TabIndex = 0;
            toggleCamera.Text = "Turn On";
            toggleCamera.UseVisualStyleBackColor = true;
            toggleCamera.Click += toggleCamera_Click;
            // 
            // backgroundPanel
            // 
            backgroundPanel.ColumnCount = 1;
            backgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            backgroundPanel.Controls.Add(chosenBackgroundText, 0, 0);
            backgroundPanel.Controls.Add(chosenBackground, 0, 1);
            backgroundPanel.Controls.Add(chooseBackground, 1, 2);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Enabled = false;
            backgroundPanel.Location = new Point(0, 266);
            backgroundPanel.Margin = new Padding(0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Padding = new Padding(8);
            backgroundPanel.RowCount = 2;
            backgroundPanel.RowStyles.Add(new RowStyle());
            backgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            backgroundPanel.RowStyles.Add(new RowStyle());
            backgroundPanel.Size = new Size(247, 237);
            backgroundPanel.TabIndex = 6;
            // 
            // chosenBackgroundText
            // 
            chosenBackgroundText.AutoSize = true;
            chosenBackgroundText.Location = new Point(8, 8);
            chosenBackgroundText.Margin = new Padding(0, 0, 0, 3);
            chosenBackgroundText.Name = "chosenBackgroundText";
            chosenBackgroundText.Size = new Size(134, 15);
            chosenBackgroundText.TabIndex = 4;
            chosenBackgroundText.Text = "No chosen background.";
            // 
            // chosenBackground
            // 
            chosenBackground.BorderStyle = BorderStyle.FixedSingle;
            chosenBackground.Dock = DockStyle.Fill;
            chosenBackground.Location = new Point(8, 26);
            chosenBackground.Margin = new Padding(0);
            chosenBackground.Name = "chosenBackground";
            chosenBackground.Size = new Size(231, 174);
            chosenBackground.SizeMode = PictureBoxSizeMode.Zoom;
            chosenBackground.TabIndex = 1;
            chosenBackground.TabStop = false;
            // 
            // chooseBackground
            // 
            chooseBackground.Dock = DockStyle.Fill;
            chooseBackground.Location = new Point(8, 200);
            chooseBackground.Margin = new Padding(0);
            chooseBackground.Name = "chooseBackground";
            chooseBackground.Size = new Size(231, 29);
            chooseBackground.TabIndex = 2;
            chooseBackground.Text = "Choose Background";
            chooseBackground.UseVisualStyleBackColor = true;
            chooseBackground.Click += chooseBackground_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 571);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Processing Activity";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            processedPanel.ResumeLayout(false);
            processedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)processed).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            imagePanel.ResumeLayout(false);
            imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chosenImage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            chosenPanel.ResumeLayout(false);
            chosenPanel.PerformLayout();
            cameraPanel.ResumeLayout(false);
            backgroundPanel.ResumeLayout(false);
            backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chosenBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel processedPanel;
        private PictureBox processed;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox feature;
        private Button go;
        private Button export;
        private TableLayoutPanel imagePanel;
        private PictureBox chosenImage;
        private Button chooseImage;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel backgroundPanel;
        private PictureBox chosenBackground;
        private Button chooseBackground;
        private TableLayoutPanel chosenPanel;
        private TableLayoutPanel cameraPanel;
        private ComboBox cameras;
        private Button toggleCamera;
        private Label chosenImageText;
        private Label chosenBackgroundText;
    }
}
