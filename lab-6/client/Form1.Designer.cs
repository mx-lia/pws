namespace client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.studentsGrid = new System.Windows.Forms.DataGridView();
            this.stdId = new System.Windows.Forms.NumericUpDown();
            this.stdName = new System.Windows.Forms.TextBox();
            this.createStd = new System.Windows.Forms.Button();
            this.updateStd = new System.Windows.Forms.Button();
            this.deleteStd = new System.Windows.Forms.Button();
            this.deleteNote = new System.Windows.Forms.Button();
            this.updateNote = new System.Windows.Forms.Button();
            this.createNote = new System.Windows.Forms.Button();
            this.subj = new System.Windows.Forms.TextBox();
            this.noteId = new System.Windows.Forms.NumericUpDown();
            this.notesGrid = new System.Windows.Forms.DataGridView();
            this.note = new System.Windows.Forms.NumericUpDown();
            this.fk_stdId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fk_stdId)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 499);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.deleteStd);
            this.tabPage1.Controls.Add(this.updateStd);
            this.tabPage1.Controls.Add(this.createStd);
            this.tabPage1.Controls.Add(this.stdName);
            this.tabPage1.Controls.Add(this.stdId);
            this.tabPage1.Controls.Add(this.studentsGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.fk_stdId);
            this.tabPage2.Controls.Add(this.note);
            this.tabPage2.Controls.Add(this.deleteNote);
            this.tabPage2.Controls.Add(this.updateNote);
            this.tabPage2.Controls.Add(this.createNote);
            this.tabPage2.Controls.Add(this.subj);
            this.tabPage2.Controls.Add(this.noteId);
            this.tabPage2.Controls.Add(this.notesGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(865, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // studentsGrid
            // 
            this.studentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGrid.Location = new System.Drawing.Point(7, 7);
            this.studentsGrid.Name = "studentsGrid";
            this.studentsGrid.RowHeadersWidth = 51;
            this.studentsGrid.RowTemplate.Height = 24;
            this.studentsGrid.Size = new System.Drawing.Size(604, 453);
            this.studentsGrid.TabIndex = 0;
            // 
            // stdId
            // 
            this.stdId.Location = new System.Drawing.Point(617, 27);
            this.stdId.Name = "stdId";
            this.stdId.Size = new System.Drawing.Size(242, 22);
            this.stdId.TabIndex = 1;
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(617, 99);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(242, 22);
            this.stdName.TabIndex = 2;
            // 
            // createStd
            // 
            this.createStd.Location = new System.Drawing.Point(617, 188);
            this.createStd.Name = "createStd";
            this.createStd.Size = new System.Drawing.Size(242, 35);
            this.createStd.TabIndex = 3;
            this.createStd.Text = "CREATE";
            this.createStd.UseVisualStyleBackColor = true;
            this.createStd.Click += new System.EventHandler(this.createStd_Click);
            // 
            // updateStd
            // 
            this.updateStd.Location = new System.Drawing.Point(617, 229);
            this.updateStd.Name = "updateStd";
            this.updateStd.Size = new System.Drawing.Size(242, 35);
            this.updateStd.TabIndex = 4;
            this.updateStd.Text = "UPDATE";
            this.updateStd.UseVisualStyleBackColor = true;
            this.updateStd.Click += new System.EventHandler(this.updateStd_Click);
            // 
            // deleteStd
            // 
            this.deleteStd.Location = new System.Drawing.Point(617, 270);
            this.deleteStd.Name = "deleteStd";
            this.deleteStd.Size = new System.Drawing.Size(242, 35);
            this.deleteStd.TabIndex = 5;
            this.deleteStd.Text = "DELETE";
            this.deleteStd.UseVisualStyleBackColor = true;
            this.deleteStd.Click += new System.EventHandler(this.deleteStd_Click);
            // 
            // deleteNote
            // 
            this.deleteNote.Location = new System.Drawing.Point(616, 368);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(242, 35);
            this.deleteNote.TabIndex = 11;
            this.deleteNote.Text = "DELETE";
            this.deleteNote.UseVisualStyleBackColor = true;
            this.deleteNote.Click += new System.EventHandler(this.deleteNote_Click);
            // 
            // updateNote
            // 
            this.updateNote.Location = new System.Drawing.Point(616, 327);
            this.updateNote.Name = "updateNote";
            this.updateNote.Size = new System.Drawing.Size(242, 35);
            this.updateNote.TabIndex = 10;
            this.updateNote.Text = "UPDATE";
            this.updateNote.UseVisualStyleBackColor = true;
            this.updateNote.Click += new System.EventHandler(this.updateNote_Click);
            // 
            // createNote
            // 
            this.createNote.Location = new System.Drawing.Point(616, 286);
            this.createNote.Name = "createNote";
            this.createNote.Size = new System.Drawing.Size(242, 35);
            this.createNote.TabIndex = 9;
            this.createNote.Text = "CREATE";
            this.createNote.UseVisualStyleBackColor = true;
            this.createNote.Click += new System.EventHandler(this.createNote_Click);
            // 
            // subj
            // 
            this.subj.Location = new System.Drawing.Point(616, 87);
            this.subj.Name = "subj";
            this.subj.Size = new System.Drawing.Size(242, 22);
            this.subj.TabIndex = 8;
            // 
            // noteId
            // 
            this.noteId.Location = new System.Drawing.Point(616, 29);
            this.noteId.Name = "noteId";
            this.noteId.Size = new System.Drawing.Size(242, 22);
            this.noteId.TabIndex = 7;
            // 
            // notesGrid
            // 
            this.notesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesGrid.Location = new System.Drawing.Point(6, 9);
            this.notesGrid.Name = "notesGrid";
            this.notesGrid.RowHeadersWidth = 51;
            this.notesGrid.RowTemplate.Height = 24;
            this.notesGrid.Size = new System.Drawing.Size(604, 453);
            this.notesGrid.TabIndex = 6;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(616, 146);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(242, 22);
            this.note.TabIndex = 12;
            // 
            // fk_stdId
            // 
            this.fk_stdId.Location = new System.Drawing.Point(616, 225);
            this.fk_stdId.Name = "fk_stdId";
            this.fk_stdId.Size = new System.Drawing.Size(242, 22);
            this.fk_stdId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Note ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Note:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Student ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Student ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 524);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fk_stdId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView studentsGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button deleteStd;
        private System.Windows.Forms.Button updateStd;
        private System.Windows.Forms.Button createStd;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.NumericUpDown stdId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fk_stdId;
        private System.Windows.Forms.NumericUpDown note;
        private System.Windows.Forms.Button deleteNote;
        private System.Windows.Forms.Button updateNote;
        private System.Windows.Forms.Button createNote;
        private System.Windows.Forms.TextBox subj;
        private System.Windows.Forms.NumericUpDown noteId;
        private System.Windows.Forms.DataGridView notesGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

