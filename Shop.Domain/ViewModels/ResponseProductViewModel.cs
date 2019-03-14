﻿namespace Shop.Domain.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ResponseProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
