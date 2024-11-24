namespace TopTen.Backend.API.Games
{
	public class Question
	{
        public required Guid Id { get; set; }
        public required string Description { get; set; }
        public required List<Answer> TopTenAnswers { get; set; }

        public List<Answer>? AdditionalAnswers { get; set; }
    }
}
