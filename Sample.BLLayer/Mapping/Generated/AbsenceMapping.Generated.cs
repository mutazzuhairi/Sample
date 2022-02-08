using System.Text;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.Mapping
{
 
    public partial class AbsenceMapping : EntityMapping<Absence, AbsenceDTO, long>, IAbsenceMapping
    {
        public override Absence MapEntity(Absence  entity, 
                                       AbsenceDTO entityDTO,
                                       bool isNewEntity)
        {
            AbsenceMapEntity(entity, entityDTO, isNewEntity);
            MapSearchField(entityDTO);
            entity = base.MapEntity(entity, entityDTO, isNewEntity);
            return entity;
        }

        private void MapSearchField(AbsenceDTO entityDTO)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(entityDTO?.BusinessAbsenceTypeId != null)
                stringBuilder.Append(entityDTO.BusinessAbsenceTypeId.ToString() + ", ");
            if(entityDTO?.FromDate != null)
                stringBuilder.Append(entityDTO.FromDate.ToString() + ", ");
            if(entityDTO?.ToDate != null)
                stringBuilder.Append(entityDTO.ToDate.ToString() + ", ");
            if(entityDTO?.Status != null)
                stringBuilder.Append(entityDTO.Status.ToString() + ", ");
            if(!string.IsNullOrEmpty(stringBuilder?.ToString()) && stringBuilder.Length > 0)
                entityDTO.SearchField = stringBuilder.ToString();
        }

    }

}


