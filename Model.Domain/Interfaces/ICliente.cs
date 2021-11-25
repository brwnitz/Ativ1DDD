using Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.Interfaces
{
    public interface IClienteRepository
    {
       IEnumerable<Cliente> GetCliente();
       Cliente GetById(int id);
    }
}
