using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace GuitarHubCustomer
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

        //    internal async static Task<clsArtist> GetArtistAsync(string prArtistName)
        //    {
        //        using (HttpClient lcHttpClient = new HttpClient())
        //            return JsonConvert.DeserializeObject<clsArtist>
        //        (await lcHttpClient.GetStringAsync("http://localhost:60064/api/gallery/GetArtist?Name=" + prArtistName));

        //    }

        //    private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        //    {
        //        using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
        //        using (lcReqMessage.Content =
        //    new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
        //        using (HttpClient lcHttpClient = new HttpClient())
        //        {
        //            HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
        //            return await lcRespMessage.Content.ReadAsStringAsync();
        //        }
        //    }

        //    internal async static Task<string> UpdateWorkAsync(clsAllWork _Work)
        //    {
        //        return await InsertOrUpdateAsync(_Work, "http://localhost:60064/api/gallery/PutArtWork", "PUT");
        //    }

        //    internal async static Task<string> InsertWorkAsync(clsAllWork _Work)
        //    {
        //        return await InsertOrUpdateAsync(_Work, "http://localhost:60064/api/gallery/PostArtWork", "POST");
        //    }

        //    internal async static Task<string> InsertArtistAsync(clsArtist prArtist)
        //    {
        //        return await InsertOrUpdateAsync(prArtist, "http://localhost:60064/api/gallery/PostArtist", "POST");
        //    }

        //    internal async static Task<string> UpdateArtistAsync(clsArtist prArtist)
        //    {
        //        return await InsertOrUpdateAsync(prArtist, "http://localhost:60064/api/gallery/PutArtist", "PUT");
        //    }

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

        //    internal async static Task<string> DeleteArtistAsync(string prName)
        //    {
        //        using (HttpClient lcHttpClient = new HttpClient())
        //        {
        //            HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
        //        ($"http://localhost:60064/api/gallery/DeleteArtist?Name={prName}");
        //            return await lcRespMessage.Content.ReadAsStringAsync();
        //        }
        //        throw new NotImplementedException();
        //    }
    }
}
