using Microsoft.AspNetCore.Mvc;
using FantaSerieZ.Data;

namespace FantaSerieZ.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
   private readonly PlayerManager _playerManager;

   public PlayerController (PlayerManager playerManager)
   {
       _playerManager = playerManager;
   }

   [HttpGet]
   public ActionResult Get()
   {
       return Ok(_playerManager.Players.OrderBy(x => x.PlayerId));
   }
}