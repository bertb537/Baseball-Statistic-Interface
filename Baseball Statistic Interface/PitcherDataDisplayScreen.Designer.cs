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
            this.LEFT_O_TWO_DATAGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.LEFT_OPENER_DATAGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.LEFT_HAND_BATTER_LABEL = new System.Windows.Forms.Label();
            this.RIGHT_O_TWO_DATAGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.RIGHT_OPENER_DATAGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.RIGHT_HAND_BATTER_LABEL = new System.Windows.Forms.Label();
            this.THROWING_ARM_LABEL = new System.Windows.Forms.Label();
            this.ERA_LABEL = new System.Windows.Forms.Label();
            this.MA_LABEL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_RIGHT_HAND_BATTER)).BeginInit();
            this.LEFT_RIGHT_HAND_BATTER.Panel1.SuspendLayout();
            this.LEFT_RIGHT_HAND_BATTER.Panel2.SuspendLayout();
            this.LEFT_RIGHT_HAND_BATTER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_O_TWO_DATAGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_OPENER_DATAGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHT_O_TWO_DATAGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHT_OPENER_DATAGRIDVIEW)).BeginInit();
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
            this.PLAYER_NAME_LABEL.Click += new System.EventHandler(this.PLAYER_NAME_LABEL_Click);
            // 
            // LEFT_RIGHT_HAND_BATTER
            // 
            this.LEFT_RIGHT_HAND_BATTER.Location = new System.Drawing.Point(3, 69);
            this.LEFT_RIGHT_HAND_BATTER.Name = "LEFT_RIGHT_HAND_BATTER";
            // 
            // LEFT_RIGHT_HAND_BATTER.Panel1
            // 
            this.LEFT_RIGHT_HAND_BATTER.Panel1.Controls.Add(this.LEFT_O_TWO_DATAGRIDVIEW);
            this.LEFT_RIGHT_HAND_BATTER.Panel1.Controls.Add(this.LEFT_OPENER_DATAGRIDVIEW);
            this.LEFT_RIGHT_HAND_BATTER.Panel1.Controls.Add(this.LEFT_HAND_BATTER_LABEL);
            this.LEFT_RIGHT_HAND_BATTER.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // LEFT_RIGHT_HAND_BATTER.Panel2
            // 
            this.LEFT_RIGHT_HAND_BATTER.Panel2.Controls.Add(this.RIGHT_O_TWO_DATAGRIDVIEW);
            this.LEFT_RIGHT_HAND_BATTER.Panel2.Controls.Add(this.RIGHT_OPENER_DATAGRIDVIEW);
            this.LEFT_RIGHT_HAND_BATTER.Panel2.Controls.Add(this.RIGHT_HAND_BATTER_LABEL);
            this.LEFT_RIGHT_HAND_BATTER.Size = new System.Drawing.Size(1005, 707);
            this.LEFT_RIGHT_HAND_BATTER.SplitterDistance = 500;
            this.LEFT_RIGHT_HAND_BATTER.TabIndex = 1;
            this.LEFT_RIGHT_HAND_BATTER.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // LEFT_O_TWO_DATAGRIDVIEW
            // 
            this.LEFT_O_TWO_DATAGRIDVIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LEFT_O_TWO_DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LEFT_O_TWO_DATAGRIDVIEW.Location = new System.Drawing.Point(3, 384);
            this.LEFT_O_TWO_DATAGRIDVIEW.Name = "LEFT_O_TWO_DATAGRIDVIEW";
            this.LEFT_O_TWO_DATAGRIDVIEW.Size = new System.Drawing.Size(494, 256);
            this.LEFT_O_TWO_DATAGRIDVIEW.TabIndex = 2;
            // 
            // LEFT_OPENER_DATAGRIDVIEW
            // 
            this.LEFT_OPENER_DATAGRIDVIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LEFT_OPENER_DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LEFT_OPENER_DATAGRIDVIEW.Location = new System.Drawing.Point(3, 64);
            this.LEFT_OPENER_DATAGRIDVIEW.Name = "LEFT_OPENER_DATAGRIDVIEW";
            this.LEFT_OPENER_DATAGRIDVIEW.Size = new System.Drawing.Size(494, 256);
            this.LEFT_OPENER_DATAGRIDVIEW.TabIndex = 1;
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
            // RIGHT_O_TWO_DATAGRIDVIEW
            // 
            this.RIGHT_O_TWO_DATAGRIDVIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RIGHT_O_TWO_DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RIGHT_O_TWO_DATAGRIDVIEW.Location = new System.Drawing.Point(3, 384);
            this.RIGHT_O_TWO_DATAGRIDVIEW.Name = "RIGHT_O_TWO_DATAGRIDVIEW";
            this.RIGHT_O_TWO_DATAGRIDVIEW.Size = new System.Drawing.Size(495, 256);
            this.RIGHT_O_TWO_DATAGRIDVIEW.TabIndex = 3;
            // 
            // RIGHT_OPENER_DATAGRIDVIEW
            // 
            this.RIGHT_OPENER_DATAGRIDVIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RIGHT_OPENER_DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RIGHT_OPENER_DATAGRIDVIEW.Location = new System.Drawing.Point(3, 64);
            this.RIGHT_OPENER_DATAGRIDVIEW.Name = "RIGHT_OPENER_DATAGRIDVIEW";
            this.RIGHT_OPENER_DATAGRIDVIEW.Size = new System.Drawing.Size(495, 256);
            this.RIGHT_OPENER_DATAGRIDVIEW.TabIndex = 2;
            // 
            // RIGHT_HAND_BATTER_LABEL
            // 
            this.RIGHT_HAND_BATTER_LABEL.AutoSize = true;
            this.RIGHT_HAND_BATTER_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIGHT_HAND_BATTER_LABEL.Location = new System.Drawing.Point(157, 19);
            this.RIGHT_HAND_BATTER_LABEL.Name = "RIGHT_HAND_BATTER_LABEL";
            this.RIGHT_HAND_BATTER_LABEL.Size = new System.Drawing.Size(183, 25);
            this.RIGHT_HAND_BATTER_LABEL.TabIndex = 1;
            this.RIGHT_HAND_BATTER_LABEL.Text = "Right-Hand Batter";
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
            // MA_LABEL
            // 
            this.MA_LABEL.AutoSize = true;
            this.MA_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MA_LABEL.Location = new System.Drawing.Point(897, 23);
            this.MA_LABEL.Name = "MA_LABEL";
            this.MA_LABEL.Size = new System.Drawing.Size(89, 25);
            this.MA_LABEL.TabIndex = 4;
            this.MA_LABEL.Text = "MA: xxx";
            // 
            // PitcherDataDisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MA_LABEL);
            this.Controls.Add(this.ERA_LABEL);
            this.Controls.Add(this.THROWING_ARM_LABEL);
            this.Controls.Add(this.LEFT_RIGHT_HAND_BATTER);
            this.Controls.Add(this.PLAYER_NAME_LABEL);
            this.Name = "PitcherDataDisplayScreen";
            this.Size = new System.Drawing.Size(1011, 779);
            this.Load += new System.EventHandler(this.PitcherDataDisplayScreen_Load);
            this.LEFT_RIGHT_HAND_BATTER.Panel1.ResumeLayout(false);
            this.LEFT_RIGHT_HAND_BATTER.Panel1.PerformLayout();
            this.LEFT_RIGHT_HAND_BATTER.Panel2.ResumeLayout(false);
            this.LEFT_RIGHT_HAND_BATTER.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_RIGHT_HAND_BATTER)).EndInit();
            this.LEFT_RIGHT_HAND_BATTER.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_O_TWO_DATAGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEFT_OPENER_DATAGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHT_O_TWO_DATAGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHT_OPENER_DATAGRIDVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PLAYER_NAME_LABEL;
        private System.Windows.Forms.SplitContainer LEFT_RIGHT_HAND_BATTER;
        private System.Windows.Forms.Label THROWING_ARM_LABEL;
        private System.Windows.Forms.Label ERA_LABEL;
        private System.Windows.Forms.Label MA_LABEL;
        private System.Windows.Forms.Label LEFT_HAND_BATTER_LABEL;
        private System.Windows.Forms.Label RIGHT_HAND_BATTER_LABEL;
        private System.Windows.Forms.DataGridView LEFT_O_TWO_DATAGRIDVIEW;
        private System.Windows.Forms.DataGridView LEFT_OPENER_DATAGRIDVIEW;
        private System.Windows.Forms.DataGridView RIGHT_O_TWO_DATAGRIDVIEW;
        private System.Windows.Forms.DataGridView RIGHT_OPENER_DATAGRIDVIEW;
    }
}
