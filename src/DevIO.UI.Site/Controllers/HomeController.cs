using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Controllers
{
    public class HomeController: Controller
    {
        private IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;  
        }
        public IActionResult Index()
        {
            _pedidoRepository.ObterPedido();

            return View();
        }
    }
}
