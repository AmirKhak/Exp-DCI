using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Exp_DCI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpDCIController : ControllerBase
    {
        private readonly string BaseUrl = "http://jsonplaceholder.typicode.com";

        private readonly ILogger<ExpDCIController> _logger;

        public ExpDCIController(ILogger<ExpDCIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetCombinedAlbumPhoto(int userId)
        {
            ItemUtility combineItems = new ItemUtility();
            IGetItem getAlbum = new GetAlbum();
            IGetItem getPhoto = new GetPhoto();
            IEnumerable<Item> items = combineItems.GetCombinedItemResults(getAlbum, getPhoto, BaseUrl, userId);
            string results = JsonConvert.SerializeObject(items);
            return results;
        }
    }
}
