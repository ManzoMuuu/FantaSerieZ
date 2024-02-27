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
   public ActionResult Get(int take = 10, int skip = 0)
   {
       return Ok(_playerManager.Player.OrderBy(p => p.TwitchToken).Skip(skip).Take(take));
   }
}