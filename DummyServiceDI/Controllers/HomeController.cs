using DummyServiceDI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DummyServiceDI.Controllers; 

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly IDummyService _dummyService; 

    public HomeController(IDummyService dummyServiceDI)
    {
        _dummyService = dummyServiceDI; 
    } 

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_dummyService.GetMessage() + "\n\n" + _dummyService.AnotherMessage());
    }
}