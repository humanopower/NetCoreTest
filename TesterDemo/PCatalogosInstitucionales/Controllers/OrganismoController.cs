using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PCatalogosInstitucionales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganismoController : ControllerBase
    {
		// GET api/Organismo
		[HttpGet]
		public ActionResult<IEnumerable<EOrganismo>> Get()
		{
			var organismLogic = new LCatalogosInstitucionales.LCatalogoOrganismo();
			var listadorOrganismos = organismLogic.ObtenerListaOrganismos();
			return listadorOrganismos.ToArray();
		}

		// GET api/Organismo
		[HttpGet("{IdOrganismo}")]
		public ActionResult<EOrganismo> Get(int IdOrganismo)
		{
			var organismLogic = new LCatalogosInstitucionales.LCatalogoOrganismo();
			var organismo = organismLogic.ObtenerOrganismo(IdOrganismo);
			return organismo; 
		}

		// GET api/Search
		[HttpGet("Search/{descripcion}")]
		public ActionResult<IEnumerable<EOrganismo>> Search(string descripcion)
		{
			var organismLogic = new LCatalogosInstitucionales.LCatalogoOrganismo();
			var listadorOrganismos = organismLogic.ObtenerListaOrganismos(descripcion);
			return listadorOrganismos.ToArray();
		}

	}
}