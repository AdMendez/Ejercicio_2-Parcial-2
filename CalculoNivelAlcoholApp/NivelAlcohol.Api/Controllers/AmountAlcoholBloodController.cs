using System;
using Microsoft.AspNetCore.Mvc;
using NivelAlcohol.Domain.Entities;

namespace NivelAlcohol.Api.Controllers
{
    [Route("api/[controller]")]

    public class AmountAlcoholBloodController : ControllerBase
    {
        [HttpGet]
        [Route("calcular/{amount}/{drink}/{peso}")]
        public IActionResult GetResultado(int amount, string drink, int peso)
        {
            var operation = new AmountAlcoholBlood();
            operation.TotalAlcoholConsumed(amount, drink);
            operation.AmountBlood();
            operation.MassEtanol();
            operation.VolumeBlood(peso);
            operation.AlcoholBlood();
            return Ok(operation.ReturnResult());
        }
    }
}