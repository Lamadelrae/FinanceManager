﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManager.Models.ViewModels
{
    public class BillsViewModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Description { get; set; }

        public string Value { get; set; }
    }

    public class BillFormViewModel
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public string Value { get; set; }
    }
}
