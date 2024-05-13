using System;
using System.Net.Http.Headers;
using System.Text;
using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get; set; }

        public IHttpClientFactory httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new();
            this.httpClient = httpClient;
        }

        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("MagicAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                if (apiRequest.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
                        Encoding.UTF8, "application/json");
                }
                switch (apiRequest.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                HttpResponseMessage apiResponse = null;

                if (!string.IsNullOrEmpty(apiRequest.Token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiRequest.Token);
                }

                apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                try
                {
					APIResponse API_Response = JsonConvert.DeserializeObject<APIResponse>(apiContent);
                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.BadRequest 
                        || apiResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        API_Response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                        API_Response.IsSuccess = false;
                    }
					var res = JsonConvert.SerializeObject(API_Response);
					var returnObj = JsonConvert.DeserializeObject<T>(res);
					return returnObj;
				}
                catch (Exception ex)
                {
					var API_Response = JsonConvert.DeserializeObject<T>(apiContent);
					return API_Response;
				}
            }
            catch (Exception ex)
            {
                var dto = new APIResponse
                {
                    ErrorMessages = ex.Message,
                    IsSuccess = false
                };
                var res = JsonConvert.SerializeObject(dto);
                var API_Response = JsonConvert.DeserializeObject<T>(res);
                return API_Response;
            }
        }
    }
}
