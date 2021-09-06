using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    public class HouseholdsController : BaseApiController
    {


        [HttpGet]
        public async Task<ActionResult<List<Household>>> GetHouseholds(Neighborhood neighborhood)
        {
            return await Mediator.Send(new List.Query { NeedsMember = true, Neighborhood = neighborhood });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetHousehold(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]

        public async Task<IActionResult> CreateHousehold(Household household)
        {
            return Ok(await Mediator.Send(new Create.Command { Household = household }));
        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteHousehold(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}