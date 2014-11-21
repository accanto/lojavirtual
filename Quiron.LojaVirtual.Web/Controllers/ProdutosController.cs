using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        ProdutosRepositorio repositorio;

        // GET: Produtos
        public ActionResult Index()
        {
            repositorio = new ProdutosRepositorio();
            var produtos = repositorio.Produtos.Take(5);

            return View(produtos);
        }
    }
}