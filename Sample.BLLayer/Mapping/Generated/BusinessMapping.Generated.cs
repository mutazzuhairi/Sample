using System.Text;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.Mapping
{
 
    public partial class BusinessMapping : EntityMapping<Business, BusinessDTO, long>, IBusinessMapping
    {
        public override Business MapEntity(Business  entity, 
                                       BusinessDTO entityDTO,
                                       bool isNewEntity)
        {
            BusinessMapEntity(entity, entityDTO, isNewEntity);
            MapSearchField(entityDTO);
            entity = base.MapEntity(entity, entityDTO, isNewEntity);
            return entity;
        }

        private void MapSearchField(BusinessDTO entityDTO)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(entityDTO?.Name != null)
                stringBuilder.Append(entityDTO.Name.ToString() + ", ");
            if(!string.IsNullOrEmpty(stringBuilder?.ToString()) && stringBuilder.Length > 0)
                entityDTO.SearchField = stringBuilder.ToString();
        }

    }

}


