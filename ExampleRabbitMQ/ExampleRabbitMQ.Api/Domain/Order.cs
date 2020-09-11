using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleRabbitMQ.Api.Domain
{
    public sealed class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public float Price { get; set; }
    }
}
