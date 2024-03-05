using DummyServiceDI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DummyServiceDI.Controllers; 

[ApiController]
[Route("[controller]")]
public class AnotherController : ControllerBase
{
    private readonly IDummyService _dummyService; 

    public AnotherController(IDummyService dummyService)
    {
        _dummyService = dummyService; 
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_dummyService.AnotherMessage());
    }
}