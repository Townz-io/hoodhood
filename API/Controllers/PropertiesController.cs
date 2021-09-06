using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    public class PropertiesController : BaseApiController
    {

        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> GetProperty(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]

        public async Task<IActionResult> CreateProperty(Property property)
        {
            return Ok(await Mediator.Send(new Create.Command { Property = property }));
        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteProperty(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}