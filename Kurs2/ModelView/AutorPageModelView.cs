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
    internal class AutorPageModelView : BaseClass
    {
        private KursDbContext db;
        private ObservableCollection<Autor> autorList;

        public ObservableCollection<Autor> AutorList
        {
            get { return autorList; }
            set
            {
                autorList = value;
                OnPropertyChanged(nameof(AutorList));
            }
        }

        private Autor? selectedAutor;
        public Autor? SelectedAutor
        {
            get { return selectedAutor; }
            set
            {
                selectedAutor = value;
                OnPropertyChanged(nameof(SelectedAutor));
            }
        }

        public AutorPageModelView(AutorPage autorPage)
        {
            db = new KursDbContext();
            db.Database.EnsureCreated();
            db.Autors.Load();
            AutorList = db.Autors.Local.ToObservableCollection();
        }

        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        AddAutor window = new AddAutor(new Autor());
                        if (window.ShowDialog() == true)
                        {
                            Autor autor = window.Autor;
                            db.Autors.Add(autor);
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
                    Autor? autor = obj as Autor;
                    if (autor == null) return;
                    AddAutor window = new AddAutor(autor);
                    if (window.ShowDialog() == true)
                    {
                        db.Entry(autor).CurrentValues.SetValues(window.Autor);
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
                      Autor? autor = selectedItem as Autor;
                      if (autor == null) return;
                      db.Autors.Remove(autor);
                      db.SaveChangesAsync();
                      AutorList.Remove(autor);
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