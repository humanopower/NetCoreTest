using Entities;
using System;
using System.Collections.Generic;
//Comentarioa
namespace LCatalogosInstitucionales
{
	public class LCatalogoOrganismo
	{
		public List<EOrganismo> ObtenerListaOrganismos()
		{
			var dbCatalogoOrganismo = new DBCatalogosInstitucionales.DbOrganismos();
			var listOrganismos = dbCatalogoOrganismo.GetListHardCoded();
			return listOrganismos;
		}

		public List<EOrganismo> ObtenerListaOrganismos(string descripcion)
		{
			var dbCatalogoOrganismo = new DBCatalogosInstitucionales.DbOrganismos();
			var listOrganismos = dbCatalogoOrganismo.GetListHardCoded().FindAll(e => e.DescripcionOrganismo.Contains(descripcion));
			return listOrganismos;
		}
		
		public EOrganismo ObtenerOrganismo(int idOrganismo)
		{
			var dbCatalogoOrganismo = new DBCatalogosInstitucionales.DbOrganismos();
			var listOrganismos = dbCatalogoOrganismo.GetListHardCoded().Find(e => e.IdOrganismo == idOrganismo);
			return listOrganismos;
		}
	}
}
