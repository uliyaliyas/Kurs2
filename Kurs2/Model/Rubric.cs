using KursProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kurs2.Model;

public partial class Rubric : BaseClass
{
    [Key]
    public int RubricsId { get; set; }

    public string? nameRubric;
    public string? NameRubric
    {
        get { return nameRubric; }
        set
        {
            nameRubric = value;
            OnPropertyChanged(nameof(NameRubric));
        }
    }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
