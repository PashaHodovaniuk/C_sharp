namespace System_of_sports_organizations
{
    partial class Administrator_window
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.tB_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_Search = new System.Windows.Forms.ComboBox();
            this.cB_select = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dGV_show = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_show)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Enabled = false;
            this.btn_Search.Location = new System.Drawing.Point(647, 243);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(236, 35);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Поиск";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tB_Search
            // 
            this.tB_Search.Enabled = false;
            this.tB_Search.Location = new System.Drawing.Point(647, 203);
            this.tB_Search.Name = "tB_Search";
            this.tB_Search.Size = new System.Drawing.Size(236, 20);
            this.tB_Search.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Введите значение поиска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Выберите поле для поиска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выбор таблицы";
            // 
            // cB_Search
            // 
            this.cB_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Search.Enabled = false;
            this.cB_Search.FormattingEnabled = true;
            this.cB_Search.Location = new System.Drawing.Point(644, 158);
            this.cB_Search.Name = "cB_Search";
            this.cB_Search.Size = new System.Drawing.Size(239, 21);
            this.cB_Search.TabIndex = 11;
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
            this.cB_select.Location = new System.Drawing.Point(644, 33);
            this.cB_select.Name = "cB_select";
            this.cB_select.Size = new System.Drawing.Size(239, 21);
            this.cB_select.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Просмотр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV_show
            // 
            this.dGV_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGV_show.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_show.Location = new System.Drawing.Point(0, 16);
            this.dGV_show.Name = "dGV_show";
            this.dGV_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_show.Size = new System.Drawing.Size(638, 486);
            this.dGV_show.TabIndex = 8;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(647, 303);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(236, 43);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Administrator_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 518);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tB_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_Search);
            this.Controls.Add(this.cB_select);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGV_show);
            this.Name = "Administrator_window";
            this.Text = "Administrator_window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrator_window_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tB_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_Search;
        private System.Windows.Forms.ComboBox cB_select;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dGV_show;
        private System.Windows.Forms.Button btn_Save;
    }
}