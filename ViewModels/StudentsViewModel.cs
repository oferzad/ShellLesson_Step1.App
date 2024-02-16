using ShellLesson.Models;
using ShellLesson.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShellLesson.ViewModels
{
    public class StudentsViewModel : ViewModelBase
    {
        private ObservableCollection<Student> students;
        public ObservableCollection<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
                OnPropertyChanged();
            }
        }

        private StudentsService studentsService;
        public StudentsViewModel(StudentsService service)
        {
            this.studentsService = service;
            students = new ObservableCollection<Student>();
            ReadStudents();
        }

        private async void ReadStudents()
        {
            StudentsService service = this.studentsService;
            List<Student> list = await service.GetStudents();
            this.Students = new ObservableCollection<Student>(list);
        }


        #region Single Selection
        private Object selectedStudent;
        public Object SelectedStudent
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

        public ICommand SingleSelectCommand => new Command(OnSingleSelectStudent);

        async void OnSingleSelectStudent()
        {
            if (SelectedStudent != null)
            {
                var navParam = new Dictionary<string, object>()
                {
                    { "selectedStudent",SelectedStudent}
                };

                //Add goto here to show details
                await Shell.Current.GoToAsync($"studentDetails", navParam);
                
                SelectedStudent = null;
            }
        }


        #endregion


    }
}

