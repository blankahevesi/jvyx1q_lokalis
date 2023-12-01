using System;
using System.Collections.Generic;

namespace jvyx1q_lokalis.Models;

public partial class Mlanguage
{
    public int Id { get; set; }

    public int MovieId { get; set; }

    public int LanguageId { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual Film Movie { get; set; } = null!;
}
