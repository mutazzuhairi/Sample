using System.Text;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.Mapping
{
 
    public partial class AbsenceApprovalMapping : EntityMapping<AbsenceApproval, AbsenceApprovalDTO, long>, IAbsenceApprovalMapping
    {
        public override AbsenceApproval MapEntity(AbsenceApproval  entity, 
                                       AbsenceApprovalDTO entityDTO,
                                       bool isNewEntity)
        {
            AbsenceApprovalMapEntity(entity, entityDTO, isNewEntity);
            MapSearchField(entityDTO);
            entity = base.MapEntity(entity, entityDTO, isNewEntity);
            return entity;
        }

        private void MapSearchField(AbsenceApprovalDTO entityDTO)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(entityDTO?.Approved != null)
                stringBuilder.Append(entityDTO.Approved.ToString() + ", ");
            if(!string.IsNullOrEmpty(stringBuilder?.ToString()) && stringBuilder.Length > 0)
                entityDTO.SearchField = stringBuilder.ToString();
        }

    }

}


