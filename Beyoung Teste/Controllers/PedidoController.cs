using Beyoung_Teste.Data;
using Beyoung_Teste.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beyoung_Teste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : Controller
    {
        private PedidoContext _context;

        public PedidoController(PedidoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarPedido([FromBody] Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return Ok(pedido);
        }
    }
}
