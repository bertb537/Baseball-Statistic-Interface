namespace Baseball_Statistic_Interface
{
    partial class BatterDataDisplayScreenTwo
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
            this.PREVIOUS_BUTTON = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LEFT_SLIDER_DATAGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.LEFT_CHANGE_DATAGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.LEFT_HAND_BATTER_LABEL = new System.Windows.Forms.Label();
            this.RIGHT_SLIDER_DATAGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.RIGHT_CHANGE_DATAGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.RIGHT_HAND_BATTER_LABEL = new System.Windows.Forms.Label();
            this.BATTING_ARM_LABEL = new System.Windows.Forms.Label();
            this.PLAYER_NAME_LABEL = new System.Windows.Forms.Label();
            this.RBI_LABEL = new System.Windows.Forms.Label();
            this.OPS_LABEL = new System.Windows.Forms.Label();
            this.SLG_LABEL = new System.Windows.Forms.Label();
            this.OBP_LABEL = new System.Windows.Forms.Label();
            this.AB_LABEL = new System.Windows.Forms.Label();
            this.AVG_LABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_SLIDER_DATAGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_CHANGE_DATAGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHT_SLIDER_DATAGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHT_CHANGE_DATAGRIDVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // PREVIOUS_BUTTON
            // 
            this.PREVIOUS_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PREVIOUS_BUTTON.Location = new System.Drawing.Point(865, 723);
            this.PREVIOUS_BUTTON.Name = "PREVIOUS_BUTTON";
            this.PREVIOUS_BUTTON.Size = new System.Drawing.Size(123, 35);
            this.PREVIOUS_BUTTON.TabIndex = 24;
            this.PREVIOUS_BUTTON.Text = "Previous";
            this.PREVIOUS_BUTTON.UseVisualStyleBackColor = true;
            this.PREVIOUS_BUTTON.Click += new System.EventHandler(this.PREVIOUS_BUTTON_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 68);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.LEFT_SLIDER_DATAGRIDVIEW);
            this.splitContainer1.Panel1.Controls.Add(this.LEFT_CHANGE_DATAGRIDVIEW);
            this.splitContainer1.Panel1.Controls.Add(this.LEFT_HAND_BATTER_LABEL);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.RIGHT_SLIDER_DATAGRIDVIEW);
            this.splitContainer1.Panel2.Controls.Add(this.RIGHT_CHANGE_DATAGRIDVIEW);
            this.splitContainer1.Panel2.Controls.Add(this.RIGHT_HAND_BATTER_LABEL);
            this.splitContainer1.Size = new System.Drawing.Size(1011, 627);
            this.splitContainer1.SplitterDistance = 503;
            this.splitContainer1.TabIndex = 23;
            // 
            // LEFT_SLIDER_DATAGRIDVIEW
            // 
            this.LEFT_SLIDER_DATAGRIDVIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LEFT_SLIDER_DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LEFT_SLIDER_DATAGRIDVIEW.Location = new System.Drawing.Point(3, 322);
            this.LEFT_SLIDER_DATAGRIDVIEW.Name = "LEFT_SLIDER_DATAGRIDVIEW";
            this.LEFT_SLIDER_DATAGRIDVIEW.Size = new System.Drawing.Size(497, 181);
            this.LEFT_SLIDER_DATAGRIDVIEW.TabIndex = 6;
            // 
            // LEFT_CHANGE_DATAGRIDVIEW
            // 
            this.LEFT_CHANGE_DATAGRIDVIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LEFT_CHANGE_DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LEFT_CHANGE_DATAGRIDVIEW.Location = new System.Drawing.Point(3, 106);
            this.LEFT_CHANGE_DATAGRIDVIEW.Name = "LEFT_CHANGE_DATAGRIDVIEW";
            this.LEFT_CHANGE_DATAGRIDVIEW.Size = new System.Drawing.Size(497, 181);
            this.LEFT_CHANGE_DATAGRIDVIEW.TabIndex = 5;
            // 
            // LEFT_HAND_BATTER_LABEL
            // 
            this.LEFT_HAND_BATTER_LABEL.AutoSize = true;
            this.LEFT_HAND_BATTER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEFT_HAND_BATTER_LABEL.Location = new System.Drawing.Point(159, 22);
            this.LEFT_HAND_BATTER_LABEL.Name = "LEFT_HAND_BATTER_LABEL";
            this.LEFT_HAND_BATTER_LABEL.Size = new System.Drawing.Size(169, 25);
            this.LEFT_HAND_BATTER_LABEL.TabIndex = 1;
            this.LEFT_HAND_BATTER_LABEL.Text = "Left-Hand Batter";
            // 
            // RIGHT_SLIDER_DATAGRIDVIEW
            // 
            this.RIGHT_SLIDER_DATAGRIDVIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RIGHT_SLIDER_DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RIGHT_SLIDER_DATAGRIDVIEW.Location = new System.Drawing.Point(4, 322);
            this.RIGHT_SLIDER_DATAGRIDVIEW.Name = "RIGHT_SLIDER_DATAGRIDVIEW";
            this.RIGHT_SLIDER_DATAGRIDVIEW.Size = new System.Drawing.Size(497, 181);
            this.RIGHT_SLIDER_DATAGRIDVIEW.TabIndex = 9;
            // 
            // RIGHT_CHANGE_DATAGRIDVIEW
            // 
            this.RIGHT_CHANGE_DATAGRIDVIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RIGHT_CHANGE_DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RIGHT_CHANGE_DATAGRIDVIEW.Location = new System.Drawing.Point(3, 106);
            this.RIGHT_CHANGE_DATAGRIDVIEW.Name = "RIGHT_CHANGE_DATAGRIDVIEW";
            this.RIGHT_CHANGE_DATAGRIDVIEW.Size = new System.Drawing.Size(497, 181);
            this.RIGHT_CHANGE_DATAGRIDVIEW.TabIndex = 8;
            // 
            // RIGHT_HAND_BATTER_LABEL
            // 
            this.RIGHT_HAND_BATTER_LABEL.AutoSize = true;
            this.RIGHT_HAND_BATTER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIGHT_HAND_BATTER_LABEL.Location = new System.Drawing.Point(158, 22);
            this.RIGHT_HAND_BATTER_LABEL.Name = "RIGHT_HAND_BATTER_LABEL";
            this.RIGHT_HAND_BATTER_LABEL.Size = new System.Drawing.Size(183, 25);
            this.RIGHT_HAND_BATTER_LABEL.TabIndex = 2;
            this.RIGHT_HAND_BATTER_LABEL.Text = "Right-Hand Batter";
            // 
            // BATTING_ARM_LABEL
            // 
            this.BATTING_ARM_LABEL.AutoSize = true;
            this.BATTING_ARM_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BATTING_ARM_LABEL.Location = new System.Drawing.Point(168, 20);
            this.BATTING_ARM_LABEL.Name = "BATTING_ARM_LABEL";
            this.BATTING_ARM_LABEL.Size = new System.Drawing.Size(59, 25);
            this.BATTING_ARM_LABEL.TabIndex = 16;
            this.BATTING_ARM_LABEL.Text = "Lefty";
            // 
            // PLAYER_NAME_LABEL
            // 
            this.PLAYER_NAME_LABEL.AutoSize = true;
            this.PLAYER_NAME_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYER_NAME_LABEL.Location = new System.Drawing.Point(21, 20);
            this.PLAYER_NAME_LABEL.Name = "PLAYER_NAME_LABEL";
            this.PLAYER_NAME_LABEL.Size = new System.Drawing.Size(141, 25);
            this.PLAYER_NAME_LABEL.TabIndex = 15;
            this.PLAYER_NAME_LABEL.Text = "Player Name:";
            // 
            // RBI_LABEL
            // 
            this.RBI_LABEL.AutoSize = true;
            this.RBI_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBI_LABEL.Location = new System.Drawing.Point(807, 20);
            this.RBI_LABEL.Name = "RBI_LABEL";
            this.RBI_LABEL.Size = new System.Drawing.Size(91, 25);
            this.RBI_LABEL.TabIndex = 30;
            this.RBI_LABEL.Text = "RBI: xxx";
            // 
            // OPS_LABEL
            // 
            this.OPS_LABEL.AutoSize = true;
            this.OPS_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPS_LABEL.Location = new System.Drawing.Point(683, 20);
            this.OPS_LABEL.Name = "OPS_LABEL";
            this.OPS_LABEL.Size = new System.Drawing.Size(118, 25);
            this.OPS_LABEL.TabIndex = 29;
            this.OPS_LABEL.Text = "OPS: x.xxx";
            // 
            // SLG_LABEL
            // 
            this.SLG_LABEL.AutoSize = true;
            this.SLG_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLG_LABEL.Location = new System.Drawing.Point(556, 20);
            this.SLG_LABEL.Name = "SLG_LABEL";
            this.SLG_LABEL.Size = new System.Drawing.Size(105, 25);
            this.SLG_LABEL.TabIndex = 28;
            this.SLG_LABEL.Text = "SLG: .xxx";
            // 
            // OBP_LABEL
            // 
            this.OBP_LABEL.AutoSize = true;
            this.OBP_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OBP_LABEL.Location = new System.Drawing.Point(431, 20);
            this.OBP_LABEL.Name = "OBP_LABEL";
            this.OBP_LABEL.Size = new System.Drawing.Size(107, 25);
            this.OBP_LABEL.TabIndex = 27;
            this.OBP_LABEL.Text = "OBP: .xxx";
            // 
            // AB_LABEL
            // 
            this.AB_LABEL.AutoSize = true;
            this.AB_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AB_LABEL.Location = new System.Drawing.Point(904, 20);
            this.AB_LABEL.Name = "AB_LABEL";
            this.AB_LABEL.Size = new System.Drawing.Size(85, 25);
            this.AB_LABEL.TabIndex = 26;
            this.AB_LABEL.Text = "AB: xxx";
            // 
            // AVG_LABEL
            // 
            this.AVG_LABEL.AutoSize = true;
            this.AVG_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVG_LABEL.Location = new System.Drawing.Point(309, 20);
            this.AVG_LABEL.Name = "AVG_LABEL";
            this.AVG_LABEL.Size = new System.Drawing.Size(107, 25);
            this.AVG_LABEL.TabIndex = 25;
            this.AVG_LABEL.Text = "AVG: .xxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ChangeUp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "ChangeUp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Slider:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Slider:";
            // 
            // BatterDataDisplayScreenTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RBI_LABEL);
            this.Controls.Add(this.OPS_LABEL);
            this.Controls.Add(this.SLG_LABEL);
            this.Controls.Add(this.OBP_LABEL);
            this.Controls.Add(this.AB_LABEL);
            this.Controls.Add(this.AVG_LABEL);
            this.Controls.Add(this.PREVIOUS_BUTTON);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BATTING_ARM_LABEL);
            this.Controls.Add(this.PLAYER_NAME_LABEL);
            this.Name = "BatterDataDisplayScreenTwo";
            this.Size = new System.Drawing.Size(1011, 779);
            this.Load += new System.EventHandler(this.BatterDataDisplayScreenTwo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_SLIDER_DATAGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_CHANGE_DATAGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHT_SLIDER_DATAGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHT_CHANGE_DATAGRIDVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PREVIOUS_BUTTON;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView LEFT_SLIDER_DATAGRIDVIEW;
        private System.Windows.Forms.DataGridView LEFT_CHANGE_DATAGRIDVIEW;
        private System.Windows.Forms.Label LEFT_HAND_BATTER_LABEL;
        private System.Windows.Forms.DataGridView RIGHT_SLIDER_DATAGRIDVIEW;
        private System.Windows.Forms.DataGridView RIGHT_CHANGE_DATAGRIDVIEW;
        private System.Windows.Forms.Label RIGHT_HAND_BATTER_LABEL;
        private System.Windows.Forms.Label BATTING_ARM_LABEL;
        private System.Windows.Forms.Label PLAYER_NAME_LABEL;
        private System.Windows.Forms.Label RBI_LABEL;
        private System.Windows.Forms.Label OPS_LABEL;
        private System.Windows.Forms.Label SLG_LABEL;
        private System.Windows.Forms.Label OBP_LABEL;
        private System.Windows.Forms.Label AB_LABEL;
        private System.Windows.Forms.Label AVG_LABEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
