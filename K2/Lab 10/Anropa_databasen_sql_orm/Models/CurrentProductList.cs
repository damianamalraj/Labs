using System;
using System.Collections.Generic;

namespace anropa_databasen_sql_orm.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
