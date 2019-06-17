using Entities;
using System;
using System.Collections.Generic;
//Comentario
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
			listaOrganismos.Add(new EOrganismo()
			{
				IdOrganismo = 4,
				AbreviacionOrganismo = "PMI",
				DescripcionOrganismo = "Pemex Internacional"
			});
			listaOrganismos.Add(new EOrganismo()
			{
				IdOrganismo = 9,
				AbreviacionOrganismo = "PLOG",
				DescripcionOrganismo = "Pemex Logística"
			});
			return listaOrganismos;
		}
	}
}
