﻿using BJM.DVDCentral.BL.Models;
using BJM.ProgDec.UI.Controllers;

namespace BJM.DVDCentral.UI.ViewModels
{
    public class CustomerOrderViewModel
    {

        public Order Order { get; set; }
        public List<ShoppingCart> ShoppingCart { get; set; } = new List<ShoppingCart>();
        public List<Customer> Customer { get; set; } = new List<Customer>();
    }
}
