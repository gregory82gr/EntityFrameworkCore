using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain;

public class Coach : BaseDomainModel
{
    //[MaxLength(100)]
    //[Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    public Team? Team { get; set; }

}

