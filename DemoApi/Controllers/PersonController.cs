using System.Collections.Generic;
using System.Threading.Tasks;
using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            List<PersonModel> result = await _mediator.Send(new GetPersonListQuery());

            return result;
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id)
        {
            PersonModel result = await _mediator.Send(new GetPersonByIdQuery(id));

            return result;
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonModel> Post(PersonModel personModel)
        {
            PersonModel result = await _mediator.Send(new InsertPersonCommand(personModel.FirstName, personModel.LastName));

            return result;
        }
    }
}
