using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.Entities
{
    public class Produtos : BaseEntity
    {
        public string Produto { get; set; }
        public decimal Valor { get; set; }
    }
}
