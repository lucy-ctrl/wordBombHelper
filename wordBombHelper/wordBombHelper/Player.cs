using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace wordBombHelper
{
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string PlayerName { get; set; }
        public string Colour { get; set; }
    }
}
