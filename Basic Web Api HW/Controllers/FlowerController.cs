using Microsoft.AspNetCore.Mvc;

namespace Basic_Web_Api_HW.Controllers
{
    [ApiController]
    [Route("flowercontroller/[action]")]
    public class FlowerController
    {

        public string Flower1()
        {
            return "Rose";
        }
        public string Flower2()
        {
            return "Anemone";
        }
        public string Flower3()
        {
            return "Cyclamen";
        }
        public string Flower4()
        {
            return "Narcissus";
        }
    }
}
