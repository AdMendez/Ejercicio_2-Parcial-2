using System;
using Microsoft.AspNetCore.Mvc;
using Resistencia.Domain.Entities;

namespace Resistencia.Api.Controllers
{
    [Route("api/[controller]")]
    
    public class ResistanceController : ControllerBase
    {
        [HttpGet]
        [Route("calcular/{firstband}/{secondband}/{thirdband}/{tolerance}")]
        public IActionResult GetResistance(string firstband, string secondband, string thirdband, string tolerance)
        {
            var operation = new Resistance();
            operation.FirstBand(firstband);
            operation.SecondBand(secondband);
            operation.Multiply(thirdband);
            operation.Tolerance(tolerance);
            return Ok(operation.ReturnValue());
            
        }
    } 
}