namespace CMPE1600_Lab4
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
            this.UI_NewPatternButton = new System.Windows.Forms.Button();
            this.UI_StartButton = new System.Windows.Forms.Button();
            this.UI_StopButton = new System.Windows.Forms.Button();
            this.UI_CycleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_CycleLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_NewPatternButton
            // 
            this.UI_NewPatternButton.Location = new System.Drawing.Point(103, 71);
            this.UI_NewPatternButton.Name = "UI_NewPatternButton";
            this.UI_NewPatternButton.Size = new System.Drawing.Size(75, 23);
            this.UI_NewPatternButton.TabIndex = 0;
            this.UI_NewPatternButton.Text = "New Pattern";
            this.UI_NewPatternButton.UseVisualStyleBackColor = true;
            // 
            // UI_StartButton
            // 
            this.UI_StartButton.Location = new System.Drawing.Point(12, 193);
            this.UI_StartButton.Name = "UI_StartButton";
            this.UI_StartButton.Size = new System.Drawing.Size(75, 23);
            this.UI_StartButton.TabIndex = 1;
            this.UI_StartButton.Tag = "";
            this.UI_StartButton.Text = "Start";
            this.UI_StartButton.UseVisualStyleBackColor = true;
            this.UI_StartButton.Click += new System.EventHandler(this.UI_StartButton_Click);
            // 
            // UI_StopButton
            // 
            this.UI_StopButton.Enabled = false;
            this.UI_StopButton.Location = new System.Drawing.Point(103, 193);
            this.UI_StopButton.Name = "UI_StopButton";
            this.UI_StopButton.Size = new System.Drawing.Size(75, 23);
            this.UI_StopButton.TabIndex = 2;
            this.UI_StopButton.Text = "Stop";
            this.UI_StopButton.UseVisualStyleBackColor = true;
            this.UI_StopButton.Click += new System.EventHandler(this.UI_StopButton_Click);
            // 
            // UI_CycleButton
            // 
            this.UI_CycleButton.Location = new System.Drawing.Point(197, 193);
            this.UI_CycleButton.Name = "UI_CycleButton";
            this.UI_CycleButton.Size = new System.Drawing.Size(75, 23);
            this.UI_CycleButton.TabIndex = 3;
            this.UI_CycleButton.Text = "Cycle";
            this.UI_CycleButton.UseVisualStyleBackColor = true;
            this.UI_CycleButton.Click += new System.EventHandler(this.UI_CycleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cycle:";
            // 
            // UI_CycleLabel
            // 
            this.UI_CycleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_CycleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_CycleLabel.Location = new System.Drawing.Point(143, 126);
            this.UI_CycleLabel.Name = "UI_CycleLabel";
            this.UI_CycleLabel.Size = new System.Drawing.Size(100, 29);
            this.UI_CycleLabel.TabIndex = 5;
            this.UI_CycleLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UI_CycleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_CycleButton);
            this.Controls.Add(this.UI_StopButton);
            this.Controls.Add(this.UI_StartButton);
            this.Controls.Add(this.UI_NewPatternButton);
            this.Name = "Form1";
            this.Text = "Lab 2 - Life";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_NewPatternButton;
        private System.Windows.Forms.Button UI_StartButton;
        private System.Windows.Forms.Button UI_StopButton;
        private System.Windows.Forms.Button UI_CycleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UI_CycleLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

