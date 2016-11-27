namespace System_of_sports_organizations
{
    partial class User_window
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
            this.components = new System.ComponentModel.Container();
            this.dGV_show = new System.Windows.Forms.DataGridView();
            this.kyrsovoyDataSet = new System_of_sports_organizations.KyrsovoyDataSet();
            this.competitionResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competitionResultsTableAdapter = new System_of_sports_organizations.KyrsovoyDataSetTableAdapters.CompetitionResultsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompetitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSportCompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovoyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionResultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_show
            // 
            this.dGV_show.AllowUserToAddRows = false;
            this.dGV_show.AllowUserToDeleteRows = false;
            this.dGV_show.AllowUserToOrderColumns = true;
            this.dGV_show.AllowUserToResizeColumns = false;
            this.dGV_show.AllowUserToResizeRows = false;
            this.dGV_show.AutoGenerateColumns = false;
            this.dGV_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idCompetitionDataGridViewTextBoxColumn,
            this.idCompositionDataGridViewTextBoxColumn,
            this.idSportCompDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dGV_show.DataSource = this.competitionResultsBindingSource;
            this.dGV_show.Location = new System.Drawing.Point(12, 12);
            this.dGV_show.Name = "dGV_show";
            this.dGV_show.ReadOnly = true;
            this.dGV_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_show.Size = new System.Drawing.Size(590, 486);
            this.dGV_show.TabIndex = 0;
            // 
            // kyrsovoyDataSet
            // 
            this.kyrsovoyDataSet.DataSetName = "KyrsovoyDataSet";
            this.kyrsovoyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competitionResultsBindingSource
            // 
            this.competitionResultsBindingSource.DataMember = "CompetitionResults";
            this.competitionResultsBindingSource.DataSource = this.kyrsovoyDataSet;
            // 
            // competitionResultsTableAdapter
            // 
            this.competitionResultsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCompetitionDataGridViewTextBoxColumn
            // 
            this.idCompetitionDataGridViewTextBoxColumn.DataPropertyName = "id_Competition";
            this.idCompetitionDataGridViewTextBoxColumn.HeaderText = "id_Competition";
            this.idCompetitionDataGridViewTextBoxColumn.Name = "idCompetitionDataGridViewTextBoxColumn";
            this.idCompetitionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCompositionDataGridViewTextBoxColumn
            // 
            this.idCompositionDataGridViewTextBoxColumn.DataPropertyName = "id_Composition";
            this.idCompositionDataGridViewTextBoxColumn.HeaderText = "id_Composition";
            this.idCompositionDataGridViewTextBoxColumn.Name = "idCompositionDataGridViewTextBoxColumn";
            this.idCompositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSportCompDataGridViewTextBoxColumn
            // 
            this.idSportCompDataGridViewTextBoxColumn.DataPropertyName = "id_SportComp";
            this.idSportCompDataGridViewTextBoxColumn.HeaderText = "id_SportComp";
            this.idSportCompDataGridViewTextBoxColumn.Name = "idSportCompDataGridViewTextBoxColumn";
            this.idSportCompDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // User_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 510);
            this.Controls.Add(this.dGV_show);
            this.MaximizeBox = false;
            this.Name = "User_window";
            this.Text = "User_window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_window_FormClosed);
            this.Load += new System.EventHandler(this.User_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovoyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionResultsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_show;
        private KyrsovoyDataSet kyrsovoyDataSet;
        private System.Windows.Forms.BindingSource competitionResultsBindingSource;
        private KyrsovoyDataSetTableAdapters.CompetitionResultsTableAdapter competitionResultsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompetitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSportCompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}