using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiGiriss.Data;

namespace WebApiGiriss.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteYonetimiController : ControllerBase
    {
        private static readonly string[] BlokKodu = new[] 
        {
            "A", "B", "C", "D", "E"
        };
        private readonly ILogger<SiteYonetimiController> _logger;

        public SiteYonetimiController(ILogger<SiteYonetimiController> logger)
        {
            _logger = logger;
        }
        static List<Bloklar> daireler = new List<Bloklar>();

        [HttpGet("SiteYonetimiGet")]
        public IEnumerable<Bloklar> Get()
        {
            
            for(int i=0; i<5; i++)
            {
                for(int j=1; j<=200; j++)
                {
                    Bloklar blok = new Bloklar();
                    blok.BlokAdi = BlokKodu[i];
                    blok.DaireNo = j;
                    blok.DaireGider = new Random().Next(950, 2501);
                    daireler.Add(blok);
                }
                
            }
            return daireler;
        }

        [HttpPost("SiteYonetimiPost")]
        public string DaireEkleme ([FromBody]Bloklar blok) 
        {
            Bloklar bloklar = new Bloklar();
            bloklar.BlokAdi = blok.BlokAdi;
            bloklar.DaireNo=blok.DaireNo;
            bloklar.DaireGider = blok.DaireGider;
            daireler.Add(bloklar);

            return "Daire Eklendi!";
        }
    }
}
