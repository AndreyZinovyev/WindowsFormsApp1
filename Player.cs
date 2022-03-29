using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
    }
    class SoccerContext : DbContext
    {
        public SoccerContext()
            : base("DefaultConnection")
        { }

        public DbSet<Player> Players { get; set; }
    }
}
