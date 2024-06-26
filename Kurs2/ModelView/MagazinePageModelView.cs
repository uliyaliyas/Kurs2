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
    class MagazinePageModelView
    {
        private KursDbContext db;
        private ObservableCollection<Magazine> magazineList;

        public ObservableCollection<Magazine> MagazineList
        {
            get { return magazineList; }
            set
            {
                magazineList = value;
                OnPropertyChanged(nameof(MagazineList));
            }
        }

        private Magazine? selectedMagazine;
        public Magazine? SelectedMagazine
        {
            get { return selectedMagazine; }
            set
            {
                selectedMagazine = value;
                OnPropertyChanged(nameof(SelectedMagazine));
            }
        }

        public MagazinePageModelView(MagazinePage magazinePage)
        {
            db = new KursDbContext();
            db.Database.EnsureCreated();
            db.Magazines.Load();
            MagazineList = db.Magazines.Local.ToObservableCollection();
        }

        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        AddMagazine window = new AddMagazine(new Magazine());
                        if (window.ShowDialog() == true)
                        {
                            Magazine magazine = window.Magazine;
                            db.Magazines.Add(magazine);
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
                        Magazine? magazine = obj as Magazine;
                        if (magazine == null) return;
                        AddMagazine window = new AddMagazine(magazine);
                        if (window.ShowDialog() == true)
                        {
                            db.Entry(magazine).CurrentValues.SetValues(window.Magazine);
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
                      // получаем выделенный объект
                      Magazine? magazine = selectedItem as Magazine;
                      if (magazine == null) return;
                      db.Magazines.Remove(magazine);
                      db.SaveChangesAsync();
                      MagazineList.Remove(magazine);
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