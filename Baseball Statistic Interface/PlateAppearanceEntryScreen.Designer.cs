namespace Baseball_Statistic_Interface
{
    partial class PlateAppearanceEntryScreen
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
            this.TITLE_LABEL = new System.Windows.Forms.Label();
            this.FINAL_QUADRANT_TEXTBOX = new System.Windows.Forms.TextBox();
            this.FINAL_QUADRANT_LABEL = new System.Windows.Forms.Label();
            this.FINAL_PITCH_TEXTBOX = new System.Windows.Forms.TextBox();
            this.FINAL_PITCH_LABEL = new System.Windows.Forms.Label();
            this.RESULT_TEXTBOX = new System.Windows.Forms.TextBox();
            this.RESULT_LABEL = new System.Windows.Forms.Label();
            this.TOTAL_PITCHES_TEXTBOX = new System.Windows.Forms.TextBox();
            this.TOTAL_PITCHES_LABEL = new System.Windows.Forms.Label();
            this.PITCHER_LABEL = new System.Windows.Forms.Label();
            this.LEFT_RADIOBUTTON = new System.Windows.Forms.RadioButton();
            this.RIGHT_RADIOBUTTON = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SUBMIT_BUTTON
            // 
            this.SUBMIT_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT_BUTTON.Location = new System.Drawing.Point(228, 457);
            this.SUBMIT_BUTTON.Name = "SUBMIT_BUTTON";
            this.SUBMIT_BUTTON.Size = new System.Drawing.Size(172, 47);
            this.SUBMIT_BUTTON.TabIndex = 44;
            this.SUBMIT_BUTTON.Text = "Submit";
            this.SUBMIT_BUTTON.UseVisualStyleBackColor = true;
            this.SUBMIT_BUTTON.Click += new System.EventHandler(this.SUBMIT_BUTTON_Click);
            // 
            // SELECT_BATTER_LABEL
            // 
            this.SELECT_BATTER_LABEL.AutoSize = true;
            this.SELECT_BATTER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECT_BATTER_LABEL.Location = new System.Drawing.Point(222, 213);
            this.SELECT_BATTER_LABEL.Name = "SELECT_BATTER_LABEL";
            this.SELECT_BATTER_LABEL.Size = new System.Drawing.Size(178, 31);
            this.SELECT_BATTER_LABEL.TabIndex = 43;
            this.SELECT_BATTER_LABEL.Text = "Select Batter:";
            // 
            // BATTER_SELECT_COMBOBOX
            // 
            this.BATTER_SELECT_COMBOBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BATTER_SELECT_COMBOBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BATTER_SELECT_COMBOBOX.FormattingEnabled = true;
            this.BATTER_SELECT_COMBOBOX.Location = new System.Drawing.Point(406, 211);
            this.BATTER_SELECT_COMBOBOX.Name = "BATTER_SELECT_COMBOBOX";
            this.BATTER_SELECT_COMBOBOX.Size = new System.Drawing.Size(258, 33);
            this.BATTER_SELECT_COMBOBOX.TabIndex = 42;
            // 
            // TITLE_LABEL
            // 
            this.TITLE_LABEL.AutoSize = true;
            this.TITLE_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE_LABEL.Location = new System.Drawing.Point(316, 41);
            this.TITLE_LABEL.Name = "TITLE_LABEL";
            this.TITLE_LABEL.Size = new System.Drawing.Size(376, 37);
            this.TITLE_LABEL.TabIndex = 55;
            this.TITLE_LABEL.Text = "Plate Appearance Entry";
            // 
            // FINAL_QUADRANT_TEXTBOX
            // 
            this.FINAL_QUADRANT_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FINAL_QUADRANT_TEXTBOX.Location = new System.Drawing.Point(658, 344);
            this.FINAL_QUADRANT_TEXTBOX.Name = "FINAL_QUADRANT_TEXTBOX";
            this.FINAL_QUADRANT_TEXTBOX.Size = new System.Drawing.Size(92, 31);
            this.FINAL_QUADRANT_TEXTBOX.TabIndex = 64;
            this.FINAL_QUADRANT_TEXTBOX.TextChanged += new System.EventHandler(this.FINAL_QUADRANT_TEXTBOX_TextChanged);
            this.FINAL_QUADRANT_TEXTBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FINAL_QUADRANT_TEXTBOX_KeyPress);
            // 
            // FINAL_QUADRANT_LABEL
            // 
            this.FINAL_QUADRANT_LABEL.AutoSize = true;
            this.FINAL_QUADRANT_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FINAL_QUADRANT_LABEL.Location = new System.Drawing.Point(517, 341);
            this.FINAL_QUADRANT_LABEL.Name = "FINAL_QUADRANT_LABEL";
            this.FINAL_QUADRANT_LABEL.Size = new System.Drawing.Size(135, 31);
            this.FINAL_QUADRANT_LABEL.TabIndex = 63;
            this.FINAL_QUADRANT_LABEL.Text = "Quadrant:";
            // 
            // FINAL_PITCH_TEXTBOX
            // 
            this.FINAL_PITCH_TEXTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FINAL_PITCH_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FINAL_PITCH_TEXTBOX.Location = new System.Drawing.Point(406, 344);
            this.FINAL_PITCH_TEXTBOX.Name = "FINAL_PITCH_TEXTBOX";
            this.FINAL_PITCH_TEXTBOX.Size = new System.Drawing.Size(92, 31);
            this.FINAL_PITCH_TEXTBOX.TabIndex = 62;
            // 
            // FINAL_PITCH_LABEL
            // 
            this.FINAL_PITCH_LABEL.AutoSize = true;
            this.FINAL_PITCH_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FINAL_PITCH_LABEL.Location = new System.Drawing.Point(251, 344);
            this.FINAL_PITCH_LABEL.Name = "FINAL_PITCH_LABEL";
            this.FINAL_PITCH_LABEL.Size = new System.Drawing.Size(149, 31);
            this.FINAL_PITCH_LABEL.TabIndex = 61;
            this.FINAL_PITCH_LABEL.Text = "Final Pitch:";
            // 
            // RESULT_TEXTBOX
            // 
            this.RESULT_TEXTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RESULT_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULT_TEXTBOX.Location = new System.Drawing.Point(658, 282);
            this.RESULT_TEXTBOX.Name = "RESULT_TEXTBOX";
            this.RESULT_TEXTBOX.Size = new System.Drawing.Size(92, 31);
            this.RESULT_TEXTBOX.TabIndex = 60;
            // 
            // RESULT_LABEL
            // 
            this.RESULT_LABEL.AutoSize = true;
            this.RESULT_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULT_LABEL.Location = new System.Drawing.Point(552, 282);
            this.RESULT_LABEL.Name = "RESULT_LABEL";
            this.RESULT_LABEL.Size = new System.Drawing.Size(100, 31);
            this.RESULT_LABEL.TabIndex = 59;
            this.RESULT_LABEL.Text = "Result:";
            // 
            // TOTAL_PITCHES_TEXTBOX
            // 
            this.TOTAL_PITCHES_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL_PITCHES_TEXTBOX.Location = new System.Drawing.Point(406, 282);
            this.TOTAL_PITCHES_TEXTBOX.Name = "TOTAL_PITCHES_TEXTBOX";
            this.TOTAL_PITCHES_TEXTBOX.Size = new System.Drawing.Size(92, 31);
            this.TOTAL_PITCHES_TEXTBOX.TabIndex = 58;
            this.TOTAL_PITCHES_TEXTBOX.TextChanged += new System.EventHandler(this.TOTAL_PITCHES_TEXTBOX_TextChanged);
            this.TOTAL_PITCHES_TEXTBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TOTAL_PITCHES_TEXTBOX_KeyPress);
            // 
            // TOTAL_PITCHES_LABEL
            // 
            this.TOTAL_PITCHES_LABEL.AutoSize = true;
            this.TOTAL_PITCHES_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL_PITCHES_LABEL.Location = new System.Drawing.Point(220, 282);
            this.TOTAL_PITCHES_LABEL.Name = "TOTAL_PITCHES_LABEL";
            this.TOTAL_PITCHES_LABEL.Size = new System.Drawing.Size(180, 31);
            this.TOTAL_PITCHES_LABEL.TabIndex = 57;
            this.TOTAL_PITCHES_LABEL.Text = "Total Pitches:";
            // 
            // PITCHER_LABEL
            // 
            this.PITCHER_LABEL.AutoSize = true;
            this.PITCHER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PITCHER_LABEL.Location = new System.Drawing.Point(293, 404);
            this.PITCHER_LABEL.Name = "PITCHER_LABEL";
            this.PITCHER_LABEL.Size = new System.Drawing.Size(107, 31);
            this.PITCHER_LABEL.TabIndex = 65;
            this.PITCHER_LABEL.Text = "Pitcher:";
            // 
            // LEFT_RADIOBUTTON
            // 
            this.LEFT_RADIOBUTTON.AutoSize = true;
            this.LEFT_RADIOBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEFT_RADIOBUTTON.Location = new System.Drawing.Point(406, 411);
            this.LEFT_RADIOBUTTON.Name = "LEFT_RADIOBUTTON";
            this.LEFT_RADIOBUTTON.Size = new System.Drawing.Size(55, 24);
            this.LEFT_RADIOBUTTON.TabIndex = 66;
            this.LEFT_RADIOBUTTON.TabStop = true;
            this.LEFT_RADIOBUTTON.Text = "Left";
            this.LEFT_RADIOBUTTON.UseVisualStyleBackColor = true;
            // 
            // RIGHT_RADIOBUTTON
            // 
            this.RIGHT_RADIOBUTTON.AutoSize = true;
            this.RIGHT_RADIOBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIGHT_RADIOBUTTON.Location = new System.Drawing.Point(467, 411);
            this.RIGHT_RADIOBUTTON.Name = "RIGHT_RADIOBUTTON";
            this.RIGHT_RADIOBUTTON.Size = new System.Drawing.Size(65, 24);
            this.RIGHT_RADIOBUTTON.TabIndex = 67;
            this.RIGHT_RADIOBUTTON.TabStop = true;
            this.RIGHT_RADIOBUTTON.Text = "Right";
            this.RIGHT_RADIOBUTTON.UseVisualStyleBackColor = true;
            // 
            // PlateAppearanceEntryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RIGHT_RADIOBUTTON);
            this.Controls.Add(this.LEFT_RADIOBUTTON);
            this.Controls.Add(this.PITCHER_LABEL);
            this.Controls.Add(this.FINAL_QUADRANT_TEXTBOX);
            this.Controls.Add(this.FINAL_QUADRANT_LABEL);
            this.Controls.Add(this.FINAL_PITCH_TEXTBOX);
            this.Controls.Add(this.FINAL_PITCH_LABEL);
            this.Controls.Add(this.RESULT_TEXTBOX);
            this.Controls.Add(this.RESULT_LABEL);
            this.Controls.Add(this.TOTAL_PITCHES_TEXTBOX);
            this.Controls.Add(this.TOTAL_PITCHES_LABEL);
            this.Controls.Add(this.TITLE_LABEL);
            this.Controls.Add(this.SUBMIT_BUTTON);
            this.Controls.Add(this.SELECT_BATTER_LABEL);
            this.Controls.Add(this.BATTER_SELECT_COMBOBOX);
            this.Name = "PlateAppearanceEntryScreen";
            this.Size = new System.Drawing.Size(1011, 779);
            this.Load += new System.EventHandler(this.PlateAppearanceEntryScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SUBMIT_BUTTON;
        private System.Windows.Forms.Label SELECT_BATTER_LABEL;
        private System.Windows.Forms.ComboBox BATTER_SELECT_COMBOBOX;
        private System.Windows.Forms.Label TITLE_LABEL;
        private System.Windows.Forms.TextBox FINAL_QUADRANT_TEXTBOX;
        private System.Windows.Forms.Label FINAL_QUADRANT_LABEL;
        private System.Windows.Forms.TextBox FINAL_PITCH_TEXTBOX;
        private System.Windows.Forms.Label FINAL_PITCH_LABEL;
        private System.Windows.Forms.TextBox RESULT_TEXTBOX;
        private System.Windows.Forms.Label RESULT_LABEL;
        private System.Windows.Forms.TextBox TOTAL_PITCHES_TEXTBOX;
        private System.Windows.Forms.Label TOTAL_PITCHES_LABEL;
        private System.Windows.Forms.Label PITCHER_LABEL;
        private System.Windows.Forms.RadioButton LEFT_RADIOBUTTON;
        private System.Windows.Forms.RadioButton RIGHT_RADIOBUTTON;
    }
}
