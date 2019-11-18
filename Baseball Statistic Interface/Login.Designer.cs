namespace Baseball_Statistic_Interface
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
            this.LOGIN_SUBMIT_BUTTON = new System.Windows.Forms.Button();
            this.PIN_TEXTBOX = new System.Windows.Forms.TextBox();
            this.USERNAME_TEXTBOX = new System.Windows.Forms.TextBox();
            this.PIN_LABEL = new System.Windows.Forms.Label();
            this.USERNAM_LABEL = new System.Windows.Forms.Label();
            this.LOGIN_LABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LOGIN_SUBMIT_BUTTON
            // 
            this.LOGIN_SUBMIT_BUTTON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOGIN_SUBMIT_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_SUBMIT_BUTTON.Location = new System.Drawing.Point(310, 328);
            this.LOGIN_SUBMIT_BUTTON.Name = "LOGIN_SUBMIT_BUTTON";
            this.LOGIN_SUBMIT_BUTTON.Size = new System.Drawing.Size(182, 55);
            this.LOGIN_SUBMIT_BUTTON.TabIndex = 11;
            this.LOGIN_SUBMIT_BUTTON.Text = "Submit";
            this.LOGIN_SUBMIT_BUTTON.UseVisualStyleBackColor = true;
            // 
            // PIN_TEXTBOX
            // 
            this.PIN_TEXTBOX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIN_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN_TEXTBOX.Location = new System.Drawing.Point(369, 260);
            this.PIN_TEXTBOX.Name = "PIN_TEXTBOX";
            this.PIN_TEXTBOX.Size = new System.Drawing.Size(191, 31);
            this.PIN_TEXTBOX.TabIndex = 10;
            // 
            // USERNAME_TEXTBOX
            // 
            this.USERNAME_TEXTBOX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USERNAME_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME_TEXTBOX.Location = new System.Drawing.Point(369, 212);
            this.USERNAME_TEXTBOX.Name = "USERNAME_TEXTBOX";
            this.USERNAME_TEXTBOX.Size = new System.Drawing.Size(191, 31);
            this.USERNAME_TEXTBOX.TabIndex = 9;
            // 
            // PIN_LABEL
            // 
            this.PIN_LABEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIN_LABEL.AutoSize = true;
            this.PIN_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN_LABEL.Location = new System.Drawing.Point(295, 260);
            this.PIN_LABEL.Name = "PIN_LABEL";
            this.PIN_LABEL.Size = new System.Drawing.Size(68, 31);
            this.PIN_LABEL.TabIndex = 8;
            this.PIN_LABEL.Text = "Pin: ";
            // 
            // USERNAM_LABEL
            // 
            this.USERNAM_LABEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USERNAM_LABEL.AutoSize = true;
            this.USERNAM_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAM_LABEL.Location = new System.Drawing.Point(216, 212);
            this.USERNAM_LABEL.Name = "USERNAM_LABEL";
            this.USERNAM_LABEL.Size = new System.Drawing.Size(147, 31);
            this.USERNAM_LABEL.TabIndex = 7;
            this.USERNAM_LABEL.Text = "Username:";
            // 
            // LOGIN_LABEL
            // 
            this.LOGIN_LABEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOGIN_LABEL.AutoSize = true;
            this.LOGIN_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_LABEL.Location = new System.Drawing.Point(297, 98);
            this.LOGIN_LABEL.Name = "LOGIN_LABEL";
            this.LOGIN_LABEL.Size = new System.Drawing.Size(195, 73);
            this.LOGIN_LABEL.TabIndex = 6;
            this.LOGIN_LABEL.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 506);
            this.Controls.Add(this.LOGIN_SUBMIT_BUTTON);
            this.Controls.Add(this.PIN_TEXTBOX);
            this.Controls.Add(this.USERNAME_TEXTBOX);
            this.Controls.Add(this.PIN_LABEL);
            this.Controls.Add(this.USERNAM_LABEL);
            this.Controls.Add(this.LOGIN_LABEL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LOGIN_SUBMIT_BUTTON;
        private System.Windows.Forms.TextBox PIN_TEXTBOX;
        private System.Windows.Forms.TextBox USERNAME_TEXTBOX;
        private System.Windows.Forms.Label PIN_LABEL;
        private System.Windows.Forms.Label USERNAM_LABEL;
        private System.Windows.Forms.Label LOGIN_LABEL;
    }
}

