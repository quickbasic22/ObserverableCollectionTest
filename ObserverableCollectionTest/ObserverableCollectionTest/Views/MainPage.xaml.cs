using ObserverableCollectionTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ObserverableCollectionTest.Views
{
    public partial class MainPage : ContentPage
    {
        public Movie Movie { get; set; }
        public ObservableCollection<Movie> Items { get; set; }
        public MainPage()
        {
            InitializeComponent();
            LoadItems();
            BindingContext = this;
        }

        private void LoadItems()
        {
            Items = new ObservableCollection<Movie>()
            {
                new Movie { Id = 1, Title = "Next", Rating = "Five Stars", Released = new DateTime(2007, 3, 25) },
                new Movie { Id = 1, Title = "Near Dark", Rating = "Four Stars", Released = new DateTime(2017, 8, 14) },
                new Movie { Id = 1, Title = "Star Trek", Rating = "Three and Half Stars", Released = new DateTime(2013, 12, 29) },
                new Movie { Id = 1, Title = "Fast and Furious", Rating = "Four and Half Stars", Released = new DateTime(2014, 5, 7) }
            };
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(searchBar.Text))
            {
                var searchtext = Items.Where(title => title.Title.ToLowerInvariant().Contains(searchBar.Text.ToLowerInvariant()));
                collectionView.ItemsSource = searchtext;
            }

            
        }

        private void SearchBarRelease_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchBarRelease.Text))
            {
                var searchtext2 = Items.Where(year => year.Released.Year.Equals(int.Parse(SearchBarRelease.Text)));
                collectionView.ItemsSource = searchtext2;
            }

        }
    }
}