using System;

namespace UsandoReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente()
            {
                Id = 10,
                Nome = "Macoratti",
                Endereco = "Rua Projetada, 100"
            };

            var produto = new Produto()
            {
                Id = 1,
                Nome = "Caderno",
                Descricao = "Caderno Espiral 100 folhas",
                Estoque = 100,
                Preco = 3.99M
            };

            var pedido = new Pedido()
            {
                Id = 1,
                ClienteId = 1,
                DataPedido = DateTime.Now
            };

            Console.WriteLine("***** Logando sem usar Reflection ****");
            LogarSemReflection(cliente, produto, pedido);
            Console.WriteLine(" ---------- Logando usando Reflection ----------");
            LogarUsandoReflection(cliente, produto, pedido);
            Console.ReadKey();
        }

        public static void LogarSemReflection(Cliente cli, Produto prod, Pedido ped)
        {
            LogSemReflection.LogClientes(cli);
            LogSemReflection.LogProdutos(prod);
            LogSemReflection.LogPedidos(ped);
        }

        public static void LogarUsandoReflection(Cliente cli, Produto prod, Pedido ped)
        {
            LogComReflection.Log(cli);
            LogComReflection.Log(prod);
            LogComReflection.Log(ped);
        }

    }
}
