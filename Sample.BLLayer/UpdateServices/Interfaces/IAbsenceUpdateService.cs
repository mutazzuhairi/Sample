using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.BLUtilities.Interfaces;
using Sample.BLLayer.Extends.ExtendModels;
using System.Threading.Tasks;

namespace Sample.BLLayer.UpdateServices.Interfaces
{
 
    public interface IAbsenceUpdateService : IUpdateService<AbsenceDTO>
    {
        public Task<AbsenceDTO> CreateCustomAsync(AbsenceDemoDTO entityDTO);
    }

}
