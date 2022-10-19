using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace wordBombHelper
{
    public class PlayerDatabase 
    {

        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<PlayerDatabase> Instance = new AsyncLazy<PlayerDatabase>(async () =>
        {
            var instance = new PlayerDatabase();
            CreateTableResult result = await Database.CreateTableAsync<Player>();
            return instance;
        });

        public PlayerDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<Player>> GetPlayersAsync()
        {
            return Database.Table<Player>().ToListAsync();
        }

        public Task<int> SavePlayerAsync(Player player)
        {
            if(player.ID != 0)
            {
                return Database.UpdateAsync(player);
            }
            else
            {
                return Database.InsertAsync(player);
            }
        }
    



    }

}
