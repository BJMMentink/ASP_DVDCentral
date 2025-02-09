﻿using System;
using System.Collections.Generic;

namespace BJM.DVDCentral.PL;

public partial class tblOrderItem
{
    public int Id { get; set; }

    public int OrderId { get; set; } = 0;

    public int MovieId { get; set; }

    public int Quantity { get; set; }

    public double Cost { get; set; }
}
