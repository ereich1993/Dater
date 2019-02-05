using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dater.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dater.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DatingContext _ctx;

        public ValuesController(DatingContext ctx)
        {
            _ctx = ctx;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var content = await _ctx.entities.ToListAsync();
            return Ok(content);
        }

        // GET api/values/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var ent = await _ctx.entities.ToListAsync();

            return Ok();
        }

        [AllowAnonymous]
        [HttpGet("seed")]
        public async Task<IActionResult> SeedDb()
        {
            var itemsRange = new MenuItems[]
            {
                new MenuItems
                {
                    Category ="Starter",
                    Descrition="Saláta csirkemellel, uborkával, pirított kenyérkockával",
                    Name="Cézár saláta",
                    Price = 700,
                    Spicy = 0,
                    Vegetarian =0
                },
                new MenuItems
                {
                    Category ="Drink",
                    Descrition=null,
                    Name="Coca cola",
                    Price = 300,
                    Spicy = null,
                    Vegetarian =null
                }
            };

            _ctx.menuItems.AddRange(itemsRange);
            await _ctx.SaveChangesAsync();
            return Ok(await _ctx.menuItems.ToListAsync());
        }

        [HttpGet("seedUsers")]
        [AllowAnonymous]
        public async Task<IActionResult> Shop()
        {
            var users = new MenuUser[]
            {
                new MenuUser
                {
                    Name = "robi",
                   
                    
                },
                new MenuUser
                {
                    Name = "feri",
                    

                }
            };
            _ctx.menuUsers.AddRange(users);
            await _ctx.SaveChangesAsync();
            return Ok(await _ctx.menuUsers.ToListAsync());
        }

        [HttpGet("seedItemUsers")]
        [AllowAnonymous]
        public async Task<IActionResult> seedItemUsers()
        {
            MenuUser emil = _ctx.menuUsers.Where(x => x.Name == "robi").First();
            MenuItems chicken = _ctx.menuItems.Where(y => y.Id == 2).First();
            MenuItems coke = _ctx.menuItems.Where(y => y.Id == 1).First();
            emil.menuItems.Add(chicken);
            emil.menuItems.Add(chicken);
            emil.menuItems.Add(coke);
           
            await _ctx.SaveChangesAsync();
            return Ok(await _ctx.menuUsers.ToListAsync());
        }






        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
