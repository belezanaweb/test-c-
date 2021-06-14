﻿using TesteBoticario.Domain.Entities;
using MediatR;

namespace TesteBoticario.Core.Responses
{
    public class GetProductResponse : IRequest
    {
        public int Sku { get; set; }
        public string Name { get; set; }
        public Inventory Inventory { get; set; }
        public bool IsMarketable { get; set; }
    }
}
