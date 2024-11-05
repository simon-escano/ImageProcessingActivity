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
            chosenImage = new PictureBox();
            chooseImage = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            chosenPanel = new TableLayoutPanel();
            backgroundPanel = new TableLayoutPanel();
            chosenBackground = new PictureBox();
            chooseBackground = new Button();
            processedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)processed).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chosenImage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            chosenPanel.SuspendLayout();
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
            processedPanel.Size = new Size(494, 523);
            processedPanel.TabIndex = 5;
            // 
            // processed
            // 
            processed.BorderStyle = BorderStyle.FixedSingle;
            processed.Dock = DockStyle.Fill;
            processed.Location = new Point(8, 8);
            processed.Margin = new Padding(0);
            processed.Name = "processed";
            processed.Size = new Size(478, 478);
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
            tableLayoutPanel2.Location = new Point(8, 486);
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
            feature.Dock = DockStyle.Fill;
            feature.DropDownStyle = ComboBoxStyle.DropDownList;
            feature.FormattingEnabled = true;
            feature.Items.AddRange(new object[] { "Basic Copy", "Color Inversion", "Greyscale", "Histogram", "Sepia", "Subtraction" });
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
            imagePanel.Controls.Add(chosenImage, 0, 0);
            imagePanel.Controls.Add(chooseImage, 1, 0);
            imagePanel.Dock = DockStyle.Fill;
            imagePanel.Location = new Point(0, 0);
            imagePanel.Margin = new Padding(0);
            imagePanel.Name = "imagePanel";
            imagePanel.Padding = new Padding(8);
            imagePanel.RowCount = 2;
            imagePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            imagePanel.RowStyles.Add(new RowStyle());
            imagePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            imagePanel.Size = new Size(247, 261);
            imagePanel.TabIndex = 4;
            // 
            // chosenImage
            // 
            chosenImage.BorderStyle = BorderStyle.FixedSingle;
            chosenImage.Dock = DockStyle.Fill;
            chosenImage.Location = new Point(8, 8);
            chosenImage.Margin = new Padding(0);
            chosenImage.Name = "chosenImage";
            chosenImage.Size = new Size(231, 216);
            chosenImage.SizeMode = PictureBoxSizeMode.Zoom;
            chosenImage.TabIndex = 1;
            chosenImage.TabStop = false;
            // 
            // chooseImage
            // 
            chooseImage.Dock = DockStyle.Fill;
            chooseImage.Location = new Point(8, 224);
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
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(789, 571);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // chosenPanel
            // 
            chosenPanel.ColumnCount = 1;
            chosenPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            chosenPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            chosenPanel.Controls.Add(imagePanel, 0, 0);
            chosenPanel.Controls.Add(backgroundPanel, 0, 1);
            chosenPanel.Dock = DockStyle.Fill;
            chosenPanel.Location = new Point(24, 24);
            chosenPanel.Margin = new Padding(0);
            chosenPanel.Name = "chosenPanel";
            chosenPanel.RowCount = 2;
            chosenPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            chosenPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            chosenPanel.Size = new Size(247, 523);
            chosenPanel.TabIndex = 7;
            // 
            // backgroundPanel
            // 
            backgroundPanel.ColumnCount = 1;
            backgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            backgroundPanel.Controls.Add(chosenBackground, 0, 0);
            backgroundPanel.Controls.Add(chooseBackground, 1, 0);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Enabled = false;
            backgroundPanel.Location = new Point(0, 261);
            backgroundPanel.Margin = new Padding(0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Padding = new Padding(8);
            backgroundPanel.RowCount = 2;
            backgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            backgroundPanel.RowStyles.Add(new RowStyle());
            backgroundPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            backgroundPanel.Size = new Size(247, 262);
            backgroundPanel.TabIndex = 6;
            // 
            // chosenBackground
            // 
            chosenBackground.BorderStyle = BorderStyle.FixedSingle;
            chosenBackground.Dock = DockStyle.Fill;
            chosenBackground.Location = new Point(8, 8);
            chosenBackground.Margin = new Padding(0);
            chosenBackground.Name = "chosenBackground";
            chosenBackground.Size = new Size(231, 217);
            chosenBackground.SizeMode = PictureBoxSizeMode.Zoom;
            chosenBackground.TabIndex = 1;
            chosenBackground.TabStop = false;
            // 
            // chooseBackground
            // 
            chooseBackground.Dock = DockStyle.Fill;
            chooseBackground.Location = new Point(8, 225);
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
            Load += Form1_Load;
            processedPanel.ResumeLayout(false);
            processedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)processed).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chosenImage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            chosenPanel.ResumeLayout(false);
            backgroundPanel.ResumeLayout(false);
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
    }
}
