using System;
using System.Collections.Generic;

namespace EFCore.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int UserType { get; set; }

    public string SecurityQuestion { get; set; } = null!;

    public string Answer { get; set; } = null!;

    public byte[]? Picture { get; set; }

    public int UserDetailId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual UsersDetail UserDetail { get; set; } = null!;

    public virtual ICollection<UserNutrition> UserNutritions { get; set; } = new List<UserNutrition>();
}
