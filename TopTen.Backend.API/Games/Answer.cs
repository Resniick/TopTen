namespace TopTen.Backend.API.Games
{
	public class Answer
	{
        public required Guid Id { get; set; }
        public required string Description { get; set; }
        public required int Points { get; set; }
    }
}
