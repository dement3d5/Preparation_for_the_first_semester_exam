using System;
using System.Collections.Generic;

namespace Ychy.Models
{
    public partial class Team
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Sname { get; set; }
        public string? LastName { get; set; }
        public int? NteamId { get; set; }

        public virtual Nteam? Nteam { get; set; }
    }
}
