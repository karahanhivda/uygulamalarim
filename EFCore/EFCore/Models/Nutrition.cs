using System;
using System.Collections.Generic;

namespace EFCore.Models;

public partial class Nutrition
{
    public int Id { get; set; }

    public string NutritionName { get; set; } = null!;

    public float Calories { get; set; }

    public byte[]? Image { get; set; }

    public int CategoryId { get; set; }

    public int NutritionValueId { get; set; }

    public int Portion { get; set; }

    public float PortionSize { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual NutritionValue NutritionValue { get; set; } = null!;

    public virtual ICollection<UserNutrition> UserNutritions { get; set; } = new List<UserNutrition>();
}
