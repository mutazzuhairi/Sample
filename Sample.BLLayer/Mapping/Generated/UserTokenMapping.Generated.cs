using System.Text;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.Mapping
{
 
    public partial class UserTokenMapping : EntityMapping<UserToken, UserTokenDTO, long>, IUserTokenMapping
    {
        public override UserToken MapEntity(UserToken  entity, 
                                       UserTokenDTO entityDTO,
                                       bool isNewEntity)
        {
            UserTokenMapEntity(entity, entityDTO, isNewEntity);
            MapSearchField(entityDTO);
            entity = base.MapEntity(entity, entityDTO, isNewEntity);
            return entity;
        }

        private void MapSearchField(UserTokenDTO entityDTO)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(!string.IsNullOrEmpty(stringBuilder?.ToString()) && stringBuilder.Length > 0)
                entityDTO.SearchField = stringBuilder.ToString();
        }

    }

}


