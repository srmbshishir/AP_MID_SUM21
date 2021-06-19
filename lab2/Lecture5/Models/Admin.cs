using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture5.Models
{
            public int Id { get; set; }
            public string Name { get; set; }
            [Required]
            public string Username { get; set; }
            [Required]
            public string Password { get; set; }
        }
    }
}
}