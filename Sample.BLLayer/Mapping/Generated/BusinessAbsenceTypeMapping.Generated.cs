using System.Text;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.Mapping
{
 
    public partial class BusinessAbsenceTypeMapping : EntityMapping<BusinessAbsenceType, BusinessAbsenceTypeDTO, long>, IBusinessAbsenceTypeMapping
    {
        public override BusinessAbsenceType MapEntity(BusinessAbsenceType  entity, 
                                       BusinessAbsenceTypeDTO entityDTO,
                                       bool isNewEntity)
        {
            BusinessAbsenceTypeMapEntity(entity, entityDTO, isNewEntity);
            MapSearchField(entityDTO);
            entity = base.MapEntity(entity, entityDTO, isNewEntity);
            return entity;
        }

        private void MapSearchField(BusinessAbsenceTypeDTO entityDTO)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(!string.IsNullOrEmpty(stringBuilder?.ToString()) && stringBuilder.Length > 0)
                entityDTO.SearchField = stringBuilder.ToString();
        }

    }

}


