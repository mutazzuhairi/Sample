using System.Text;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.Mapping
{
 
    public partial class AbsenceTypeMapping : EntityMapping<AbsenceType, AbsenceTypeDTO, long>, IAbsenceTypeMapping
    {
        public override AbsenceType MapEntity(AbsenceType  entity, 
                                       AbsenceTypeDTO entityDTO,
                                       bool isNewEntity)
        {
            AbsenceTypeMapEntity(entity, entityDTO, isNewEntity);
            MapSearchField(entityDTO);
            entity = base.MapEntity(entity, entityDTO, isNewEntity);
            return entity;
        }

        private void MapSearchField(AbsenceTypeDTO entityDTO)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(entityDTO?.Name != null)
                stringBuilder.Append(entityDTO.Name.ToString() + ", ");
            if(entityDTO?.ValidAfterDays != null)
                stringBuilder.Append(entityDTO.ValidAfterDays.ToString() + ", ");
            if(!string.IsNullOrEmpty(stringBuilder?.ToString()) && stringBuilder.Length > 0)
                entityDTO.SearchField = stringBuilder.ToString();
        }

    }

}


