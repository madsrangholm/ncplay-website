using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.Steam
{
    public class SupportedApiListResponse : ApiResponse
    {
        public SupportedApiList ApiList { get; set; }

        public class SupportedApiList
        {
            public List<SupportedApiListInterface> Interfaces { get; set; }
        }

        public class SupportedApiListInterface
        {
            public string Name { get; set; }
            public List<SupportedApiListInterfaceMethod> Methods { get; set; }
        }

        public class SupportedApiListInterfaceMethod
        {
            public string Name { get; set; }
            public int Version { get; set; }
            public string HttpMethod { get; set; }
            public List<SupportedApiListInterfaceParameters> Parameters { get; set; }
        }

        public class SupportedApiListInterfaceParameters
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public bool Optional { get; set; }
            public string Description { get; set; }
        }
    }
}