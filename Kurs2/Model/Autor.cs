using KursProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kurs2.Model;

public partial class Autor : BaseClass
{
    [Key]
    public int AuthorId { get; set; }

    private string? fio;
    public string Fio
    {
        get { return fio; }
        set
        {
            fio = value;
            OnPropertyChanged(nameof(Fio));
        }
    }

    private string? phone;
    public string Phone
    {
        get { return phone; }
        set
        {
            phone = value;
            OnPropertyChanged(nameof(Phone));
        }
    }
    private string? email;
    public string Email
    {
        get { return email; }
        set
        {
            email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    private string? birthDay;
    public string BirthDay
    {
        get { return birthDay; }
        set
        {
            birthDay = value;
            OnPropertyChanged(nameof(BirthDay));
        }
    }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
