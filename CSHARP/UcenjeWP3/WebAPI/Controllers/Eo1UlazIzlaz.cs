using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E01")]


    public class Eo1UlazIzlaz:ControllerBase    
    {

        [HttpGet]
        [Route("Hello")]

        public string HElloWorld(string Ime)

        {
            return "Dobro večer  " +  Ime;


        }






    }
}
