namespace Voice_command
{
    partial class Add_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Edit));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_NameCommand = new System.Windows.Forms.TextBox();
            this.tB_PronunciationCommand = new System.Windows.Forms.TextBox();
            this.tB_PathFile = new System.Windows.Forms.TextBox();
            this.tB_CloseProcess = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pronunciation command";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Path file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Close process";
            // 
            // tB_NameCommand
            // 
            this.tB_NameCommand.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_NameCommand.Location = new System.Drawing.Point(12, 33);
            this.tB_NameCommand.Name = "tB_NameCommand";
            this.tB_NameCommand.Size = new System.Drawing.Size(201, 29);
            this.tB_NameCommand.TabIndex = 6;
            this.tB_NameCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_NameCommand_KeyPress);
            // 
            // tB_PronunciationCommand
            // 
            this.tB_PronunciationCommand.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_PronunciationCommand.Location = new System.Drawing.Point(255, 33);
            this.tB_PronunciationCommand.Name = "tB_PronunciationCommand";
            this.tB_PronunciationCommand.Size = new System.Drawing.Size(201, 29);
            this.tB_PronunciationCommand.TabIndex = 7;
            this.tB_PronunciationCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_PronunciationCommand_KeyPress);
            // 
            // tB_PathFile
            // 
            this.tB_PathFile.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_PathFile.Location = new System.Drawing.Point(12, 170);
            this.tB_PathFile.Name = "tB_PathFile";
            this.tB_PathFile.Size = new System.Drawing.Size(360, 29);
            this.tB_PathFile.TabIndex = 8;
            this.tB_PathFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_PathFile_KeyPress);
            // 
            // tB_CloseProcess
            // 
            this.tB_CloseProcess.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_CloseProcess.Location = new System.Drawing.Point(12, 100);
            this.tB_CloseProcess.Name = "tB_CloseProcess";
            this.tB_CloseProcess.Size = new System.Drawing.Size(201, 29);
            this.tB_CloseProcess.TabIndex = 9;
            this.tB_CloseProcess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_CloseProcess_KeyPress);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(381, 170);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(87, 29);
            this.btn_Browse.TabIndex = 10;
            this.btn_Browse.Text = "Browse...";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(12, 218);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(456, 48);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add command";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(12, 218);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(456, 48);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "Edit command";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Visible = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Add_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 273);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.tB_CloseProcess);
            this.Controls.Add(this.tB_PathFile);
            this.Controls.Add(this.tB_PronunciationCommand);
            this.Controls.Add(this.tB_NameCommand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Edit_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Browse;
        public System.Windows.Forms.TextBox tB_NameCommand;
        public System.Windows.Forms.TextBox tB_PronunciationCommand;
        public System.Windows.Forms.TextBox tB_PathFile;
        public System.Windows.Forms.TextBox tB_CloseProcess;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.Button btn_Edit;
    }
}