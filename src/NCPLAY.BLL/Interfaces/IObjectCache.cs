using System;

namespace NCPLAY.BLL.Interfaces
{

    public interface IObjectCache
    {
	    bool Get<T>(string key, out T obj) where T : class;
        void Set(string key, object value, TimeSpan validDuration);
	    void Remove(string key);
    }
}