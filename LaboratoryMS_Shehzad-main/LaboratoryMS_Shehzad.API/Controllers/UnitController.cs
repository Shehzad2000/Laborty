using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryMS_Shehzad.Core.Providers;
using LaboratoryMS_Shehzad.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoryMS_Shehzad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : Controller
    {
        private readonly IUnitProvider unitProvider;

        public UnitController(IUnitProvider unitProvider)
        {
            this.unitProvider = unitProvider;
        }
        [Route("AddUnit")]
        [HttpPost]
        public IActionResult AddUnit(Unit obj)
        {
            unitProvider.AddUnit(obj);
            return Ok("Data has been saved");
        }
        [Route("DeleteUnit")]
        [HttpPost]
        public IActionResult DeleteUnit(string ID)
        {
            unitProvider.DeleteUnit(ID);
            return Ok("Data has been deleted successfully");
        }
        [Route("GetUnits")]
        [HttpGet]
        public IActionResult GetUnits()
        {
            return Ok(unitProvider.GetUnits());
        }
        [Route("GetUnitByID")]
        [HttpGet]
        public IActionResult GetUnitByID(string ID)
        {
            return Ok(unitProvider.GetUnitByID(ID));
        }
        
    }
}
