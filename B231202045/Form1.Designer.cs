/******************************************************************************
 *                    OBJECT ORIENTED PROGRAMMING PROJECT                     *
 ****************************************************************************** 
 * Student Name   : Berkan                                                    *
 * Student Surname: Akten                                                     *
 * Student Number : B231202045                                                *
 * Lecturer       : Gülüzar Çit                                               *
 * Course Name    : OBJECT ORIENTED PROGRAMMING                               *
 * Assignment     : Term Project                                              *
 * Date Submitted : 15.05.2025                                                *
 ******************************************************************************/

namespace B231202045
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.listBoxVertices = new System.Windows.Forms.ListBox();
            this.checkBoxCCW = new System.Windows.Forms.CheckBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.textBoxEdges = new System.Windows.Forms.TextBox();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Angle";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Edge";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Blue";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonRotate);
            this.groupBox1.Controls.Add(this.listBoxVertices);
            this.groupBox1.Controls.Add(this.checkBoxCCW);
            this.groupBox1.Controls.Add(this.buttonDraw);
            this.groupBox1.Controls.Add(this.textBoxAngle);
            this.groupBox1.Controls.Add(this.textBoxEdges);
            this.groupBox1.Controls.Add(this.trackBarB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackBarG);
            this.groupBox1.Controls.Add(this.trackBarR);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.textBoxY);
            this.groupBox1.Controls.Add(this.textBoxLength);
            this.groupBox1.Location = new System.Drawing.Point(679, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 657);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonReset.Location = new System.Drawing.Point(51, 578);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(181, 44);
            this.buttonReset.TabIndex = 22;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRotate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRotate.Location = new System.Drawing.Point(51, 528);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(181, 44);
            this.buttonRotate.TabIndex = 21;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = false;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // listBoxVertices
            // 
            this.listBoxVertices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxVertices.FormattingEnabled = true;
            this.listBoxVertices.ItemHeight = 16;
            this.listBoxVertices.Items.AddRange(new object[] {
            "    Edge Coordinates",
            "------------------------------------------------------------------------",
            ""});
            this.listBoxVertices.Location = new System.Drawing.Point(51, 357);
            this.listBoxVertices.Name = "listBoxVertices";
            this.listBoxVertices.Size = new System.Drawing.Size(188, 116);
            this.listBoxVertices.TabIndex = 20;
            // 
            // checkBoxCCW
            // 
            this.checkBoxCCW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCCW.AutoSize = true;
            this.checkBoxCCW.Location = new System.Drawing.Point(180, 274);
            this.checkBoxCCW.Name = "checkBoxCCW";
            this.checkBoxCCW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCCW.Size = new System.Drawing.Size(60, 20);
            this.checkBoxCCW.TabIndex = 12;
            this.checkBoxCCW.Text = "CCW";
            this.checkBoxCCW.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            this.buttonDraw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDraw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDraw.Location = new System.Drawing.Point(51, 478);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(181, 44);
            this.buttonDraw.TabIndex = 15;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = false;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(145, 310);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(69, 22);
            this.textBoxAngle.TabIndex = 19;
            this.textBoxAngle.Text = "30";
            this.textBoxAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEdges
            // 
            this.textBoxEdges.Location = new System.Drawing.Point(127, 269);
            this.textBoxEdges.Name = "textBoxEdges";
            this.textBoxEdges.Size = new System.Drawing.Size(45, 22);
            this.textBoxEdges.TabIndex = 18;
            this.textBoxEdges.Text = "5";
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(118, 218);
            this.trackBarB.Maximum = 256;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(114, 56);
            this.trackBarB.TabIndex = 17;
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(118, 171);
            this.trackBarG.Maximum = 256;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(114, 56);
            this.trackBarG.TabIndex = 16;
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(118, 129);
            this.trackBarR.Maximum = 256;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(114, 56);
            this.trackBarR.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Green";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Red";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Length";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Center(x,y)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(118, 29);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(45, 22);
            this.textBoxX.TabIndex = 10;
            this.textBoxX.Text = "0";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(187, 29);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(45, 22);
            this.textBoxY.TabIndex = 9;
            this.textBoxY.Text = "0\r\n";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(145, 77);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(54, 22);
            this.textBoxLength.TabIndex = 8;
            this.textBoxLength.Text = "4";
            this.textBoxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 691);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 757);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.MaskedTextBox textBoxLength;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TextBox textBoxEdges;
        private System.Windows.Forms.CheckBox checkBoxCCW;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.ListBox listBoxVertices;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRotate;
    }
}

