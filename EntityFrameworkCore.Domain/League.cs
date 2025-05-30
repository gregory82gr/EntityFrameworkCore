using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class League: BaseDomainModel
    {
        public string? Name { get; set; }

        //Navigation properties
        //League has many teams.Team belongs to one league 1:many
        public List<Team>? Teams { get; set; }
    }
    
}
