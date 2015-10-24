using System.Windows.Forms;

namespace Psychology_Link_Provider
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
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxDef = new System.Windows.Forms.TextBox();
            this.txtBoxMSCS = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.labelMSCS = new System.Windows.Forms.Label();
            this.labelLabID = new System.Windows.Forms.Label();
            this.buttonFirstLink = new System.Windows.Forms.Button();
            this.buttonSecondLink = new System.Windows.Forms.Button();
            this.buttonThirdLink = new System.Windows.Forms.Button();
            this.buttonFourthLink = new System.Windows.Forms.Button();
            this.buttonFifthLink = new System.Windows.Forms.Button();
            this.labelErrors = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.buttonDebriefing = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.GroupBox();
            this.inputBox.SuspendLayout();
            this.outputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(55, 57);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(259, 20);
            this.txtBoxID.TabIndex = 3;
            // 
            // txtBoxDef
            // 
            this.txtBoxDef.Location = new System.Drawing.Point(72, 31);
            this.txtBoxDef.Name = "txtBoxDef";
            this.txtBoxDef.Size = new System.Drawing.Size(77, 20);
            this.txtBoxDef.TabIndex = 1;
            // 
            // txtBoxMSCS
            // 
            this.txtBoxMSCS.Location = new System.Drawing.Point(199, 31);
            this.txtBoxMSCS.Name = "txtBoxMSCS";
            this.txtBoxMSCS.Size = new System.Drawing.Size(115, 20);
            this.txtBoxMSCS.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(6, 83);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(308, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Location = new System.Drawing.Point(15, 35);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(51, 13);
            this.labelDefinition.TabIndex = 4;
            this.labelDefinition.Text = "Definition";
            // 
            // labelMSCS
            // 
            this.labelMSCS.AutoSize = true;
            this.labelMSCS.Location = new System.Drawing.Point(156, 34);
            this.labelMSCS.Name = "labelMSCS";
            this.labelMSCS.Size = new System.Drawing.Size(37, 13);
            this.labelMSCS.TabIndex = 5;
            this.labelMSCS.Text = "MSCS";
            // 
            // labelLabID
            // 
            this.labelLabID.AutoSize = true;
            this.labelLabID.Location = new System.Drawing.Point(12, 60);
            this.labelLabID.Name = "labelLabID";
            this.labelLabID.Size = new System.Drawing.Size(41, 13);
            this.labelLabID.TabIndex = 6;
            this.labelLabID.Text = "LAB ID";
            // 
            // buttonFirstLink
            // 
            this.buttonFirstLink.Location = new System.Drawing.Point(6, 34);
            this.buttonFirstLink.Name = "buttonFirstLink";
            this.buttonFirstLink.Size = new System.Drawing.Size(143, 23);
            this.buttonFirstLink.TabIndex = 7;
            this.buttonFirstLink.Text = "First Link - Consent";
            this.buttonFirstLink.UseVisualStyleBackColor = true;
            this.buttonFirstLink.Click += new System.EventHandler(this.buttonFirstLink_Click);
            // 
            // buttonSecondLink
            // 
            this.buttonSecondLink.Location = new System.Drawing.Point(158, 36);
            this.buttonSecondLink.Name = "buttonSecondLink";
            this.buttonSecondLink.Size = new System.Drawing.Size(156, 21);
            this.buttonSecondLink.TabIndex = 8;
            this.buttonSecondLink.UseVisualStyleBackColor = true;
            this.buttonSecondLink.Click += new System.EventHandler(this.buttonSecondLink_Click);
            // 
            // buttonThirdLink
            // 
            this.buttonThirdLink.Location = new System.Drawing.Point(6, 61);
            this.buttonThirdLink.Name = "buttonThirdLink";
            this.buttonThirdLink.Size = new System.Drawing.Size(143, 23);
            this.buttonThirdLink.TabIndex = 9;
            this.buttonThirdLink.UseVisualStyleBackColor = true;
            this.buttonThirdLink.Click += new System.EventHandler(this.buttonThirdLink_Click);
            // 
            // buttonFourthLink
            // 
            this.buttonFourthLink.Location = new System.Drawing.Point(158, 61);
            this.buttonFourthLink.Name = "buttonFourthLink";
            this.buttonFourthLink.Size = new System.Drawing.Size(156, 23);
            this.buttonFourthLink.TabIndex = 10;
            this.buttonFourthLink.Text = "Fourth Link - Direct Questions";
            this.buttonFourthLink.UseVisualStyleBackColor = true;
            this.buttonFourthLink.Click += new System.EventHandler(this.buttonFourthLink_Click);
            // 
            // buttonFifthLink
            // 
            this.buttonFifthLink.Location = new System.Drawing.Point(6, 90);
            this.buttonFifthLink.Name = "buttonFifthLink";
            this.buttonFifthLink.Size = new System.Drawing.Size(143, 23);
            this.buttonFifthLink.TabIndex = 11;
            this.buttonFifthLink.Text = "Fifth Link - Demographics";
            this.buttonFifthLink.UseVisualStyleBackColor = true;
            this.buttonFifthLink.Click += new System.EventHandler(this.buttonFifthLink_Click);
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Location = new System.Drawing.Point(15, 182);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 13);
            this.labelErrors.TabIndex = 13;
            // 
            // labelID
            // 
            this.labelID.BackColor = this.BackColor;
            this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelID.Location = new System.Drawing.Point(6, 15);
            this.labelID.Name = "labelID";
            this.labelID.ReadOnly = true;
            this.labelID.Size = new System.Drawing.Size(308, 13);
            this.labelID.TabIndex = 14;
            this.labelID.TabStop = false;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(6, 120);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(308, 23);
            this.doneButton.TabIndex = 15;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // buttonDebriefing
            // 
            this.buttonDebriefing.Location = new System.Drawing.Point(156, 91);
            this.buttonDebriefing.Name = "buttonDebriefing";
            this.buttonDebriefing.Size = new System.Drawing.Size(158, 23);
            this.buttonDebriefing.TabIndex = 16;
            this.buttonDebriefing.Text = "Debriefing";
            this.buttonDebriefing.UseVisualStyleBackColor = true;
            this.buttonDebriefing.Click += new System.EventHandler(this.buttonDebriefing_Click);
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.labelDefinition);
            this.inputBox.Controls.Add(this.txtBoxID);
            this.inputBox.Controls.Add(this.txtBoxDef);
            this.inputBox.Controls.Add(this.btnSubmit);
            this.inputBox.Controls.Add(this.txtBoxMSCS);
            this.inputBox.Controls.Add(this.labelMSCS);
            this.inputBox.Controls.Add(this.labelLabID);
            this.inputBox.Location = new System.Drawing.Point(12, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(330, 167);
            this.inputBox.TabIndex = 17;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "MSCS Study Information Inputs";
            // 
            // outputBox
            // 
            this.outputBox.Controls.Add(this.buttonFirstLink);
            this.outputBox.Controls.Add(this.buttonSecondLink);
            this.outputBox.Controls.Add(this.buttonDebriefing);
            this.outputBox.Controls.Add(this.labelID);
            this.outputBox.Controls.Add(this.buttonThirdLink);
            this.outputBox.Controls.Add(this.doneButton);
            this.outputBox.Controls.Add(this.buttonFourthLink);
            this.outputBox.Controls.Add(this.buttonFifthLink);
            this.outputBox.Location = new System.Drawing.Point(348, 13);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(324, 166);
            this.outputBox.TabIndex = 18;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "MSCS Study Links";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 290);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.labelErrors);
            this.Name = "Form1";
            this.Text = "Psychology Link Provider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            this.outputBox.ResumeLayout(false);
            this.outputBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxMSCS;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.Label labelMSCS;
        private System.Windows.Forms.Label labelLabID;
        private TextBox txtBoxDef;
        private Button buttonFirstLink;
        private Button buttonSecondLink;
        private Button buttonThirdLink;
        private Button buttonFourthLink;
        private Button buttonFifthLink;
        private Label labelErrors;
        private TextBox labelID;
        private Button doneButton;
        private Button buttonDebriefing;
        private GroupBox inputBox;
        private GroupBox outputBox;
    }
}

