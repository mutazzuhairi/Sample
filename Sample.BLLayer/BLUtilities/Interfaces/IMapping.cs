 
namespace Sample.BLLayer.BLUtilities.Interfaces
{
    public interface IMapping<TEntity,TEntityDTO>
    {
        TEntity MapEntity(TEntity entity , TEntityDTO entityPm, bool isNewEntity);
    }
}
