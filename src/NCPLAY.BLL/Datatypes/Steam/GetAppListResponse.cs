using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.Steam
{
    public class GetAppListResponse : ApiResponse
    {
        public AppList appList { get; set; }

        public class AppList
        {
            public List<App> Apps { get; set; }
        }
    }

    public class App
    {
        public long AppId { get; set; }
        public string Name { get; set; }
    }
}