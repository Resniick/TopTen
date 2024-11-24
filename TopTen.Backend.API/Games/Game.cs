namespace TopTen.Backend.API.Games
{
	public class Game
	{
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Password { get; set; }
        public required List<Question> Questions { get; set; }
    }
}
