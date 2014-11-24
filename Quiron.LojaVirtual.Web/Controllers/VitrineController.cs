using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        ProdutosRepositorio repositorio;
        int produtosPorPagina = 5;

        public ActionResult ListaProdutos(int pagina = 1)
        {
            repositorio = new ProdutosRepositorio();
            var produtos = repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * produtosPorPagina)
                .Take(produtosPorPagina);

            return View(produtos);
        }
    }
}