using System;
using Exp_DCI.Controllers;
using Newtonsoft.Json;
using Xunit;

namespace Exp_DCI_Tests
{
    public class ExpDCIControllerTests
    {
        [Fact]
        public void ExpDCIController_Returns_Correct_Number_Of_Items()
        {
            ExpDCIController expDCIController = new ExpDCIController(null);

            string results = expDCIController.GetCombinedAlbumPhoto(1);
            Newtonsoft.Json.Linq.JArray jsonArray = (Newtonsoft.Json.Linq.JArray)JsonConvert.DeserializeObject(results);

            Assert.Equal(510, jsonArray.Count);
        }
    }
}
