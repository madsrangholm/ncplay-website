using System;
using System.Collections.Concurrent;
using NCPLAY.BLL.Interfaces;

namespace NCPLAY.BLL.Helpers
{
    public class ObjectCache : IObjectCache
    {
	    private readonly ConcurrentDictionary<string, CacheObject> _cache;

	    public ObjectCache()
	    {
		    _cache = new ConcurrentDictionary<string, CacheObject>();
	    }
	    public bool Get<T>(string key, out T obj)
			where T : class
	    {
		    CacheObject cObj;
		    if (_cache.TryGetValue(key, out cObj))
		    {
			    if (cObj.AbsoluteExpiration < DateTime.Now)
			    {
					Remove(key);
				}
				else
			    {
				    var o = cObj.Object as T;
				    if(o != null)
				    {
					    obj = o;
					    return true;
				    }
			    }
		    }			
			obj = default(T);
			return false;
		}
	    public void Set(string key, object value, TimeSpan validDuration)
	    {
		    var obj = new CacheObject()
		    {
			    AbsoluteExpiration = DateTime.Now.Add(validDuration),
			    Object = value
		    };
		    _cache.AddOrUpdate(key, obj, (k, v) => obj);
	    }

	    public void Remove(string key)
	    {
		    CacheObject obj;
		    _cache.TryRemove(key, out obj);
	    }




	    public class CacheObject
		{
			public object Object { get; set; }
			public DateTime AbsoluteExpiration { get; set; }
		}
	}
}