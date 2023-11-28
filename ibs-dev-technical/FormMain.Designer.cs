namespace ibs_dev_technical
{
    partial class FormMain
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
            groupBox1 = new GroupBox();
            buttonTest = new Button();
            textFileName = new TextBox();
            buttonBrowse = new Button();
            textFilePath = new TextBox();
            openFileDialogTest = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonTest);
            groupBox1.Controls.Add(textFileName);
            groupBox1.Controls.Add(buttonBrowse);
            groupBox1.Controls.Add(textFilePath);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(358, 243);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(43, 23);
            buttonTest.TabIndex = 4;
            buttonTest.Text = "Test";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // textFileName
            // 
            textFileName.Location = new Point(96, 244);
            textFileName.Name = "textFileName";
            textFileName.Size = new Size(256, 23);
            textFileName.TabIndex = 3;
            textFileName.TextChanged += textFileName_TextChanged;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(96, 92);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(305, 32);
            buttonBrowse.TabIndex = 2;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += button1_Click;
            // 
            // textFilePath
            // 
            textFilePath.Location = new Point(96, 130);
            textFilePath.Multiline = true;
            textFilePath.Name = "textFilePath";
            textFilePath.Size = new Size(305, 107);
            textFilePath.TabIndex = 1;
            textFilePath.TextChanged += textFilePath_TextChanged;
            // 
            // openFileDialogTest
            // 
            openFileDialogTest.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 382);
            Controls.Add(groupBox1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textFilePath;
        private OpenFileDialog openFileDialogTest;
        private Button buttonBrowse;
        private TextBox textFileName;
        private Button buttonTest;
    }
}
