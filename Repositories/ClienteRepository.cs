using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] {PrepararRegistroCSV(cliente) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        private string PrepararRegistroCSV(Cliente cliente) 
        {
            return $"nome={cliente.Nome};email{cliente.Email};senha{cliente.Senha};telefone{cliente.Telefone};Data-Nascimento{cliente.DataNascimento};";
        }
    }
}