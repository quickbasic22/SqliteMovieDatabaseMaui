using CommunityToolkit.Mvvm.ComponentModel;
using SqliteMovieDatabaseMaui.Data;
using SqliteMovieDatabaseMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SqliteMovieDatabaseMaui.ViewModels
{
    public partial class MovieListViewModel : ObservableObject
    {
        MovieItemDatabase MovieDatabase { get; set; }
        [ObservableProperty]
        string search;
        [ObservableProperty]
        Movie refresh;
        [ObservableProperty]
        bool isrefreshing;
        [ObservableProperty]
        string remainingitems;
        [ObservableProperty]
        Movie selectionchanged;

        public MovieListViewModel(MovieItemDatabase database)
        {
            MovieDatabase = database;
        }

        partial void OnIsrefreshingChanged(bool value)
        {
            throw new NotImplementedException();
        }

        partial void OnRemainingitemsChanged(string value)
        {
            throw new NotImplementedException();
        }

        partial void OnSearchChanged(string value)
        {
            throw new NotImplementedException();
        }

        partial void OnRefreshChanged(Movie value)
        {
            throw new NotImplementedException();
        }

        partial void OnSelectionchangedChanged(Movie value)
        {
            throw new NotImplementedException();
        }



    }
}
