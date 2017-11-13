namespace Revit_Unwrapper
{
    partial class Unwrap
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
            this.okUnwrap = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.Button();
            this.destinationFolder = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.okWrap = new System.Windows.Forms.Button();
            this.selectDestinationWrap = new System.Windows.Forms.Button();
            this.selectOrigin = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // okUnwrap
            // 
            this.okUnwrap.Location = new System.Drawing.Point(3, 175);
            this.okUnwrap.Name = "okUnwrap";
            this.okUnwrap.Size = new System.Drawing.Size(120, 32);
            this.okUnwrap.TabIndex = 0;
            this.okUnwrap.Text = "Ok";
            this.okUnwrap.UseVisualStyleBackColor = true;
            this.okUnwrap.Click += new System.EventHandler(this.okUnwrap_click);
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(3, 3);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(120, 32);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // destinationFolder
            // 
            this.destinationFolder.Location = new System.Drawing.Point(3, 89);
            this.destinationFolder.Name = "destinationFolder";
            this.destinationFolder.Size = new System.Drawing.Size(120, 32);
            this.destinationFolder.TabIndex = 1;
            this.destinationFolder.Text = "Destination";
            this.destinationFolder.UseVisualStyleBackColor = true;
            this.destinationFolder.Click += new System.EventHandler(this.destinationFolder_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 236);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.selectFile);
            this.tabPage1.Controls.Add(this.okUnwrap);
            this.tabPage1.Controls.Add(this.destinationFolder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unwrap";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.okWrap);
            this.tabPage2.Controls.Add(this.selectDestinationWrap);
            this.tabPage2.Controls.Add(this.selectOrigin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(369, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wrap";
            // 
            // okWrap
            // 
            this.okWrap.Location = new System.Drawing.Point(3, 175);
            this.okWrap.Name = "okWrap";
            this.okWrap.Size = new System.Drawing.Size(120, 32);
            this.okWrap.TabIndex = 3;
            this.okWrap.Text = "Ok";
            this.okWrap.UseVisualStyleBackColor = true;
            this.okWrap.Click += new System.EventHandler(this.okWrap_Click);
            // 
            // selectDestinationWrap
            // 
            this.selectDestinationWrap.Location = new System.Drawing.Point(3, 89);
            this.selectDestinationWrap.Name = "selectDestinationWrap";
            this.selectDestinationWrap.Size = new System.Drawing.Size(120, 32);
            this.selectDestinationWrap.TabIndex = 3;
            this.selectDestinationWrap.Text = "Select Destination";
            this.selectDestinationWrap.UseVisualStyleBackColor = true;
            this.selectDestinationWrap.Click += new System.EventHandler(this.selectDestinationWrap_Click);
            // 
            // selectOrigin
            // 
            this.selectOrigin.Location = new System.Drawing.Point(3, 3);
            this.selectOrigin.Name = "selectOrigin";
            this.selectOrigin.Size = new System.Drawing.Size(120, 32);
            this.selectOrigin.TabIndex = 3;
            this.selectOrigin.Text = "Select origin";
            this.selectOrigin.UseVisualStyleBackColor = true;
            this.selectOrigin.Click += new System.EventHandler(this.selectOrigin_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(254, 271);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 32);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(188, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(170, 146);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Select a revit file to decompress and a folder where to save the resulting files";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(193, 13);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(170, 146);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Select a folder containing a decompresed Revit file and a destination to save it";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Unwrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 334);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Unwrap";
            this.Text = "Unwrapper";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okUnwrap;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Button destinationFolder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button okWrap;
        private System.Windows.Forms.Button selectDestinationWrap;
        private System.Windows.Forms.Button selectOrigin;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

