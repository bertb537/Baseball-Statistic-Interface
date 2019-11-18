namespace Baseball_Statistic_Interface
{
    partial class PitcherDataDisplayScreen
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
            this.PLAYER_NAME_LABEL = new System.Windows.Forms.Label();
            this.LEFT_RIGHT_HAND_BATTER = new System.Windows.Forms.SplitContainer();
            this.THROWING_ARM_LABEL = new System.Windows.Forms.Label();
            this.ERA_LABEL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LEFT_HAND_BATTER_LABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_RIGHT_HAND_BATTER)).BeginInit();
            this.LEFT_RIGHT_HAND_BATTER.Panel1.SuspendLayout();
            this.LEFT_RIGHT_HAND_BATTER.Panel2.SuspendLayout();
            this.LEFT_RIGHT_HAND_BATTER.SuspendLayout();
            this.SuspendLayout();
            // 
            // PLAYER_NAME_LABEL
            // 
            this.PLAYER_NAME_LABEL.AutoSize = true;
            this.PLAYER_NAME_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYER_NAME_LABEL.Location = new System.Drawing.Point(24, 23);
            this.PLAYER_NAME_LABEL.Name = "PLAYER_NAME_LABEL";
            this.PLAYER_NAME_LABEL.Size = new System.Drawing.Size(141, 25);
            this.PLAYER_NAME_LABEL.TabIndex = 0;
            this.PLAYER_NAME_LABEL.Text = "Player Name:";
            // 
            // LEFT_RIGHT_HAND_BATTER
            // 
            this.LEFT_RIGHT_HAND_BATTER.Location = new System.Drawing.Point(3, 69);
            this.LEFT_RIGHT_HAND_BATTER.Name = "LEFT_RIGHT_HAND_BATTER";
            // 
            // LEFT_RIGHT_HAND_BATTER.Panel1
            // 
            this.LEFT_RIGHT_HAND_BATTER.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.LEFT_RIGHT_HAND_BATTER.Panel1.Controls.Add(this.LEFT_HAND_BATTER_LABEL);
            this.LEFT_RIGHT_HAND_BATTER.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // LEFT_RIGHT_HAND_BATTER.Panel2
            // 
            this.LEFT_RIGHT_HAND_BATTER.Panel2.Controls.Add(this.label1);
            this.LEFT_RIGHT_HAND_BATTER.Size = new System.Drawing.Size(1005, 707);
            this.LEFT_RIGHT_HAND_BATTER.SplitterDistance = 500;
            this.LEFT_RIGHT_HAND_BATTER.TabIndex = 1;
            this.LEFT_RIGHT_HAND_BATTER.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // THROWING_ARM_LABEL
            // 
            this.THROWING_ARM_LABEL.AutoSize = true;
            this.THROWING_ARM_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THROWING_ARM_LABEL.Location = new System.Drawing.Point(171, 23);
            this.THROWING_ARM_LABEL.Name = "THROWING_ARM_LABEL";
            this.THROWING_ARM_LABEL.Size = new System.Drawing.Size(59, 25);
            this.THROWING_ARM_LABEL.TabIndex = 2;
            this.THROWING_ARM_LABEL.Text = "Lefty";
            // 
            // ERA_LABEL
            // 
            this.ERA_LABEL.AutoSize = true;
            this.ERA_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERA_LABEL.Location = new System.Drawing.Point(785, 23);
            this.ERA_LABEL.Name = "ERA_LABEL";
            this.ERA_LABEL.Size = new System.Drawing.Size(106, 25);
            this.ERA_LABEL.TabIndex = 3;
            this.ERA_LABEL.Text = "ERA: .xxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(897, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "MA: xxx";
            // 
            // LEFT_HAND_BATTER_LABEL
            // 
            this.LEFT_HAND_BATTER_LABEL.AutoSize = true;
            this.LEFT_HAND_BATTER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEFT_HAND_BATTER_LABEL.Location = new System.Drawing.Point(158, 19);
            this.LEFT_HAND_BATTER_LABEL.Name = "LEFT_HAND_BATTER_LABEL";
            this.LEFT_HAND_BATTER_LABEL.Size = new System.Drawing.Size(169, 25);
            this.LEFT_HAND_BATTER_LABEL.TabIndex = 0;
            this.LEFT_HAND_BATTER_LABEL.Text = "Left-Hand Batter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Left-Hand Batter";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 204);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PitcherDataDisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ERA_LABEL);
            this.Controls.Add(this.THROWING_ARM_LABEL);
            this.Controls.Add(this.LEFT_RIGHT_HAND_BATTER);
            this.Controls.Add(this.PLAYER_NAME_LABEL);
            this.Name = "PitcherDataDisplayScreen";
            this.Size = new System.Drawing.Size(1011, 779);
            this.LEFT_RIGHT_HAND_BATTER.Panel1.ResumeLayout(false);
            this.LEFT_RIGHT_HAND_BATTER.Panel1.PerformLayout();
            this.LEFT_RIGHT_HAND_BATTER.Panel2.ResumeLayout(false);
            this.LEFT_RIGHT_HAND_BATTER.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_RIGHT_HAND_BATTER)).EndInit();
            this.LEFT_RIGHT_HAND_BATTER.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PLAYER_NAME_LABEL;
        private System.Windows.Forms.SplitContainer LEFT_RIGHT_HAND_BATTER;
        private System.Windows.Forms.Label THROWING_ARM_LABEL;
        private System.Windows.Forms.Label ERA_LABEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LEFT_HAND_BATTER_LABEL;
        private System.Windows.Forms.Label label1;
    }
}
