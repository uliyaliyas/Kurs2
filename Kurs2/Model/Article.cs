using KursProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kurs2.Model;

public partial class Article : BaseClass
{
    [Key]
    public int ArticleId { get; set; }

    public int AuthorId { get; set; }

    public int RubricsId { get; set; }

    public int MagazineId { get; set; }

    public string? nameArticle;
    public string NameArticle
    {
        get { return nameArticle; }
        set
        {
            nameArticle = value;
            OnPropertyChanged(nameof(NameArticle));
        }
    }

    public string? deliveryDate;
    public string DeliveryDate
    {
        get { return deliveryDate; }
        set
        {
            deliveryDate = value;
            OnPropertyChanged(nameof(DeliveryDate));
        }
    }

    public string? adoptionArticle;
    public string AdoptionDate
    {
        get { return adoptionArticle; }
        set
        {
            adoptionArticle = value;
            OnPropertyChanged(nameof(AdoptionDate));
        }
    }

    public string? publicationDate;
    public string? PublicationDate
    {
        get { return publicationDate; }
        set
        {
            publicationDate = value;
            OnPropertyChanged(nameof(PublicationDate));
        }
    }
    public double fee;
    public double Fee
    {
        get { return fee; }
        set
        {
            fee = value;
            OnPropertyChanged(nameof(Fee));
        }
    }

    public virtual Autor Author { get; set; } = null!;

    public virtual Magazine Magazine { get; set; } = null!;

    public virtual Rubric Rubrics { get; set; } = null!;
}

