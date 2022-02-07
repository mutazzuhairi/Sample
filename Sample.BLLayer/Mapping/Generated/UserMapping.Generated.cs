using System.Text;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.Mapping
{
 
    public partial class UserMapping : EntityMapping<User, UserDTO, long>, IUserMapping
    {
        public override User MapEntity(User  entity, 
                                       UserDTO entityDTO,
                                       bool isNewEntity)
        {
            UserMapEntity(entity, entityDTO, isNewEntity);
            MapSearchField(entityDTO);
            entity = base.MapEntity(entity, entityDTO, isNewEntity);
            return entity;
        }

        private void MapSearchField(UserDTO entityDTO)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(entityDTO?.FirstName != null)
                stringBuilder.Append(entityDTO.FirstName.ToString() + ", ");
            if(entityDTO?.LastName != null)
                stringBuilder.Append(entityDTO.LastName.ToString() + ", ");
            if(!string.IsNullOrEmpty(stringBuilder?.ToString()) && stringBuilder.Length > 0)
                entityDTO.SearchField = stringBuilder.ToString();
        }

    }

}


