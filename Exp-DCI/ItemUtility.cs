using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exp_DCI
{
    public class ItemUtility
    {
        public IEnumerable<Item> GetCombinedItemResults(IGetItem getAlbum, IGetItem getPhoto, string baseUrl, int userId)
        {
            List<Item> albums = getAlbum.GetItems(baseUrl + "/albums", userId);

            List<Item> result = new List<Item>();

            foreach(Item album in albums) {
                List<Item> photos = getPhoto.GetItems(baseUrl + "/photos", album.Id);
                result.Add(album);
                foreach(Item photo in photos)
                {
                    result.Add(photo);
                }
            }

            return result;
        }
    }
}
