using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class EventoRepository : RepositoryBase
    {
        private const string PATH = "DataBase/Evento.csv";

        public EventoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir (Evento evento)
        {
            var quantidadeEventos = File.ReadAllLines(PATH).Length;
            evento.Id = (ulong) ++quantidadeEventos;
            var linha = new string[] { PrepararEventoCSV (evento)} ;
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var eventos = ObterTodos();
            List<Evento> eventosCliente = new List<Evento>();

            foreach (var evento in eventos)
            {
                if(evento.Cliente.Email.Equals(emailCliente))
                {
                    eventosCliente.Add(evento);
                }
            }
            return eventosCliente;
        }

        public List<Evento> ObterTodos ()
        {
            var linhas = File.ReadAllLines (PATH);
            List<Evento> eventos = new List<Evento>();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();

                evento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("satatus", linha));
                evento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                evento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                
                

                eventos.Add(evento);
            }
            return eventos;
        }

        private string PrepararEventoCSV (Evento evento)
        {
            Cliente c = evento.Cliente;


            return ();
        }

        
    }
}