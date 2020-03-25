using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD2._0ffline.Data
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public BaseEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedAt = DateTime.Now;
        }
    }
}
