using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDev.Models.Clientes;

namespace TestDev.Data
{
    public static class FakeDB
    {
        private static List<Cliente> _clientes;
        public static ICollection<Cliente> Clientes
        {
            get
            {
                if (_clientes == null) _clientes = new List<Cliente>();
                return _clientes;
            }
        }
    }
}
