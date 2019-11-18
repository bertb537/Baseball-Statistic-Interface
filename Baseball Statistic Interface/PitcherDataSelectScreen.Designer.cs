namespace Baseball_Statistic_Interface
{
    partial class PitcherDataSelectScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SUBMIT_BUTTON = new System.Windows.Forms.Button();
            this.SELECT_PITCHER_LABEL = new System.Windows.Forms.Label();
            this.PITCHER_SELECT_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SUBMIT_BUTTON
            // 
            this.SUBMIT_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT_BUTTON.Location = new System.Drawing.Point(296, 273);
            this.SUBMIT_BUTTON.Name = "SUBMIT_BUTTON";
            this.SUBMIT_BUTTON.Size = new System.Drawing.Size(184, 47);
            this.SUBMIT_BUTTON.TabIndex = 38;
            this.SUBMIT_BUTTON.Text = "Submit";
            this.SUBMIT_BUTTON.UseVisualStyleBackColor = true;
            // 
            // SELECT_PITCHER_LABEL
            // 
            this.SELECT_PITCHER_LABEL.AutoSize = true;
            this.SELECT_PITCHER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECT_PITCHER_LABEL.Location = new System.Drawing.Point(290, 212);
            this.SELECT_PITCHER_LABEL.Name = "SELECT_PITCHER_LABEL";
            this.SELECT_PITCHER_LABEL.Size = new System.Drawing.Size(190, 31);
            this.SELECT_PITCHER_LABEL.TabIndex = 37;
            this.SELECT_PITCHER_LABEL.Text = "Select Pitcher:";
            // 
            // PITCHER_SELECT_COMBOBOX
            // 
            this.PITCHER_SELECT_COMBOBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PITCHER_SELECT_COMBOBOX.FormattingEnabled = true;
            this.PITCHER_SELECT_COMBOBOX.Location = new System.Drawing.Point(486, 210);
            this.PITCHER_SELECT_COMBOBOX.Name = "PITCHER_SELECT_COMBOBOX";
            this.PITCHER_SELECT_COMBOBOX.Size = new System.Drawing.Size(258, 33);
            this.PITCHER_SELECT_COMBOBOX.TabIndex = 36;
            // 
            // PitcherDataSelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SUBMIT_BUTTON);
            this.Controls.Add(this.SELECT_PITCHER_LABEL);
            this.Controls.Add(this.PITCHER_SELECT_COMBOBOX);
            this.Name = "PitcherDataSelectScreen";
            this.Size = new System.Drawing.Size(1011, 779);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SUBMIT_BUTTON;
        private System.Windows.Forms.Label SELECT_PITCHER_LABEL;
        private System.Windows.Forms.ComboBox PITCHER_SELECT_COMBOBOX;
    }
}
