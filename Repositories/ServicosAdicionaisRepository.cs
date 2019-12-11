using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ServicosAdicionaisRepository
    {
        private const string PATH = "Database/ServicosAdicionais.csv";

        public double ObterPrecoDe(string nomeServicosAdiconais)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeServicosAdiconais))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<ServicosAdicionais> ObterTodos()
        {
            List<ServicosAdicionais> servicosAdicionais =  new List<ServicosAdicionais>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                ServicosAdicionais  sa = new ServicosAdicionais();
                string[] dados = item.Split(";");
                sa.Nome = dados[0];
                sa.Preco = double.Parse(dados[1]);
                servicosAdicionais.Add(sa);
            }
            return servicosAdicionais;
        }
    }
}