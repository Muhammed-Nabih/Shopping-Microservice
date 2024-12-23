using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.ValueObjects
{
    public record OrderName
    {
        public string Value { get; }
        private OrderName(string value) => Value = value;
        public static OrderName Of(string value)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value);

            return new OrderName(value);
        }
    }
}
