using System;
using System.Collections.Generic;

namespace EFCore.Models;

public partial class NutritionValue
{
    public int Id { get; set; }

    public string NutritionValueName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<Nutrition> Nutritions { get; set; } = new List<Nutrition>();
}
