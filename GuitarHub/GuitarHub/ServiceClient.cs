using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace GuitarHub
{
    public static class ServiceClient
    {
        internal async static Task<List<clsGuitar>> GetGuitarsAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsGuitar>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/guitarhub/GetGuitars/"));
        }

        internal async static Task<List<clsOrders>> GetOrdersAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsOrders>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/guitarhub/GetOrders/"));
        }

        internal async static Task<List<clsOrderItems>> GetOrderAsync(int prOrderID)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsOrderItems>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/guitarhub/GetOrder?prID=" + prOrderID.ToString()));

        }

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content =
        new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<string> InsertGuitarAsync(clsGuitar prGuitar)
        {
            return await InsertOrUpdateAsync(prGuitar, "http://localhost:60064/api/guitarhub/PostGuitar", "POST");
        }

        internal async static Task<string> UpdateGuitarAsync(clsGuitar prGuitar)
        {
            return await InsertOrUpdateAsync(prGuitar, "http://localhost:60064/api/guitarhub/PutGuitar", "PUT");
        }

        internal async static Task<string> DeleteProductAsync(clsGuitar prGuitar)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ($"http://localhost:60064/api/guitarhub/DeleteProduct?serial_no={prGuitar.serial_no}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }

        }

        internal async static Task<string> DeleteOrderAsync(clsOrders prOrder)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ($"http://localhost:60064/api/guitarhub/DeleteOrder?order_id={prOrder.order_id}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }

        }

    }
   
}
