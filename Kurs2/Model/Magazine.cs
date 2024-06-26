using KursProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kurs2.Model;

public partial class Magazine : BaseClass
{
    [Key]
    public int MagazineId { get; set; }

    public string? number;
    public string Number
    {
        get { return number; }
        set
        {
            number = value;
            OnPropertyChanged(nameof(Number));
        }
    }

    public string? releaseDate;
    public string ReleaseDate
    {
        get { return releaseDate; }
        set
        {
            releaseDate = value;
            OnPropertyChanged(nameof(ReleaseDate));
        }
    }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
