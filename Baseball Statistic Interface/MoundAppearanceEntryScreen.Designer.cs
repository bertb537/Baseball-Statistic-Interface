﻿namespace Baseball_Statistic_Interface
{
    partial class MoundAppearanceEntryScreen
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
            this.BATTER_LABEL = new System.Windows.Forms.Label();
            this.OPENER_LABEL = new System.Windows.Forms.Label();
            this.OPENER_TEXTBOX = new System.Windows.Forms.TextBox();
            this.OPENER_QUADRANT_TEXTBOX = new System.Windows.Forms.TextBox();
            this.OPENER_QUADRANT_LABEL = new System.Windows.Forms.Label();
            this.O_TWO_QUADRANT_TEXTBOX = new System.Windows.Forms.TextBox();
            this.O_TWO_QUADRANT_LABEL = new System.Windows.Forms.Label();
            this.O_TWO_TEXTBOX = new System.Windows.Forms.TextBox();
            this.O_TWO_LABEL = new System.Windows.Forms.Label();
            this.TITLE_LABLE = new System.Windows.Forms.Label();
            this.LEFT_RADIOBUTTON = new System.Windows.Forms.RadioButton();
            this.RIGHT_RADIOBUTTON = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SUBMIT_BUTTON
            // 
            this.SUBMIT_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT_BUTTON.Location = new System.Drawing.Point(212, 464);
            this.SUBMIT_BUTTON.Name = "SUBMIT_BUTTON";
            this.SUBMIT_BUTTON.Size = new System.Drawing.Size(184, 47);
            this.SUBMIT_BUTTON.TabIndex = 41;
            this.SUBMIT_BUTTON.Text = "Submit";
            this.SUBMIT_BUTTON.UseVisualStyleBackColor = true;
            this.SUBMIT_BUTTON.Click += new System.EventHandler(this.SUBMIT_BUTTON_Click);
            // 
            // SELECT_PITCHER_LABEL
            // 
            this.SELECT_PITCHER_LABEL.AutoSize = true;
            this.SELECT_PITCHER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECT_PITCHER_LABEL.Location = new System.Drawing.Point(206, 214);
            this.SELECT_PITCHER_LABEL.Name = "SELECT_PITCHER_LABEL";
            this.SELECT_PITCHER_LABEL.Size = new System.Drawing.Size(190, 31);
            this.SELECT_PITCHER_LABEL.TabIndex = 40;
            this.SELECT_PITCHER_LABEL.Text = "Select Pitcher:";
            // 
            // PITCHER_SELECT_COMBOBOX
            // 
            this.PITCHER_SELECT_COMBOBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PITCHER_SELECT_COMBOBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PITCHER_SELECT_COMBOBOX.FormattingEnabled = true;
            this.PITCHER_SELECT_COMBOBOX.Location = new System.Drawing.Point(402, 212);
            this.PITCHER_SELECT_COMBOBOX.Name = "PITCHER_SELECT_COMBOBOX";
            this.PITCHER_SELECT_COMBOBOX.Size = new System.Drawing.Size(258, 33);
            this.PITCHER_SELECT_COMBOBOX.TabIndex = 39;
            // 
            // BATTER_LABEL
            // 
            this.BATTER_LABEL.AutoSize = true;
            this.BATTER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BATTER_LABEL.Location = new System.Drawing.Point(301, 395);
            this.BATTER_LABEL.Name = "BATTER_LABEL";
            this.BATTER_LABEL.Size = new System.Drawing.Size(95, 31);
            this.BATTER_LABEL.TabIndex = 42;
            this.BATTER_LABEL.Text = "Batter:";
            // 
            // OPENER_LABEL
            // 
            this.OPENER_LABEL.AutoSize = true;
            this.OPENER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPENER_LABEL.Location = new System.Drawing.Point(284, 282);
            this.OPENER_LABEL.Name = "OPENER_LABEL";
            this.OPENER_LABEL.Size = new System.Drawing.Size(112, 31);
            this.OPENER_LABEL.TabIndex = 46;
            this.OPENER_LABEL.Text = "Opener:";
            // 
            // OPENER_TEXTBOX
            // 
            this.OPENER_TEXTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OPENER_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPENER_TEXTBOX.Location = new System.Drawing.Point(402, 285);
            this.OPENER_TEXTBOX.Name = "OPENER_TEXTBOX";
            this.OPENER_TEXTBOX.Size = new System.Drawing.Size(92, 31);
            this.OPENER_TEXTBOX.TabIndex = 47;
            this.OPENER_TEXTBOX.TextChanged += new System.EventHandler(this.OPENER_TEXTBOX_TextChanged);
            // 
            // OPENER_QUADRANT_TEXTBOX
            // 
            this.OPENER_QUADRANT_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPENER_QUADRANT_TEXTBOX.Location = new System.Drawing.Point(654, 285);
            this.OPENER_QUADRANT_TEXTBOX.Name = "OPENER_QUADRANT_TEXTBOX";
            this.OPENER_QUADRANT_TEXTBOX.Size = new System.Drawing.Size(92, 31);
            this.OPENER_QUADRANT_TEXTBOX.TabIndex = 49;
            this.OPENER_QUADRANT_TEXTBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OPENER_QUADRANT_TEXTBOX_KeyPress);
            // 
            // OPENER_QUADRANT_LABEL
            // 
            this.OPENER_QUADRANT_LABEL.AutoSize = true;
            this.OPENER_QUADRANT_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPENER_QUADRANT_LABEL.Location = new System.Drawing.Point(513, 282);
            this.OPENER_QUADRANT_LABEL.Name = "OPENER_QUADRANT_LABEL";
            this.OPENER_QUADRANT_LABEL.Size = new System.Drawing.Size(135, 31);
            this.OPENER_QUADRANT_LABEL.TabIndex = 48;
            this.OPENER_QUADRANT_LABEL.Text = "Quadrant:";
            // 
            // O_TWO_QUADRANT_TEXTBOX
            // 
            this.O_TWO_QUADRANT_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_TWO_QUADRANT_TEXTBOX.Location = new System.Drawing.Point(654, 344);
            this.O_TWO_QUADRANT_TEXTBOX.Name = "O_TWO_QUADRANT_TEXTBOX";
            this.O_TWO_QUADRANT_TEXTBOX.Size = new System.Drawing.Size(92, 31);
            this.O_TWO_QUADRANT_TEXTBOX.TabIndex = 53;
            this.O_TWO_QUADRANT_TEXTBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.O_TWO_QUADRANT_TEXTBOX_KeyPress);
            // 
            // O_TWO_QUADRANT_LABEL
            // 
            this.O_TWO_QUADRANT_LABEL.AutoSize = true;
            this.O_TWO_QUADRANT_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_TWO_QUADRANT_LABEL.Location = new System.Drawing.Point(513, 341);
            this.O_TWO_QUADRANT_LABEL.Name = "O_TWO_QUADRANT_LABEL";
            this.O_TWO_QUADRANT_LABEL.Size = new System.Drawing.Size(135, 31);
            this.O_TWO_QUADRANT_LABEL.TabIndex = 52;
            this.O_TWO_QUADRANT_LABEL.Text = "Quadrant:";
            // 
            // O_TWO_TEXTBOX
            // 
            this.O_TWO_TEXTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.O_TWO_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_TWO_TEXTBOX.Location = new System.Drawing.Point(402, 344);
            this.O_TWO_TEXTBOX.Name = "O_TWO_TEXTBOX";
            this.O_TWO_TEXTBOX.Size = new System.Drawing.Size(92, 31);
            this.O_TWO_TEXTBOX.TabIndex = 51;
            // 
            // O_TWO_LABEL
            // 
            this.O_TWO_LABEL.AutoSize = true;
            this.O_TWO_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_TWO_LABEL.Location = new System.Drawing.Point(335, 344);
            this.O_TWO_LABEL.Name = "O_TWO_LABEL";
            this.O_TWO_LABEL.Size = new System.Drawing.Size(61, 31);
            this.O_TWO_LABEL.TabIndex = 50;
            this.O_TWO_LABEL.Text = "0-2:";
            // 
            // TITLE_LABLE
            // 
            this.TITLE_LABLE.AutoSize = true;
            this.TITLE_LABLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE_LABLE.Location = new System.Drawing.Point(300, 41);
            this.TITLE_LABLE.Name = "TITLE_LABLE";
            this.TITLE_LABLE.Size = new System.Drawing.Size(402, 37);
            this.TITLE_LABLE.TabIndex = 54;
            this.TITLE_LABLE.Text = "Mound Appearance Entry";
            // 
            // LEFT_RADIOBUTTON
            // 
            this.LEFT_RADIOBUTTON.AutoSize = true;
            this.LEFT_RADIOBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEFT_RADIOBUTTON.Location = new System.Drawing.Point(402, 402);
            this.LEFT_RADIOBUTTON.Name = "LEFT_RADIOBUTTON";
            this.LEFT_RADIOBUTTON.Size = new System.Drawing.Size(55, 24);
            this.LEFT_RADIOBUTTON.TabIndex = 55;
            this.LEFT_RADIOBUTTON.TabStop = true;
            this.LEFT_RADIOBUTTON.Text = "Left";
            this.LEFT_RADIOBUTTON.UseVisualStyleBackColor = true;
            // 
            // RIGHT_RADIOBUTTON
            // 
            this.RIGHT_RADIOBUTTON.AutoSize = true;
            this.RIGHT_RADIOBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIGHT_RADIOBUTTON.Location = new System.Drawing.Point(463, 402);
            this.RIGHT_RADIOBUTTON.Name = "RIGHT_RADIOBUTTON";
            this.RIGHT_RADIOBUTTON.Size = new System.Drawing.Size(65, 24);
            this.RIGHT_RADIOBUTTON.TabIndex = 56;
            this.RIGHT_RADIOBUTTON.TabStop = true;
            this.RIGHT_RADIOBUTTON.Text = "Right";
            this.RIGHT_RADIOBUTTON.UseVisualStyleBackColor = true;
            // 
            // MoundAppearanceEntryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RIGHT_RADIOBUTTON);
            this.Controls.Add(this.LEFT_RADIOBUTTON);
            this.Controls.Add(this.TITLE_LABLE);
            this.Controls.Add(this.O_TWO_QUADRANT_TEXTBOX);
            this.Controls.Add(this.O_TWO_QUADRANT_LABEL);
            this.Controls.Add(this.O_TWO_TEXTBOX);
            this.Controls.Add(this.O_TWO_LABEL);
            this.Controls.Add(this.OPENER_QUADRANT_TEXTBOX);
            this.Controls.Add(this.OPENER_QUADRANT_LABEL);
            this.Controls.Add(this.OPENER_TEXTBOX);
            this.Controls.Add(this.OPENER_LABEL);
            this.Controls.Add(this.BATTER_LABEL);
            this.Controls.Add(this.SUBMIT_BUTTON);
            this.Controls.Add(this.SELECT_PITCHER_LABEL);
            this.Controls.Add(this.PITCHER_SELECT_COMBOBOX);
            this.Name = "MoundAppearanceEntryScreen";
            this.Size = new System.Drawing.Size(1011, 779);
            this.Load += new System.EventHandler(this.MoundAppearanceEntryScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SUBMIT_BUTTON;
        private System.Windows.Forms.Label SELECT_PITCHER_LABEL;
        private System.Windows.Forms.ComboBox PITCHER_SELECT_COMBOBOX;
        private System.Windows.Forms.Label BATTER_LABEL;
        private System.Windows.Forms.Label OPENER_LABEL;
        private System.Windows.Forms.TextBox OPENER_TEXTBOX;
        private System.Windows.Forms.TextBox OPENER_QUADRANT_TEXTBOX;
        private System.Windows.Forms.Label OPENER_QUADRANT_LABEL;
        private System.Windows.Forms.TextBox O_TWO_QUADRANT_TEXTBOX;
        private System.Windows.Forms.Label O_TWO_QUADRANT_LABEL;
        private System.Windows.Forms.TextBox O_TWO_TEXTBOX;
        private System.Windows.Forms.Label O_TWO_LABEL;
        private System.Windows.Forms.Label TITLE_LABLE;
        private System.Windows.Forms.RadioButton LEFT_RADIOBUTTON;
        private System.Windows.Forms.RadioButton RIGHT_RADIOBUTTON;
    }
}
