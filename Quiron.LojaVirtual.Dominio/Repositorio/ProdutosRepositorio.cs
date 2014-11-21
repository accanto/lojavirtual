using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {

        readonly EfDbContext context = new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return context.Produtos;  }
        }

    }
}
