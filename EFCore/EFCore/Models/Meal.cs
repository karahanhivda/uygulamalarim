using System;
using System.Collections.Generic;

namespace EFCore.Models;

public partial class Meal
{
    public int Id { get; set; }

    public string MealName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<UserNutrition> UserNutritions { get; set; } = new List<UserNutrition>();
}
