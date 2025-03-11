using System;
using System.Collections.Generic;

namespace EFCore.Models;

public partial class UsersDetail
{
    public int Id { get; set; }

    public int Gender { get; set; }

    public DateTime BirthDate { get; set; }

    public float Height { get; set; }

    public float Weight { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual User? User { get; set; }
}
