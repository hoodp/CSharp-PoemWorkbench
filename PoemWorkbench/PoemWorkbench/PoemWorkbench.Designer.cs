namespace PoemWorkbench
{
    partial class PoemWorkbench
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
            this.progressText = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoem = new System.Windows.Forms.TextBox();
            this.btnClearLast = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.listBoxPoem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressText
            // 
            this.progressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressText.Location = new System.Drawing.Point(361, 44);
            this.progressText.Maximum = 50;
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(82, 13);
            this.progressText.Step = 1;
            this.progressText.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Max. Characters: 50";
            // 
            // grpColor
            // 
            this.grpColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpColor.Controls.Add(this.radGreen);
            this.grpColor.Controls.Add(this.radBlue);
            this.grpColor.Controls.Add(this.radRed);
            this.grpColor.Location = new System.Drawing.Point(458, 61);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(85, 86);
            this.grpColor.TabIndex = 20;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Background:";
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(7, 65);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 2;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.Click += new System.EventHandler(this.radGreen_Click);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(6, 43);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 1;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.Click += new System.EventHandler(this.radBlue_Click);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(7, 20);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.Click += new System.EventHandler(this.radRed_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(458, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Line:";
            // 
            // txtPoem
            // 
            this.txtPoem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoem.Location = new System.Drawing.Point(34, 61);
            this.txtPoem.MaxLength = 55;
            this.txtPoem.Name = "txtPoem";
            this.txtPoem.Size = new System.Drawing.Size(409, 20);
            this.txtPoem.TabIndex = 12;
            this.txtPoem.TextChanged += new System.EventHandler(this.txtPoem_TextChanged);
            // 
            // btnClearLast
            // 
            this.btnClearLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLast.Location = new System.Drawing.Point(119, 311);
            this.btnClearLast.Name = "btnClearLast";
            this.btnClearLast.Size = new System.Drawing.Size(85, 30);
            this.btnClearLast.TabIndex = 15;
            this.btnClearLast.Text = "Clear &Last";
            this.btnClearLast.UseVisualStyleBackColor = true;
            this.btnClearLast.Click += new System.EventHandler(this.btnClearLast_Click);
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFont.Location = new System.Drawing.Point(458, 153);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(85, 30);
            this.btnFont.TabIndex = 18;
            this.btnFont.Text = "&Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(204, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 30);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddLine.Location = new System.Drawing.Point(34, 311);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(85, 30);
            this.btnAddLine.TabIndex = 14;
            this.btnAddLine.Text = "&Add Line";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // listBoxPoem
            // 
            this.listBoxPoem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPoem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxPoem.FormattingEnabled = true;
            this.listBoxPoem.HorizontalScrollbar = true;
            this.listBoxPoem.Location = new System.Drawing.Point(34, 87);
            this.listBoxPoem.Name = "listBoxPoem";
            this.listBoxPoem.ScrollAlwaysVisible = true;
            this.listBoxPoem.Size = new System.Drawing.Size(409, 173);
            this.listBoxPoem.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Poet Workbench";
            // 
            // PoemWorkbench
            // 
            this.AcceptButton = this.btnAddLine;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 346);
            this.Controls.Add(this.progressText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoem);
            this.Controls.Add(this.btnClearLast);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.listBoxPoem);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(590, 384);
            this.Name = "PoemWorkbench";
            this.Text = "Poem Workshop";
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoem;
        private System.Windows.Forms.Button btnClearLast;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.ListBox listBoxPoem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

