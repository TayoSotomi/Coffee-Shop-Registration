using System;
using System.Collections.Generic;

namespace Coffee_Shop_Registration.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public float? Price { get; set; }

    public string? Category { get; set; }
}
