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
    class ArticlePageModelView
    {
        private KursDbContext db;
        private ObservableCollection<Article> articleList;

        public ObservableCollection<Article> ArticleList
        {
            get { return articleList; }
            set
            {
                articleList = value;
                OnPropertyChanged(nameof(ArticleList));
            }
        }

        private Article? selectedArticle;
        public Article? SelectedArticle
        {
            get { return selectedArticle; }
            set
            {
                selectedArticle = value;
                OnPropertyChanged(nameof(SelectedArticle));
            }
        }

        public ArticlePageModelView(ArticlePage articlePage)
        {
            db = new KursDbContext();
            db.Database.EnsureCreated();
            db.Articles.Load();
            ArticleList = db.Articles.Local.ToObservableCollection();
        }

        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        AddArticle window = new AddArticle(new Article());
                        if (window.ShowDialog() == true)
                        {
                            Article article = window.Article;
                            db.Articles.Add(article);
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
                        Article? article = obj as Article;
                        if (article == null) return;
                        AddArticle window = new AddArticle(article);
                        if (window.ShowDialog() == true)
                        {
                            db.Entry(article).CurrentValues.SetValues(window.Article);
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
                      Article? article = selectedItem as Article;
                      if (article == null) return;
                      db.Articles.Remove(article);
                      db.SaveChangesAsync();
                      ArticleList.Remove(article);
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
