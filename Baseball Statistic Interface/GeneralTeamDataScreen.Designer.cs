namespace Baseball_Statistic_Interface
{
    partial class GeneralTeamDataScreen
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
            this.TEAM_NAME_RATIO_DISPLAY = new System.Windows.Forms.Label();
            this.GENERAL_DATAGRIDVIEW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GENERAL_DATAGRIDVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // TEAM_NAME_RATIO_DISPLAY
            // 
            this.TEAM_NAME_RATIO_DISPLAY.AutoSize = true;
            this.TEAM_NAME_RATIO_DISPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEAM_NAME_RATIO_DISPLAY.Location = new System.Drawing.Point(361, 15);
            this.TEAM_NAME_RATIO_DISPLAY.Name = "TEAM_NAME_RATIO_DISPLAY";
            this.TEAM_NAME_RATIO_DISPLAY.Size = new System.Drawing.Size(266, 31);
            this.TEAM_NAME_RATIO_DISPLAY.TabIndex = 23;
            this.TEAM_NAME_RATIO_DISPLAY.Text = "Team Name: W/T/L";
            this.TEAM_NAME_RATIO_DISPLAY.Click += new System.EventHandler(this.TEAM_NAME_RATIO_DISPLAY_Click);
            // 
            // GENERAL_DATAGRIDVIEW
            // 
            this.GENERAL_DATAGRIDVIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GENERAL_DATAGRIDVIEW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.GENERAL_DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GENERAL_DATAGRIDVIEW.Location = new System.Drawing.Point(16, 80);
            this.GENERAL_DATAGRIDVIEW.Name = "GENERAL_DATAGRIDVIEW";
            this.GENERAL_DATAGRIDVIEW.Size = new System.Drawing.Size(981, 683);
            this.GENERAL_DATAGRIDVIEW.TabIndex = 24;
            // 
            // GeneralTeamDataScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GENERAL_DATAGRIDVIEW);
            this.Controls.Add(this.TEAM_NAME_RATIO_DISPLAY);
            this.Name = "GeneralTeamDataScreen";
            this.Size = new System.Drawing.Size(1011, 779);
            this.Load += new System.EventHandler(this.GeneralTeamDataScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GENERAL_DATAGRIDVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TEAM_NAME_RATIO_DISPLAY;
        private System.Windows.Forms.DataGridView GENERAL_DATAGRIDVIEW;
    }
}
