namespace StringArtDesigner
{
    partial class FormBase
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
            if (disposing && (components != null)) {
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
            this.panelWindowTitle = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnPrevStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.lblNextStep = new System.Windows.Forms.Label();
            this.lblPrevStep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentStep = new System.Windows.Forms.Label();
            this.panelWindowTitle.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindowTitle
            // 
            this.panelWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWindowTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelWindowTitle.Controls.Add(this.lblClose);
            this.panelWindowTitle.Controls.Add(this.lblTitle);
            this.panelWindowTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelWindowTitle.Location = new System.Drawing.Point(0, 0);
            this.panelWindowTitle.Name = "panelWindowTitle";
            this.panelWindowTitle.Size = new System.Drawing.Size(480, 21);
            this.panelWindowTitle.TabIndex = 0;
            this.panelWindowTitle.SizeChanged += new System.EventHandler(this.panelWindowTitle_SizeChanged);
            this.panelWindowTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDoubleClick);
            this.panelWindowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.panelWindowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            this.panelWindowTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.Location = new System.Drawing.Point(459, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 21);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(453, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDoubleClick);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.AliceBlue;
            this.panelNavigation.Controls.Add(this.btnPrevStep);
            this.panelNavigation.Controls.Add(this.btnNextStep);
            this.panelNavigation.Controls.Add(this.lblNextStep);
            this.panelNavigation.Controls.Add(this.lblPrevStep);
            this.panelNavigation.Controls.Add(this.label1);
            this.panelNavigation.Controls.Add(this.lblCurrentStep);
            this.panelNavigation.Location = new System.Drawing.Point(0, 23);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(480, 29);
            this.panelNavigation.TabIndex = 1;
            this.panelNavigation.SizeChanged += new System.EventHandler(this.panelNavigation_SizeChanged);
            // 
            // btnPrevStep
            // 
            this.btnPrevStep.BackgroundImage = global::StringArtDesigner.Properties.Resources.left;
            this.btnPrevStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevStep.FlatAppearance.BorderSize = 0;
            this.btnPrevStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevStep.Location = new System.Drawing.Point(3, 2);
            this.btnPrevStep.Name = "btnPrevStep";
            this.btnPrevStep.Size = new System.Drawing.Size(20, 20);
            this.btnPrevStep.TabIndex = 2;
            this.btnPrevStep.UseVisualStyleBackColor = true;
            this.btnPrevStep.VisibleChanged += new System.EventHandler(this.btnPrevStep_VisibleChanged);
            // 
            // btnNextStep
            // 
            this.btnNextStep.BackgroundImage = global::StringArtDesigner.Properties.Resources.right;
            this.btnNextStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextStep.FlatAppearance.BorderSize = 0;
            this.btnNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextStep.Location = new System.Drawing.Point(457, 2);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(20, 20);
            this.btnNextStep.TabIndex = 2;
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.VisibleChanged += new System.EventHandler(this.btnNextStep_VisibleChanged);
            // 
            // lblNextStep
            // 
            this.lblNextStep.AutoSize = true;
            this.lblNextStep.Location = new System.Drawing.Point(390, 4);
            this.lblNextStep.Name = "lblNextStep";
            this.lblNextStep.Size = new System.Drawing.Size(67, 17);
            this.lblNextStep.TabIndex = 3;
            this.lblNextStep.Text = "Next step";
            this.lblNextStep.SizeChanged += new System.EventHandler(this.lblNextStep_SizeChanged);
            // 
            // lblPrevStep
            // 
            this.lblPrevStep.AutoSize = true;
            this.lblPrevStep.Location = new System.Drawing.Point(25, 4);
            this.lblPrevStep.Name = "lblPrevStep";
            this.lblPrevStep.Size = new System.Drawing.Size(94, 17);
            this.lblPrevStep.TabIndex = 3;
            this.lblPrevStep.Text = "Previous step";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 2);
            this.label1.TabIndex = 2;
            // 
            // lblCurrentStep
            // 
            this.lblCurrentStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrentStep.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentStep.Name = "lblCurrentStep";
            this.lblCurrentStep.Size = new System.Drawing.Size(480, 23);
            this.lblCurrentStep.TabIndex = 3;
            this.lblCurrentStep.Text = "Current";
            this.lblCurrentStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(480, 374);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelWindowTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBase";
            this.Text = "String Art Designer";
            this.panelWindowTitle.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindowTitle;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentStep;
        private System.Windows.Forms.Label lblNextStep;
        private System.Windows.Forms.Label lblPrevStep;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnPrevStep;
    }
}

