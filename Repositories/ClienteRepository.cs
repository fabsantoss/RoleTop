using System;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
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

        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("nome", item);
                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    c.Email = ExtrairValorDoCampo("email", item);
                    c.ConfirmaSenha = ExtrairValorDoCampo("confirma_senha", item);
                    c.DataNascimento = DateTime.Parse (ExtrairValorDoCampo("data_nascimento", item));
                    c.Telefone = ExtrairValorDoCampo("telefone", item);
                    c.Senha = ExtrairValorDoCampo("senha", item);

                    return c;
                }
            }
            return null;
        }

        private string PrepararRegistroCSV(Cliente cliente) 
        {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};confirma_senha={cliente.ConfirmaSenha};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento};";
        }
    }
}