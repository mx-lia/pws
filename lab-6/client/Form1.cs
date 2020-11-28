using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        Model.Entities entities;

        public Form1()
        {
            InitializeComponent();
            entities = new Model.Entities(new Uri("http://localhost:54422/WcfDataService.svc/"));
            studentsGrid.DataSource = entities.Students.ToList();
            notesGrid.DataSource = entities.Notes.ToList();
        }

        private void createStd_Click(object sender, EventArgs e)
        {
            Model.Student student = new Model.Student();
            student.name = stdName.Text;

            entities.AddToStudents(student);
            entities.SaveChanges();

            studentsGrid.DataSource = entities.Students.ToList();
        }

        private void updateStd_Click(object sender, EventArgs e)
        {
            Model.Student student = entities.Students.Where(s => s.studentId == (int)stdId.Value).FirstOrDefault();
            student.name = stdName.Text;

            entities.UpdateObject(student);
            entities.SaveChanges();

            studentsGrid.DataSource = entities.Students.ToList();
        }

        private void deleteStd_Click(object sender, EventArgs e)
        {
            Model.Student student = entities.Students.Where(s => s.studentId == (int)stdId.Value).FirstOrDefault();

            entities.DeleteObject(student);
            entities.SaveChanges();

            studentsGrid.DataSource = entities.Students.ToList();
        }

        private void createNote_Click(object sender, EventArgs e)
        {
            Model.Note note = new Model.Note();
            note.subj = subj.Text;
            note.note1 = (int)this.note.Value;
            note.studentId = (int)fk_stdId.Value;

            entities.AddToNotes(note);
            entities.SaveChanges();

            notesGrid.DataSource = entities.Notes.ToList();
        }

        private void updateNote_Click(object sender, EventArgs e)
        {
            Model.Note note = entities.Notes.Where(s => s.noteId == (int)noteId.Value).FirstOrDefault();
            note.subj = subj.Text;
            note.note1 = (int)this.note.Value;
            note.studentId = (int)fk_stdId.Value;

            entities.UpdateObject(note);
            entities.SaveChanges();

            notesGrid.DataSource = entities.Notes.ToList();
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            Model.Note note = entities.Notes.Where(s => s.noteId == (int)noteId.Value).FirstOrDefault();

            entities.DeleteObject(note);
            entities.SaveChanges();

            notesGrid.DataSource = entities.Notes.ToList();
        }
    }
}
