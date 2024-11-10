using Microsoft.AspNetCore.Mvc;

public class HomeController : ControllerBase {

    [Route("/")]
    public IActionResult Home() {
        return Ok("Merhaba!");
    }
}