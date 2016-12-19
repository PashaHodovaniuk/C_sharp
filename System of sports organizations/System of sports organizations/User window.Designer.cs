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
            this.competitionResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovoyDataSet = new System_of_sports_organizations.KyrsovoyDataSet();
            this.competitionResultsTableAdapter = new System_of_sports_organizations.KyrsovoyDataSetTableAdapters.CompetitionResultsTableAdapter();
            this.sportCompBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportCompTableAdapter = new System_of_sports_organizations.KyrsovoyDataSetTableAdapters.SportCompTableAdapter();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competitionTableAdapter = new System_of_sports_organizations.KyrsovoyDataSetTableAdapters.CompetitionTableAdapter();
            this.competitionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovoyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cB_select = new System.Windows.Forms.ComboBox();
            this.cB_Search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovoyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportCompBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovoyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_show
            // 
            this.dGV_show.AllowUserToAddRows = false;
            this.dGV_show.AllowUserToDeleteRows = false;
            this.dGV_show.AllowUserToOrderColumns = true;
            this.dGV_show.AllowUserToResizeColumns = false;
            this.dGV_show.AllowUserToResizeRows = false;
            this.dGV_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGV_show.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_show.Location = new System.Drawing.Point(12, 12);
            this.dGV_show.Name = "dGV_show";
            this.dGV_show.ReadOnly = true;
            this.dGV_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_show.Size = new System.Drawing.Size(638, 486);
            this.dGV_show.TabIndex = 0;
            // 
            // competitionResultsBindingSource
            // 
            this.competitionResultsBindingSource.DataMember = "CompetitionResults";
            this.competitionResultsBindingSource.DataSource = this.kyrsovoyDataSet;
            // 
            // kyrsovoyDataSet
            // 
            this.kyrsovoyDataSet.DataSetName = "KyrsovoyDataSet";
            this.kyrsovoyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competitionResultsTableAdapter
            // 
            this.competitionResultsTableAdapter.ClearBeforeFill = true;
            // 
            // sportCompBindingSource
            // 
            this.sportCompBindingSource.DataMember = "SportComp";
            this.sportCompBindingSource.DataSource = this.kyrsovoyDataSet;
            // 
            // sportCompTableAdapter
            // 
            this.sportCompTableAdapter.ClearBeforeFill = true;
            // 
            // competitionBindingSource
            // 
            this.competitionBindingSource.DataMember = "Competition";
            this.competitionBindingSource.DataSource = this.kyrsovoyDataSet;
            // 
            // competitionTableAdapter
            // 
            this.competitionTableAdapter.ClearBeforeFill = true;
            // 
            // competitionBindingSource1
            // 
            this.competitionBindingSource1.DataMember = "Competition";
            this.competitionBindingSource1.DataSource = this.kyrsovoyDataSet;
            // 
            // kyrsovoyDataSetBindingSource
            // 
            this.kyrsovoyDataSetBindingSource.DataSource = this.kyrsovoyDataSet;
            this.kyrsovoyDataSetBindingSource.Position = 0;
            // 
            // compositionBindingSource
            // 
            this.compositionBindingSource.DataMember = "Composition";
            this.compositionBindingSource.DataSource = this.kyrsovoyDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Просмотр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cB_select
            // 
            this.cB_select.AllowDrop = true;
            this.cB_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_select.FormattingEnabled = true;
            this.cB_select.Items.AddRange(new object[] {
            "Тренер",
            "Спортсмен",
            "График соревнований",
            "Результаты соревнований"});
            this.cB_select.Location = new System.Drawing.Point(656, 45);
            this.cB_select.Name = "cB_select";
            this.cB_select.Size = new System.Drawing.Size(239, 21);
            this.cB_select.TabIndex = 1;
            this.cB_select.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cB_select_KeyPress);
            // 
            // cB_Search
            // 
            this.cB_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Search.Enabled = false;
            this.cB_Search.FormattingEnabled = true;
            this.cB_Search.Location = new System.Drawing.Point(656, 170);
            this.cB_Search.Name = "cB_Search";
            this.cB_Search.Size = new System.Drawing.Size(239, 21);
            this.cB_Search.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите поле для поиска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите значение поиска";
            // 
            // tB_Search
            // 
            this.tB_Search.Enabled = false;
            this.tB_Search.Location = new System.Drawing.Point(659, 215);
            this.tB_Search.Name = "tB_Search";
            this.tB_Search.Size = new System.Drawing.Size(236, 20);
            this.tB_Search.TabIndex = 6;
            // 
            // btn_Search
            // 
            this.btn_Search.Enabled = false;
            this.btn_Search.Location = new System.Drawing.Point(659, 255);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(236, 35);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Поиск";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // User_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 510);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tB_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_Search);
            this.Controls.Add(this.cB_select);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGV_show);
            this.MaximizeBox = false;
            this.Name = "User_window";
            this.Text = "Пользователь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_window_FormClosed);
            this.Load += new System.EventHandler(this.User_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovoyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportCompBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovoyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_show;
        private KyrsovoyDataSet kyrsovoyDataSet;
        private System.Windows.Forms.BindingSource competitionResultsBindingSource;
        private KyrsovoyDataSetTableAdapters.CompetitionResultsTableAdapter competitionResultsTableAdapter;
        private System.Windows.Forms.BindingSource sportCompBindingSource;
        private KyrsovoyDataSetTableAdapters.SportCompTableAdapter sportCompTableAdapter;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private KyrsovoyDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private System.Windows.Forms.BindingSource kyrsovoyDataSetBindingSource;
        private System.Windows.Forms.BindingSource competitionBindingSource1;
        private System.Windows.Forms.BindingSource compositionBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cB_select;
        private System.Windows.Forms.ComboBox cB_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Search;
        private System.Windows.Forms.Button btn_Search;
    }
}