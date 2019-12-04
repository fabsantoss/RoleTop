using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index() 
        {
            EventoViewModel evm = new EventoViewModel();
            evm.TiposDeEvento = tiposDeEventoRepository.ObterTodos();
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

            evm.NomeView = "Evento";
            evm.UsuarioEmail = usuarioLogado;
            evm.UsuarioNome = nomeUsuarioLogado;

            return View (evm);
        }
        }
    }