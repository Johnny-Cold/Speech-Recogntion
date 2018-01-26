namespace Speach_Recognition_Program
{
    partial class frmSpeechrecogntion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpeechrecogntion));
            this.txtSpeechInput = new System.Windows.Forms.TextBox();
            this.btnReadTextBox = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtSpeechInput
            // 
            resources.ApplyResources(this.txtSpeechInput, "txtSpeechInput");
            this.txtSpeechInput.Name = "txtSpeechInput";
            // 
            // btnReadTextBox
            // 
            resources.ApplyResources(this.btnReadTextBox, "btnReadTextBox");
            this.btnReadTextBox.Name = "btnReadTextBox";
            this.btnReadTextBox.UseVisualStyleBackColor = true;
            this.btnReadTextBox.Click += new System.EventHandler(this.btnReadTextBox_Click);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // radMale
            // 
            resources.ApplyResources(this.radMale, "radMale");
            this.radMale.Name = "radMale";
            this.radMale.TabStop = true;
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            resources.ApplyResources(this.radFemale, "radFemale");
            this.radFemale.Name = "radFemale";
            this.radFemale.TabStop = true;
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // frmSpeechrecogntion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReadTextBox);
            this.Controls.Add(this.txtSpeechInput);
            this.Name = "frmSpeechrecogntion";
            this.Load += new System.EventHandler(this.frmSpeechrecogntion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpeechInput;
        private System.Windows.Forms.Button btnReadTextBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
    }
}

