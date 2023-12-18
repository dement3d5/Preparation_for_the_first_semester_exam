using System;
using System.Collections.Generic;

namespace Ychy.Models
{
    public partial class Nteam
    {
        public Nteam()
        {
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
