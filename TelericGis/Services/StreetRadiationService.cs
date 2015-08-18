using System.Collections.Generic;
using System.Linq;
using TelericGis.Models;

namespace TelericGis.Services
{
    public class StreetRadiationService
    {
        private GIS_DBEntities entities;

        public StreetRadiationService(GIS_DBEntities entitie)
        {
            entities = entitie;
        }

        public IEnumerable<StreetRadiation> Read()
        {
            var res = entities.StreetRadiations.Local;

            return res;
        }
    }
}