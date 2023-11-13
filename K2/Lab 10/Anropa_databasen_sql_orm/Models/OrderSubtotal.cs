using System;
using System.Collections.Generic;

namespace anropa_databasen_sql_orm.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
