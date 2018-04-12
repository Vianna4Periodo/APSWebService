using ClienteAeroporto.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteAeroporto.Controllers
{
    public class HomeController : Controller
    {
        private WebService1 server;

        public HomeController()
        {
            server = new WebService1();
        }
        // GET: Home
        public ActionResult Index()
        {
            var passagens = server.ConsultarBilhetes();
            var voos = server.ConsultarVoos();
            foreach (Voo voo  in voos)
            {
                foreach (Passagem passagem in passagens)
                {
                    if (passagem.Voo.Id == voo.Id)
                        voo.QtdAssentos = voo.QtdAssentos - 1;
                }

            }

            return View(voos);
        }

        public ActionResult AddVoo()
        {
            return View();
        }

        public ActionResult CriarVoo(Voo item)
        {
            server.CadastroVoo(item);
            return RedirectToAction("Index");
        }

        public ActionResult ComprarPassagem(Guid id)
        {
            ViewBag.idvoo = id;
            return View();
        }

        public ActionResult CompraPassagem(Guid idvoo, int quantidade)
        {
            try
            {
                server.ComprarBilhete(idvoo, quantidade);
            }
            catch(Exception ex)
            {
                ViewBag.ex = ex;
            }

            
            return RedirectToAction("Index");
        }

        public ActionResult ListarPassagens()
        {
            var passagens = server.ConsultarBilhetes();
            return View(passagens);
        }

        public ActionResult DevolverPassagem(Guid id)
        {
            server.DevolverBilhete(id);
            return RedirectToAction("ListarPassagens");
        }
    }
}