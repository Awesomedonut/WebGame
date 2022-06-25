using Microsoft.AspNetCore.Mvc;
using WebGame.Models;
namespace WebGame.Controllers;

[ApiController]
[Route("[controller]")]
public class EnemyController : ControllerBase
{


    public EnemyController()
    {
     
    }

    [HttpGet("/list")]
    public string GetList()
    {
        return "isaac";
    }

    [HttpGet("/villain")]
    public Villain GetVillain()
    {
        Villain Bob = new Villain();
        return Bob;
    }

}

