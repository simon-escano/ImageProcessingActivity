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
            tableLayoutPanel1 = new TableLayoutPanel();
            uploaded = new PictureBox();
            processed = new PictureBox();
            upload = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            feature = new ComboBox();
            go = new Button();
            export = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uploaded).BeginInit();
            ((System.ComponentModel.ISupportInitialize)processed).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AccessibleRole = AccessibleRole.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(uploaded, 0, 0);
            tableLayoutPanel1.Controls.Add(processed, 1, 0);
            tableLayoutPanel1.Controls.Add(upload, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(24);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // uploaded
            // 
            uploaded.BorderStyle = BorderStyle.FixedSingle;
            uploaded.Dock = DockStyle.Fill;
            uploaded.Location = new Point(24, 24);
            uploaded.Margin = new Padding(0, 0, 8, 0);
            uploaded.Name = "uploaded";
            uploaded.Size = new Size(368, 357);
            uploaded.SizeMode = PictureBoxSizeMode.Zoom;
            uploaded.TabIndex = 1;
            uploaded.TabStop = false;
            // 
            // processed
            // 
            processed.BorderStyle = BorderStyle.FixedSingle;
            processed.Dock = DockStyle.Fill;
            processed.Location = new Point(408, 24);
            processed.Margin = new Padding(8, 0, 0, 0);
            processed.Name = "processed";
            processed.Size = new Size(368, 357);
            processed.SizeMode = PictureBoxSizeMode.Zoom;
            processed.TabIndex = 0;
            processed.TabStop = false;
            // 
            // upload
            // 
            upload.Dock = DockStyle.Fill;
            upload.Location = new Point(24, 397);
            upload.Margin = new Padding(0, 16, 8, 0);
            upload.Name = "upload";
            upload.Size = new Size(368, 29);
            upload.TabIndex = 2;
            upload.Text = "Upload";
            upload.UseVisualStyleBackColor = true;
            upload.Click += upload_Click;
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
            tableLayoutPanel2.Location = new Point(408, 397);
            tableLayoutPanel2.Margin = new Padding(8, 16, 0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(368, 29);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // feature
            // 
            feature.DisplayMember = "1";
            feature.Dock = DockStyle.Fill;
            feature.DropDownStyle = ComboBoxStyle.DropDownList;
            feature.FormattingEnabled = true;
            feature.Items.AddRange(new object[] { "Select feature", "Basic Copy", "Color Inversion", "Greyscale", "Histogram", "Sepia" });
            feature.Location = new Point(0, 0);
            feature.Margin = new Padding(0, 0, 4, 0);
            feature.Name = "feature";
            feature.Size = new Size(206, 23);
            feature.TabIndex = 1;
            feature.SelectedIndexChanged += feature_SelectedIndexChanged;
            // 
            // go
            // 
            go.Dock = DockStyle.Fill;
            go.Location = new Point(214, 0);
            go.Margin = new Padding(4, 0, 0, 0);
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
            export.Location = new Point(293, 0);
            export.Margin = new Padding(4, 0, 0, 0);
            export.Name = "export";
            export.Size = new Size(75, 29);
            export.TabIndex = 2;
            export.Text = "Export";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Image Processing Activity";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uploaded).EndInit();
            ((System.ComponentModel.ISupportInitialize)processed).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox processed;
        private PictureBox uploaded;
        private Button upload;
        private TableLayoutPanel tableLayoutPanel2;
        private Button go;
        private ComboBox feature;
        private Button export;
    }
}
