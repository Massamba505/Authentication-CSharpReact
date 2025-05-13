using System;
using System.Collections.Generic;

namespace Authentication.API.Models.Domain;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
