using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class TiposDeEventoRepository
    {
        private const string PATH = "Database/TiposDeEvento.csv";

        public double ObterPrecoDe(string nomeTiposDeEvento)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeTiposDeEvento))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

    public List<TiposDeEvento>  ObterTodos()
    {
        List<TiposDeEvento> tiposDeEvento = new List<TiposDeEvento>();

        string[] linhas = File.ReadAllLines(PATH);
        foreach (var linha in linhas)
        {
            TiposDeEvento tde = new TiposDeEvento();
            string[] dados = linha.Split(";");
            tde.Nome = dados[0];
            tde.Preco = double.Parse(dados[1]);
            tiposDeEvento.Add(tde);
        }
        return tiposDeEvento;
    }
    }
}