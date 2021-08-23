using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Exp_DCI
{
    public class GetAlbum : IGetItem
    {
        public List<Item> GetItems(string url, int Id)
        {
            List<Item> items = new List<Item>();
            WebClient client = new WebClient();
            string reply = client.DownloadString(url + "?userId=" + Id);
            Newtonsoft.Json.Linq.JArray jsonArray = (Newtonsoft.Json.Linq.JArray)JsonConvert.DeserializeObject(reply);

            foreach (var jsonObject in jsonArray)
            {
                Album item = jsonObject.ToObject<Album>();

                items.Add((Item)item);
            }

            return items;
        }
    }
}
