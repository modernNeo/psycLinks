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
            this.SuspendLayout();
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(59, 81);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(259, 20);
            this.txtBoxID.TabIndex = 3;
            // 
            // txtBoxDef
            // 
            this.txtBoxDef.Location = new System.Drawing.Point(76, 55);
            this.txtBoxDef.Name = "txtBoxDef";
            this.txtBoxDef.Size = new System.Drawing.Size(77, 20);
            this.txtBoxDef.TabIndex = 1;
            // 
            // txtBoxMSCS
            // 
            this.txtBoxMSCS.Location = new System.Drawing.Point(203, 55);
            this.txtBoxMSCS.Name = "txtBoxMSCS";
            this.txtBoxMSCS.Size = new System.Drawing.Size(115, 20);
            this.txtBoxMSCS.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(10, 107);
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
            this.labelDefinition.Location = new System.Drawing.Point(19, 59);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(51, 13);
            this.labelDefinition.TabIndex = 4;
            this.labelDefinition.Text = "Definition";
            // 
            // labelMSCS
            // 
            this.labelMSCS.AutoSize = true;
            this.labelMSCS.Location = new System.Drawing.Point(160, 58);
            this.labelMSCS.Name = "labelMSCS";
            this.labelMSCS.Size = new System.Drawing.Size(37, 13);
            this.labelMSCS.TabIndex = 5;
            this.labelMSCS.Text = "MSCS";
            // 
            // labelLabID
            // 
            this.labelLabID.AutoSize = true;
            this.labelLabID.Location = new System.Drawing.Point(16, 84);
            this.labelLabID.Name = "labelLabID";
            this.labelLabID.Size = new System.Drawing.Size(41, 13);
            this.labelLabID.TabIndex = 6;
            this.labelLabID.Text = "LAB ID";
            // 
            // buttonFirstLink
            // 
            this.buttonFirstLink.Location = new System.Drawing.Point(10, 167);
            this.buttonFirstLink.Name = "buttonFirstLink";
            this.buttonFirstLink.Size = new System.Drawing.Size(143, 23);
            this.buttonFirstLink.TabIndex = 7;
            this.buttonFirstLink.Text = "First Link - Consent";
            this.buttonFirstLink.UseVisualStyleBackColor = true;
            this.buttonFirstLink.Visible = false;
            this.buttonFirstLink.Click += new System.EventHandler(this.buttonFirstLink_Click);
            // 
            // buttonSecondLink
            // 
            this.buttonSecondLink.Location = new System.Drawing.Point(162, 169);
            this.buttonSecondLink.Name = "buttonSecondLink";
            this.buttonSecondLink.Size = new System.Drawing.Size(156, 21);
            this.buttonSecondLink.TabIndex = 8;
            this.buttonSecondLink.UseVisualStyleBackColor = true;
            this.buttonSecondLink.Visible = false;
            this.buttonSecondLink.Click += new System.EventHandler(this.buttonSecondLink_Click);
            // 
            // buttonThirdLink
            // 
            this.buttonThirdLink.Location = new System.Drawing.Point(10, 194);
            this.buttonThirdLink.Name = "buttonThirdLink";
            this.buttonThirdLink.Size = new System.Drawing.Size(143, 23);
            this.buttonThirdLink.TabIndex = 9;
            this.buttonThirdLink.UseVisualStyleBackColor = true;
            this.buttonThirdLink.Visible = false;
            this.buttonThirdLink.Click += new System.EventHandler(this.buttonThirdLink_Click);
            // 
            // buttonFourthLink
            // 
            this.buttonFourthLink.Location = new System.Drawing.Point(162, 194);
            this.buttonFourthLink.Name = "buttonFourthLink";
            this.buttonFourthLink.Size = new System.Drawing.Size(156, 23);
            this.buttonFourthLink.TabIndex = 10;
            this.buttonFourthLink.Text = "Fourth Link - Direct Questions";
            this.buttonFourthLink.UseVisualStyleBackColor = true;
            this.buttonFourthLink.Visible = false;
            this.buttonFourthLink.Click += new System.EventHandler(this.buttonFourthLink_Click);
            // 
            // buttonFifthLink
            // 
            this.buttonFifthLink.Location = new System.Drawing.Point(10, 223);
            this.buttonFifthLink.Name = "buttonFifthLink";
            this.buttonFifthLink.Size = new System.Drawing.Size(143, 23);
            this.buttonFifthLink.TabIndex = 11;
            this.buttonFifthLink.Text = "Fifth Link - Demographics";
            this.buttonFifthLink.UseVisualStyleBackColor = true;
            this.buttonFifthLink.Visible = false;
            this.buttonFifthLink.Click += new System.EventHandler(this.buttonFifthLink_Click);
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Location = new System.Drawing.Point(13, 13);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 13);
            this.labelErrors.TabIndex = 13;
            // 
            // labelID
            // 
            this.labelID.BackColor = this.BackColor;
            this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelID.Location = new System.Drawing.Point(10, 150);
            this.labelID.Name = "labelID";
            this.labelID.ReadOnly = true;
            this.labelID.Size = new System.Drawing.Size(308, 13);
            this.labelID.TabIndex = 14;
            this.labelID.TabStop = false;
            this.labelID.Visible = false;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(10, 253);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(308, 23);
            this.doneButton.TabIndex = 15;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Visible = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // buttonDebriefing
            // 
            this.buttonDebriefing.Location = new System.Drawing.Point(160, 224);
            this.buttonDebriefing.Name = "buttonDebriefing";
            this.buttonDebriefing.Size = new System.Drawing.Size(158, 23);
            this.buttonDebriefing.TabIndex = 16;
            this.buttonDebriefing.Text = "Debriefing";
            this.buttonDebriefing.UseVisualStyleBackColor = true;
            this.buttonDebriefing.Visible = false;
            this.buttonDebriefing.Click += new System.EventHandler(this.buttonDebriefing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 290);
            this.Controls.Add(this.buttonDebriefing);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.buttonFifthLink);
            this.Controls.Add(this.buttonFourthLink);
            this.Controls.Add(this.buttonThirdLink);
            this.Controls.Add(this.buttonSecondLink);
            this.Controls.Add(this.buttonFirstLink);
            this.Controls.Add(this.labelLabID);
            this.Controls.Add(this.labelMSCS);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.txtBoxMSCS);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxDef);
            this.Controls.Add(this.txtBoxID);
            this.Name = "Form1";
            this.Text = "Psychology Link Provider";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

