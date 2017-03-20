namespace CMPE1600_Lab4
{
    partial class NewPatternForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_RedRadio = new System.Windows.Forms.RadioButton();
            this.UI_GreenRadio = new System.Windows.Forms.RadioButton();
            this.UI_GreyRadio = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_OKButton = new System.Windows.Forms.Button();
            this.UI_CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_GreyRadio);
            this.groupBox1.Controls.Add(this.UI_GreenRadio);
            this.groupBox1.Controls.Add(this.UI_RedRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // UI_RedRadio
            // 
            this.UI_RedRadio.AutoSize = true;
            this.UI_RedRadio.Location = new System.Drawing.Point(6, 19);
            this.UI_RedRadio.Name = "UI_RedRadio";
            this.UI_RedRadio.Size = new System.Drawing.Size(45, 17);
            this.UI_RedRadio.TabIndex = 0;
            this.UI_RedRadio.TabStop = true;
            this.UI_RedRadio.Text = "Red";
            this.UI_RedRadio.UseVisualStyleBackColor = true;
            // 
            // UI_GreenRadio
            // 
            this.UI_GreenRadio.AutoSize = true;
            this.UI_GreenRadio.Location = new System.Drawing.Point(7, 43);
            this.UI_GreenRadio.Name = "UI_GreenRadio";
            this.UI_GreenRadio.Size = new System.Drawing.Size(54, 17);
            this.UI_GreenRadio.TabIndex = 1;
            this.UI_GreenRadio.TabStop = true;
            this.UI_GreenRadio.Text = "Green";
            this.UI_GreenRadio.UseVisualStyleBackColor = true;
            // 
            // UI_GreyRadio
            // 
            this.UI_GreyRadio.AutoSize = true;
            this.UI_GreyRadio.Location = new System.Drawing.Point(7, 67);
            this.UI_GreyRadio.Name = "UI_GreyRadio";
            this.UI_GreyRadio.Size = new System.Drawing.Size(47, 17);
            this.UI_GreyRadio.TabIndex = 2;
            this.UI_GreyRadio.TabStop = true;
            this.UI_GreyRadio.Text = "Grey";
            this.UI_GreyRadio.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 153);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(260, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Cells";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "2000";
            // 
            // UI_OKButton
            // 
            this.UI_OKButton.Location = new System.Drawing.Point(19, 226);
            this.UI_OKButton.Name = "UI_OKButton";
            this.UI_OKButton.Size = new System.Drawing.Size(75, 23);
            this.UI_OKButton.TabIndex = 5;
            this.UI_OKButton.Text = "OK";
            this.UI_OKButton.UseVisualStyleBackColor = true;
            // 
            // UI_CancelButton
            // 
            this.UI_CancelButton.Location = new System.Drawing.Point(197, 226);
            this.UI_CancelButton.Name = "UI_CancelButton";
            this.UI_CancelButton.Size = new System.Drawing.Size(75, 23);
            this.UI_CancelButton.TabIndex = 6;
            this.UI_CancelButton.Text = "Cancel";
            this.UI_CancelButton.UseVisualStyleBackColor = true;
            // 
            // NewPatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UI_CancelButton);
            this.Controls.Add(this.UI_OKButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewPatternForm";
            this.Text = "NewPatternForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_GreyRadio;
        private System.Windows.Forms.RadioButton UI_GreenRadio;
        private System.Windows.Forms.RadioButton UI_RedRadio;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UI_OKButton;
        private System.Windows.Forms.Button UI_CancelButton;
    }
}