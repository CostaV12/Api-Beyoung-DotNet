using Beyoung_Teste.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beyoung_Teste.Data
{
    public class PedidoContext : DbContext
    {
        public PedidoContext(DbContextOptions<PedidoContext> opt) : base (opt)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
