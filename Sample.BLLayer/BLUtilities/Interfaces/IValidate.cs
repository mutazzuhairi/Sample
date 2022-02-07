using System.Collections.Generic;

namespace Sample.BLLayer.BLUtilities.Interfaces
{
    public interface IValidate<TEntityPM>
    {
         void Validate(TEntityPM entityDTO, bool isNewEntity);
    }
}
