﻿using System;
using System.Collections.Generic;

namespace kaiky2.Model;

public partial class Mensagem
{
    public int Id { get; set; }

    public string Texto { get; set; } = null!;

    public DateTime Horario { get; set; }
}
