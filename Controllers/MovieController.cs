using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MiniCinema.Models;

namespace MiniCinema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return new Movie[] {
                new Movie() { Id = 1, Title = "TestTitle", Description = "TestDescription" },
                new Movie() { Id = 2, Title = "TestTitle2", Description = "TestDescription3" }
            };
        }
    }
}
