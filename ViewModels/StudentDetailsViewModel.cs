using ShellLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellLesson.ViewModels
{
    [QueryProperty(nameof(SelectedStudent), "selectedStudent")]
    public class StudentDetailsViewModel:ViewModelBase
    {
        private Student selectedStudent;
        public Student SelectedStudent
        {
            get
            {
                return this.selectedStudent;
            }
            set
            {
                this.selectedStudent = value;
                OnPropertyChanged();
            }
        }
    }
}
