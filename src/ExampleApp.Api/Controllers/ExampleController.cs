using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;
using System.Net;

namespace ExampleApp.Api.Controllers;

[ApiController]
[Route("/example")]
public class ExampleController : ControllerBase
{
    private readonly IConfiguration _config;
    
    public ExampleController(IConfiguration config)
    {
        _config = config;
    }
    
    [HttpGet]
    [Route("environment")]
    public ActionResult Get()
    {
        return Ok(new
        {
            Environment.MachineName,
            Environment.OSVersion,
        });
    }
    
    [HttpGet]
    [Route("secret")]
    public ActionResult Secret()
    {
        var config = _config.GetValue<string>("Config");
        var secret = _config.GetValue<string>("Secret");
        
        return Ok(new
        {
            Config = config, 
            Secret = secret
        });
    }
}