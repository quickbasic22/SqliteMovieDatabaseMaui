using SQLite;
using SqliteMovieDatabaseMaui;
using SqliteMovieDatabaseMaui.Models;

namespace SqliteMovieDatabaseMaui.Data;

public class MovieItemDatabase
{
    SQLiteAsyncConnection Database;
    public MovieItemDatabase()
    {
    }
    async Task Init()
    {
        if (Database is not null)
            return;

        Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        var result = await Database.CreateTableAsync<Movie>();
    }

    public async Task<List<Movie>> GetItemsAsync()
    {
        await Init();
        return await Database.Table<Movie>().ToListAsync();
    }

    public async Task<List<Movie>> GetItemsNotDoneAsync()
    {
        await Init();
        return await Database.Table<Movie>().Where(t => t.Done).ToListAsync();

        // SQL queries are also possible
        //return await Database.QueryAsync<Movie>("SELECT * FROM [Movie] WHERE [Done] = 0");
    }

    public async Task<Movie> GetItemAsync(int id)
    {
        await Init();
        return await Database.Table<Movie>().Where(i => i.MovieId == id).FirstOrDefaultAsync();
    }

    public async Task<int> SaveItemAsync(Movie item)
    {
        await Init();
        if (item.MovieId != 0)
        {
            return await Database.UpdateAsync(item);
        }
        else
        {
            return await Database.InsertAsync(item);
        }
    }

    public async Task<int> DeleteItemAsync(Movie item)
    {
        await Init();
        return await Database.DeleteAsync(item);
    }
}