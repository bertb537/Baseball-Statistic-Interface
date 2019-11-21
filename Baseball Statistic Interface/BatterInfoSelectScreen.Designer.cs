namespace Baseball_Statistic_Interface
{
    partial class BatterInfoSelectScreen
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
            this.SELECT_BATTER_LABEL = new System.Windows.Forms.Label();
            this.BATTER_SELECT_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SUBMIT_BUTTON
            // 
            this.SUBMIT_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT_BUTTON.Location = new System.Drawing.Point(302, 274);
            this.SUBMIT_BUTTON.Name = "SUBMIT_BUTTON";
            this.SUBMIT_BUTTON.Size = new System.Drawing.Size(172, 47);
            this.SUBMIT_BUTTON.TabIndex = 41;
            this.SUBMIT_BUTTON.Text = "Submit";
            this.SUBMIT_BUTTON.UseVisualStyleBackColor = true;
            this.SUBMIT_BUTTON.Click += new System.EventHandler(this.SUBMIT_BUTTON_Click);
            // 
            // SELECT_BATTER_LABEL
            // 
            this.SELECT_BATTER_LABEL.AutoSize = true;
            this.SELECT_BATTER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECT_BATTER_LABEL.Location = new System.Drawing.Point(296, 213);
            this.SELECT_BATTER_LABEL.Name = "SELECT_BATTER_LABEL";
            this.SELECT_BATTER_LABEL.Size = new System.Drawing.Size(178, 31);
            this.SELECT_BATTER_LABEL.TabIndex = 40;
            this.SELECT_BATTER_LABEL.Text = "Select Batter:";
            // 
            // BATTER_SELECT_COMBOBOX
            // 
            this.BATTER_SELECT_COMBOBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BATTER_SELECT_COMBOBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BATTER_SELECT_COMBOBOX.FormattingEnabled = true;
            this.BATTER_SELECT_COMBOBOX.Location = new System.Drawing.Point(480, 211);
            this.BATTER_SELECT_COMBOBOX.Name = "BATTER_SELECT_COMBOBOX";
            this.BATTER_SELECT_COMBOBOX.Size = new System.Drawing.Size(258, 33);
            this.BATTER_SELECT_COMBOBOX.TabIndex = 39;
            this.BATTER_SELECT_COMBOBOX.SelectedIndexChanged += new System.EventHandler(this.BATTER_SELECT_COMBOBOX_SelectedIndexChanged);
            // 
            // BatterInfoSelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SUBMIT_BUTTON);
            this.Controls.Add(this.SELECT_BATTER_LABEL);
            this.Controls.Add(this.BATTER_SELECT_COMBOBOX);
            this.Name = "BatterInfoSelectScreen";
            this.Size = new System.Drawing.Size(1011, 779);
            this.Load += new System.EventHandler(this.BatterInfoSelectScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SUBMIT_BUTTON;
        private System.Windows.Forms.Label SELECT_BATTER_LABEL;
        private System.Windows.Forms.ComboBox BATTER_SELECT_COMBOBOX;
    }
}
