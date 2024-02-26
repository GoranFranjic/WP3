using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]


    public class Eo2VarijableTipoviPodatakaOperatori : ControllerBase    
    {

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            return int.MaxValue;
        }
        // Ovdje završava ruta

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public float Zad1(int a, int b)
        {
            return a/(float)b;
        }
        // Ovdje završava ruta

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad3")]
        public float Zad3(int a, int b)
        {
            return  (a*b)+(a/(float)b);
        }
        // Ovdje završava ruta

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad4")]
        public bool Zad4(int a, int b)
        {
            return a == b;
        }
        // Ovdje završava ruta

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad5")]
        public string Zad5(string a, string b)
        {
            return a+" "+b;
        }
        // Ovdje završava ruta






    }
}
