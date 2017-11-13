using LojaRazor.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaRazor.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            DepartamentosDAO departamentosDAO = new DepartamentosDAO();
            ProdutosDAO produtosDAO = new ProdutosDAO();
            ViewBag.Departamentos = departamentosDAO.Lista();
            ViewBag.Produtos = produtosDAO.Ofertas();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }
    }
}
