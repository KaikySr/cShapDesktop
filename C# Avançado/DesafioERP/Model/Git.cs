using System;
using System.Collections.Generic;

namespace DesafioERP.Model;

public partial class Git
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public DateTime? LastUpdate { get; set; }
}
