﻿using System;
using System.Threading.Tasks;
using GeekStore.Catalogo.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace GeekStore.WebApp.MVC.Controllers
{
    public class VitrineController : Controller
    {
        private readonly IProdutoService _produtoAppService;

        public VitrineController(IProdutoService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpGet]
        [Route("")]
        [Route("vitrine")]
        public async Task<IActionResult> Index()
        {
            return View(await _produtoAppService.ObterTodos());
        }

        [HttpGet]
        [Route("produto-detalhe/{id}")]
        public async Task<IActionResult> ProdutoDetalhe(Guid id)
        {
            return View(await _produtoAppService.ObterPorId(id));
        }
    }
}