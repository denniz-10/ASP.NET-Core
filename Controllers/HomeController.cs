using System.Collections.Generic;
using ASP_NET.Models;
using ASP_NET.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace ASP_NET.Controllers
{
    [Route("v1")]
    public class HomeController : Controller
    {
        private readonly ProductRepository _repository;
        public HomeController(ProductRepository repository)
        {
            _repository = repository;
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<Product> Get() => 
        _repository.Get();
    }
}