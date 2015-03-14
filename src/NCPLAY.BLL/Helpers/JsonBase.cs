using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes;
using NCPLAY.BLL.Exceptions;
using Newtonsoft.Json;

namespace NCPLAY.BLL.Helpers
{
    /// <summary>
    ///     Base class for making JSON calls and casting ApiResponse or ApiErrorResponse-objects
    /// </summary>
    public class JsonBase
    {
        private static async Task<TA> MakeCall<TA, TE>(string uri)
            where TE : ApiErrorResponse
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                var response = await client.GetAsync(uri);
                if (!response.IsSuccessStatusCode) throw new ApiException("Json call to uri: '" + uri + "' failed");
                var json = await response.Content.ReadAsStringAsync();
                try
                {
                    return JsonConvert.DeserializeObject<TA>(json);
                }
                catch (Exception)
                {
                    try
                    {
                        var error = JsonConvert.DeserializeObject<TE>(json);
                        throw new ApiException(error);
                    }
                    catch (Exception e2)
                    {
                        throw new ApiException("JSON call failed", e2);
                    }
                }
            }
        }

        protected async Task<TA> JsonGetObject<TA, TE>(string uri)
            where TA : ApiResponse
            where TE : ApiErrorResponse
        {
            return await MakeCall<TA, TE>(uri);
        }

        public async Task<Dictionary<TA, TB>> JsonGetDictionary<TA, TB, TE>(string uri)
            where TB : ApiResponse
            where TE : ApiErrorResponse
        {
            return await MakeCall<Dictionary<TA, TB>, TE>(uri);
        }

        public async Task<List<TA>> JsonGetArray<TA, TE>(string uri)
            where TA : ApiResponse
            where TE : ApiErrorResponse
        {
            return await MakeCall<List<TA>, TE>(uri);
        }

        public async Task<Dictionary<TA, List<TB>>> JsonGetDictionaryWithLists<TA, TB, TE>(string uri)
            where TB : ApiResponse
            where TE : ApiErrorResponse
        {
            return await MakeCall<Dictionary<TA, List<TB>>, TE>(uri);
        }
    }
}