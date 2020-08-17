using Microsoft.AspNetCore.Mvc;

namespace Pikture.Service.Controllers
{
  // [Route("api/[controller]/[action]")] //Use this to reach actions via action name (defaults to method name)
  [Route("api/[controller]")]
  [ApiController] //Validation filter for common validation issues (replaces ModelState.IsValid)
  public class ImageController : ControllerBase
  {
    [HttpGet]
    //[ActionName("GetAll")]  //With action routing, best practice is to use ActionName over method names
    public IActionResult Get()
    {
      return Ok("http://placecorgi.com/");
    }

    [HttpGet("{width}/{height?}")]  //height? == height:Nullable<int>
    public IActionResult GetBySize(int width, int height)
    {
      return Ok($"http://placecorgi.com/{width}/{height}");
    }
  }
}

//localhost/api/image/200/100 - GET -> getBySize
//localhost/api/image - GET -> get
//localhost/api/image/200/0 - GET -> getBySize
//localhost/api/image/200/ - GET -> ?????, 404