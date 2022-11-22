using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureFilmYonetimi.Application.Interfaces.Repositories;
using OnionArchitectureFilmYonetimi.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitectureFilmYonetimi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmRepository filmRepository;

        public FilmController(IFilmRepository filmRepository)
        {
            this.filmRepository = filmRepository;
        }

       
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allLİstFilm =await filmRepository.GetAllAsync();

            /*
                var result = allLİstFilm.Select(i => new FilmViewDto()
                {
                    Id = i.Id,
                    Name = i.Name
                }).ToList();
                return Ok(result);
            */
            

            return Ok(new ServiceResponse<>(allLİstFilm));

        }
    }
}
