using Model.Domain.Entities;
using Model.Domain.Interfaces;
using Model.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Infra.Data.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(MySqlContext context) : base(context)
        {
        }

        public Cliente GetById(int id)
        {
            var obj = 

            return obj;
        }

        public IEnumerable<Cliente> GetCliente()
        {
            var obj = CurrentSet
                .Include(x => x.User)
                .ToList();

            return obj;
        }
    }
}
