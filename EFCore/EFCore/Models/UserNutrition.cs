using System;
using System.Collections.Generic;

namespace EFCore.Models;

public partial class UserNutrition
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int NutritionId { get; set; }

    public int MealId { get; set; }

    public int Quantity { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual Meal Meal { get; set; } = null!;

    public virtual Nutrition Nutrition { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
