namespace timezonewebapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class  ItemsController: ControllerBase
    {
       
//Get a list of timezones falls under specific UTC offset
var tzs = ExpressTimeZone.OffsetToTimezones(330);
foreach (var tz in tzs))
{
    Console.WriteLine(tz.DisplayName);
}

  [HttpGet]
  public async Task<IActionResult> GetItems()
  {
    var currentTime = DateTime.UtcNow.AddMinutes(int.Parse(
      Request.Headers["TimeZone-Offset"] != StringValues.Empty
        ? Request.Headers["TimeZone-Offset"][0] : "0"));

   
  }

        private readonly ILogger< ItemsController> _logger;

        public WeatherForecastController(ILogger< ItemsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable< ItemsController> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new  ItemsController
            {
                Date = DateTime.Now.AddDays(index),
             
            })
            .ToArray();
        }
    }
}
