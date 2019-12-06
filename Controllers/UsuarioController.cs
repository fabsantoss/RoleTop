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
            EventoViewModel evm = new EventoViewModel();
            evm.TiposDeEvento = tiposDeEventoRepository.ObterTodos();
            
            var UsuarioEmail = ObterUsuarioSession();
            if (!string.IsNullOrEmpty(UsuarioEmail))
            {
                evm.cliente = clienteRepository.ObterPor(UsuarioEmail);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                evm.NomeCliente = nomeUsuario;
            }

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                evm.NomeCliente = nomeUsuarioLogado;
            }
            
            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if (clienteLogado != null)
            {
                evm.cliente = clienteLogado;
            }

            evm.NomeView = "Cliente";
            evm.UsuarioEmail = ObterUsuarioSession();
            evm.UsuarioNome = ObterUsuarioNomeSession();

            return View (evm);
        }
                public IActionResult Registrar(IFormCollection form)
                {
                    ViewData["Action"] = "Usuario";
                    Evento evento = new Evento();

                    var nomeServicosAdicionais = form["servicos_Adiconais"];
                    ServicosAdicionais servicosAdicionais = new ServicosAdicionais();

                    evento.ServicosAdicionais = servicosAdicionais;

                    var nomeTiposDeEvento = form["Tipos_De_Evento"];
                    TiposDeEvento tiposDeEvento = new TiposDeEvento();

                    evento.TiposDeEvento = tiposDeEvento;

                    Cliente cliente = new Cliente(){
                        Nome = form["nome"],
                        Telefone = form["telefone"],
                        Email = form["email"]
                    };

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
                        return View("Erro", new RespostaViewModel("Não foi possivel aprovar o cadastro desse evento"));
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