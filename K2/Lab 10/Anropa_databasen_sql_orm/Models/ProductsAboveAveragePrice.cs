using System;
using System.Collections.Generic;

namespace anropa_databasen_sql_orm.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
