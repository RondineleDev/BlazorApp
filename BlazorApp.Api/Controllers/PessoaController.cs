﻿using BlazorApp.Api.Data;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly AppDataContext _db;

        public PessoaController(AppDataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Pessoa>>> Get()
        {
            /// return await _db.Pessoas.ToListAsync();
            /// 
            return await _db.Pessoas.AsNoTracking().ToListAsync();
        }

        
    }
}