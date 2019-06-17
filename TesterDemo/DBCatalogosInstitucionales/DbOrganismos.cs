using Entities;
using System;
using System.Collections.Generic;

namespace DBCatalogosInstitucionales
{
	//Aqui hay un cambio
	public class DbOrganismos
	{
		public List<EOrganismo> GetList()
		{
			throw new Exception("Database SQL not implemented");
		}
		public List<EOrganismo> GetListHardCoded()
		{
			List<EOrganismo> listaOrganismos = new List<EOrganismo>();
			listaOrganismos.Add(new EOrganismo() {
			 IdOrganismo = 5,
			  AbreviacionOrganismo = "CORP",
			   DescripcionOrganismo= "Corporativo"
			});
			listaOrganismos.Add(new EOrganismo()
			{
				IdOrganismo = 1,
				AbreviacionOrganismo = "PEP",
				DescripcionOrganismo = "Pemex Exploracion y Produccion"
			});
			listaOrganismos.Add(new EOrganismo()
			{
				IdOrganismo = 2,
				AbreviacionOrganismo = "PTRI",
				DescripcionOrganismo = "Pemex Transformación Industrial"
			});
			return listaOrganismos;
		}
	}
}
