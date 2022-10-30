using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly SqlConnection connection;

        public VideoGamesController(IConfiguration config)
        {
            connection = new SqlConnection(config.GetConnectionString("DefaultConnection"));
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGames>>> GetAllGames()
        {
            var games = await connection.QueryAsync<VideoGames>("select * from VideoGames");

            return Ok(games);
        }
        [HttpGet("(int:id)")]

        public async Task<ActionResult<List<VideoGames>>> GetGame(int gameid)
        {
            var game = await connection.QueryAsync<VideoGames>("select * from VideoGames where id=@Id",
            new { Id = gameid });
            return Ok(game);
        }

       

    }
}
