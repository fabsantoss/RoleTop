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
                evento.Status = uint.Parse(ExtrairValorDoCampo("status", linha));
                evento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                evento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                evento.Nome = ExtrairValorDoCampo("nome", linha);
                evento.TiposDeEvento.Preco = double.Parse(ExtrairValorDoCampo("tipos_de_evento_preco", linha));
                evento.TiposDeEvento.Nome = ExtrairValorDoCampo("tipos_de_evento_nome", linha);
                evento.ServicosAdicionais.Nome =ExtrairValorDoCampo("servicos_adicionais_nome",linha);
                evento.ServicosAdicionais.Preco =double.Parse(ExtrairValorDoCampo("servicos_adicionais_preco", linha));
                evento.DataEvento = DateTime.Parse(ExtrairValorDoCampo("data_evento",linha));
                evento.DataDoEvento= DateTime.Parse(ExtrairValorDoCampo("data_do_evento",linha));
                evento.Horario= DateTime.Parse(ExtrairValorDoCampo("horario",linha));
                evento.DescricaoEvento = ExtrairValorDoCampo("descrição_evento",linha);
                evento.FormaDePagamento = ExtrairValorDoCampo("forma_de_pagamento",linha);
                
                eventos.Add(evento);
            }
            return eventos;
        }


        public Evento ObterPor(ulong id)
        {
            var eventoTotais = ObterTodos();
            foreach (var evento in eventoTotais)
            {
                if (id.Equals(evento.Id))
                {
                    return evento;
                }
            }
            return null;
        }

        public bool Atualizar(Evento evento)
        {
            var eventoTotais = File.ReadAllLines(PATH);
            var eventoCSV = PrepararEventoCSV(evento);
            var linhaEvento = -1;
            var resultado = false;

            for (int i = 0; i < eventoTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", eventoTotais[i]));
                if (evento.Id.Equals(idConvertido))
                {
                    linhaEvento = i;
                    resultado = true;
                    break;
                }
            }

            if (resultado)
            {
                eventoTotais[linhaEvento] = eventoCSV;
                File.WriteAllLines(PATH, eventoTotais);
            }
            return resultado;
        }
        private string PrepararEventoCSV (Evento evento)
        {
            Cliente c = evento.Cliente;
            ServicosAdicionais s = evento.ServicosAdicionais;
            TiposDeEvento t = evento.TiposDeEvento;



            return $"id={evento.Id};status={evento.Status};cliente_nome={c.Nome};cliente_telefone={c.Telefone};cliente_email={c.Email};nome={evento.Nome};tipos_de_evento_nome={t.Nome};tipos_de_evento_precos={t.Preco}servicos_adicionais_nome={s.Nome};servicos_adicionais_preco={s.Preco};data_evento={evento.DataEvento};data_do_evento={evento.DataDoEvento};horario={evento.Horario};descrição_evento={evento.DescricaoEvento};forma_de_pagamento={evento.FormaDePagamento};";
        }

        
    }
}