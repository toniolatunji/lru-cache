namespace LruCache.Service.Contract
{
    public interface ILruCacheService
    {
        string LruCache(string[] input);
        void ReInitializeCache();
    }
}
