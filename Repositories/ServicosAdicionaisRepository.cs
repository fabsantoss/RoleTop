using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ServicosAdicionaisRepository
    {
        private const string PATH = "Database/ServicosAdiconais";

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
        List<ServicosAdicionais> ServicosAdicionais = new List<ServicosAdicionais>();

        string[] linhas = File.ReadAllLines(PATH);
        foreach (var linha in linhas)
        {
            ServicosAdicionais sa = new ServicosAdicionais();
            string[] dados = linha.Split(",");
            sa.Nome = dados[0];
            sa.Preco = double.Parse(dados[1]);
            ServicosAdicionais.Add(sa);
        }
        return ServicosAdicionais;
    }
    }
}