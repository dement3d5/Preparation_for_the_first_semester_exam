using System;
using System.Collections.Generic;

namespace Ychy.Models
{
    public partial class Auth
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
    }
}
