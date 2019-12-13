using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class UsuarioController : AbstratcController
    {
        EventoRepository eventoRepository = new EventoRepository();
        ServicosAdicionaisRepository servicosAdicionaisRepository = new ServicosAdicionaisRepository();
        TiposDeEventoRepository tiposDeEventoRepository = new TiposDeEventoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Usuario() 
        {
            UsuarioViewModel uvm = new UsuarioViewModel();
            uvm.TiposDeEventos = tiposDeEventoRepository.ObterTodos();
            
            var UsuarioEmail = ObterUsuarioSession();
            if (!string.IsNullOrEmpty(UsuarioEmail))
            {
                uvm.Cliente = clienteRepository.ObterPor(UsuarioEmail);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                uvm.NomeCliente = nomeUsuario;
            }

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                uvm.NomeCliente = nomeUsuarioLogado;
            }
            
            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if (clienteLogado != null)
            {
                uvm.Cliente = clienteLogado;
                uvm.Eventos = eventoRepository.ObterTodosPorCliente(UsuarioEmail);
            }

            uvm.NomeView = "Cliente";
            uvm.UsuarioEmail = ObterUsuarioSession();
            uvm.UsuarioNome = ObterUsuarioNomeSession();

            return View (uvm);
        }
                public IActionResult Registrar(IFormCollection form)
                {
                    ViewData["Action"] = "Usuario";
                    Evento evento = new Evento();

                    var descricao = form["descricao"];

                    var horario = form["horario"];

                    var data_evento = form["data_evento"];

                    var forma_de_pagamento = form["forma_de_pagamento"];

                    var nomeServicosAdicionais = form["servicosAdiconais"];
                    ServicosAdicionais servicosAdicionais = new ServicosAdicionais(nomeServicosAdicionais, servicosAdicionaisRepository.ObterPrecoDe(nomeServicosAdicionais));

                    evento.ServicosAdicionais = servicosAdicionais;

                    var nomeTiposDeEvento = form["tiposDeEvento"];
                    TiposDeEvento tiposDeEvento = new TiposDeEvento(nomeTiposDeEvento,tiposDeEventoRepository.ObterPrecoDe(nomeTiposDeEvento));

                    

                    evento.TiposDeEvento = tiposDeEvento;

                    Cliente cliente = new Cliente(){
                        Nome = form["nome"],
                        Telefone = form["telefone"],
                        Email = form["email"]
                    };
                
                    evento.FormaDePagamento = forma_de_pagamento;

                    evento.DataDoEvento = DateTime.Parse(data_evento);

                    evento.Horario = DateTime.Parse(horario);

                    evento.DescricaoEvento = descricao;

                    evento.Cliente = cliente;

                    evento.DataEvento = DateTime.Now;

                    evento.Preco = tiposDeEvento.Preco + servicosAdicionais.Preco;

                    if (eventoRepository.Inserir(evento))
                    {
                        return View("Sucesso", new RespostaViewModel()
                        {
                            UsuarioEmail = ObterUsuarioSession(),
                            UsuarioNome = ObterUsuarioNomeSession()
                        });
                    }
                    else
                    {
                        return View("Erro");
                    }
                }
                public IActionResult Aprovar (ulong id)
                {
                    var evento = eventoRepository.ObterPor(id);
                    evento.Status = (uint) StatusEvento.APROVADO;
                    
                    if (eventoRepository.Atualizar(evento))
                    {
                        return RedirectToAction("Dashboard", "Administrador");
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Não foi possivel aprovar o cadastro desse evento")
                        {
                            NomeView = "Dashboard",
                            UsuarioEmail = ObterUsuarioSession(),
                            UsuarioNome = ObterUsuarioNomeSession()
                        });
                    }
                }

                public IActionResult Reprovar (ulong id)
                {
                    var evento = eventoRepository.ObterPor(id);
                    evento.Status = (uint) StatusEvento.REPROVADO;
                    if (eventoRepository.Atualizar(evento))
                    {
                        return RedirectToAction("Dashboard","Administrador");
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Não foi possivel reprovar este evento")
                        {
                            NomeView = "Dashboard",
                            UsuarioEmail = ObterUsuarioSession(),
                            UsuarioNome = ObterUsuarioNomeSession()
                        });
                    }
                }
        
        }
    }