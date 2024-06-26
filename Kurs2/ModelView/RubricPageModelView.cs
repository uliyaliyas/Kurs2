using Kurs2.Model;
using Kurs2.View;
using KursProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs2.ModelView
{
    class RubricPageModelView: BaseClass
    {
        private KursDbContext db;
        private ObservableCollection<Rubric> rubricList;

        public ObservableCollection<Rubric> RubricList
        {
            get { return rubricList; }
            set
            {
                rubricList = value;
                OnPropertyChanged(nameof(RubricList));
            }
        }

        private Rubric? selectedRubric;
        public Rubric? SelectedRubric
        {
            get { return selectedRubric; }
            set
            {
                selectedRubric = value;
                OnPropertyChanged(nameof(SelectedRubric));
            }
        }

        public RubricPageModelView(RubricPage rubricPage)
        {
            db = new KursDbContext();
            db.Database.EnsureCreated();
            db.Rubrics.Load();
            RubricList = db.Rubrics.Local.ToObservableCollection();
        }

        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        AddRubric window = new AddRubric(new Rubric());
                        if (window.ShowDialog() == true)
                        {
                            Rubric rubric = window.Rubric;
                            db.Rubrics.Add(rubric);
                            db.SaveChangesAsync();
                        }
                    }));
            }
        }

        private RelayCommand? editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                    (editCommand = new RelayCommand(obj =>
                    {
                        Rubric? rubric = obj as Rubric;
                        if (rubric == null) return;
                        AddRubric window = new AddRubric(rubric);
                        if (window.ShowDialog() == true)
                        {
                            db.Entry(rubric).CurrentValues.SetValues(window.Rubric);
                            db.SaveChangesAsync();
                        }
                    }));
            }
        }

        private RelayCommand? deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand(selectedItem =>
                  {
                      Rubric? rubric = selectedItem as Rubric;
                      if (rubric == null) return;
                      db.Rubrics.Remove(rubric);
                      db.SaveChangesAsync();
                      RubricList.Remove(rubric);
                  }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
