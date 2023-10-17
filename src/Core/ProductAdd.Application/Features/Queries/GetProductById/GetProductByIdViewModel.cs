using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdd.Application.Features.Queries.GetProductById
{
    public class GetProductByIdViewModel
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public String Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
