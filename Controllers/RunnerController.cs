using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using trails.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace trails.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        // GET: api/runner
        [HttpGet]
        public Runner[] Get()
        {
            var runners = new List<Runner>();

            runners.Add(new Runner(){Id = 1, First = "Shayne", Last="Boyer", Age = 42, FavoriteBeer= "Guiness" });
            runners.Add(new Runner(){Id = 2, First = "Jennifer", Last="Lockrem", Age = 33, FavoriteBeer= "Monkey Beer" });
            runners.Add(new Runner(){Id = 3, First = "Kirsty", Last="Boyer", Age = 35, FavoriteBeer= "Monkey Beer" });
            return runners.ToArray();
        }

        // GET api/runner/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return Get().Where(r => r.Id == id).FirstOrDefault();
        }


    }
}
