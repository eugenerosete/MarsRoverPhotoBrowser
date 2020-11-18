namespace MarsRoverPhotoBrowser
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
            this.components = new System.ComponentModel.Container();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbImage = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btLoadDatesFile = new System.Windows.Forms.Button();
            this.txtDatesFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInvalidDates = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Location = new System.Drawing.Point(28, 243);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(428, 249);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.DoubleClick += new System.EventHandler(this.LoadImageInBrowser);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date:";
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(28, 133);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(175, 21);
            this.cmbDate.TabIndex = 2;
            this.cmbDate.SelectedValueChanged += new System.EventHandler(this.UpdateImagesList);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Image:";
            // 
            // cmbImage
            // 
            this.cmbImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImage.FormattingEnabled = true;
            this.cmbImage.Location = new System.Drawing.Point(30, 184);
            this.cmbImage.Name = "cmbImage";
            this.cmbImage.Size = new System.Drawing.Size(426, 21);
            this.cmbImage.TabIndex = 4;
            this.cmbImage.SelectedIndexChanged += new System.EventHandler(this.cmbImage_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 504);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // btLoadDatesFile
            // 
            this.btLoadDatesFile.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btLoadDatesFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadDatesFile.ForeColor = System.Drawing.Color.White;
            this.btLoadDatesFile.Location = new System.Drawing.Point(27, 69);
            this.btLoadDatesFile.Name = "btLoadDatesFile";
            this.btLoadDatesFile.Size = new System.Drawing.Size(85, 23);
            this.btLoadDatesFile.TabIndex = 6;
            this.btLoadDatesFile.Text = "Load dates";
            this.btLoadDatesFile.UseVisualStyleBackColor = false;
            this.btLoadDatesFile.Click += new System.EventHandler(this.btLoadDatesFile_Click);
            // 
            // txtDatesFile
            // 
            this.txtDatesFile.BackColor = System.Drawing.Color.White;
            this.txtDatesFile.Location = new System.Drawing.Point(27, 43);
            this.txtDatesFile.Name = "txtDatesFile";
            this.txtDatesFile.ReadOnly = true;
            this.txtDatesFile.Size = new System.Drawing.Size(429, 20);
            this.txtDatesFile.TabIndex = 7;
            this.txtDatesFile.Click += new System.EventHandler(this.txtDatesFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Image Preview";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select file with list of dates:";
            // 
            // lblInvalidDates
            // 
            this.lblInvalidDates.AutoSize = true;
            this.lblInvalidDates.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDates.Location = new System.Drawing.Point(209, 136);
            this.lblInvalidDates.Name = "lblInvalidDates";
            this.lblInvalidDates.Size = new System.Drawing.Size(198, 13);
            this.lblInvalidDates.TabIndex = 10;
            this.lblInvalidDates.Text = "Note: Some invalid dates were removed!";
            this.lblInvalidDates.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(115, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "(double click on the image to open in browser)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(480, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInvalidDates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatesFile);
            this.Controls.Add(this.btLoadDatesFile);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.cmbImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.MinimumSize = new System.Drawing.Size(496, 543);
            this.Name = "Form1";
            this.Text = "Mars Rover Photo Browser";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbImage;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btLoadDatesFile;
        private System.Windows.Forms.TextBox txtDatesFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInvalidDates;
        private System.Windows.Forms.Label label5;
    }
}

