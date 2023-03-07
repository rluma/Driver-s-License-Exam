namespace Driver_s_License_Exam
{
    partial class driversLicenseForm
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
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.resultsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.incorrectQuestionsLabel = new System.Windows.Forms.Label();
            this.lboxInc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(47, 26);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(131, 26);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(167, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // resultsButton
            // 
            this.resultsButton.Location = new System.Drawing.Point(36, 74);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(101, 23);
            this.resultsButton.TabIndex = 2;
            this.resultsButton.Text = "Read Results";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(155, 74);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(47, 114);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(45, 13);
            this.resultsLabel.TabIndex = 4;
            this.resultsLabel.Text = "Results:";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(50, 152);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(248, 23);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incorrectQuestionsLabel
            // 
            this.incorrectQuestionsLabel.AutoSize = true;
            this.incorrectQuestionsLabel.Location = new System.Drawing.Point(47, 192);
            this.incorrectQuestionsLabel.Name = "incorrectQuestionsLabel";
            this.incorrectQuestionsLabel.Size = new System.Drawing.Size(102, 13);
            this.incorrectQuestionsLabel.TabIndex = 6;
            this.incorrectQuestionsLabel.Text = "Incorrect Questions:";
            // 
            // lboxInc
            // 
            this.lboxInc.FormattingEnabled = true;
            this.lboxInc.Location = new System.Drawing.Point(50, 225);
            this.lboxInc.Name = "lboxInc";
            this.lboxInc.Size = new System.Drawing.Size(248, 121);
            this.lboxInc.TabIndex = 7;
            // 
            // driversLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 367);
            this.Controls.Add(this.lboxInc);
            this.Controls.Add(this.incorrectQuestionsLabel);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.fileNameLabel);
            this.Name = "driversLicenseForm";
            this.Text = "Driver\'s License Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label incorrectQuestionsLabel;
        private System.Windows.Forms.ListBox lboxInc;
    }
}

