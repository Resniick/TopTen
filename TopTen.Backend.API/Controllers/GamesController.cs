using Microsoft.AspNetCore.Mvc;
using TopTen.Backend.API.Games;

namespace TopTen.Backend.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GamesController : ControllerBase
	{
		private readonly ILogger<GamesController> logger;

		public GamesController(ILogger<GamesController> logger)
		{
			this.logger = logger;
		}

		[HttpGet]
		public IEnumerable<Game> GetAllGames()
		{
			var games = new[]
			{
				new Game
				{
					Id = Guid.NewGuid(),
					Name = "Top 10 - Julafton",
					Password = "julafton",
					Questions = new List<Question>
					{
						new() {
							Id= Guid.NewGuid(),
							Description = "",
							TopTenAnswers = new List<Answer>
							{
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 1,
								},
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 2,
								},
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 3,
								},
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 4,
								},
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 5,
								},
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 6,
								},
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 7,
								},
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 8,
								},
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 9,
								},
								new()
								{
									Id = Guid.NewGuid(),
									Description = "",
									Points = 10,
								},
							},
						}
					},
				},
			};

			return games;
		}
	}
}
