using LeageStats.Model.Match;


namespace LeageStats.Model
{
    /// <summary>
    /// Дто Матча
    /// </summary>
    public class MatchDto
    {
        public MatchDto()
        {
        }

        public MatchDto(Metadata metadata, Info info)
        {
            this.metadata = metadata;
            this.info = info;
        }

        public Metadata metadata { get; set; }
        public Info info { get; set; }
    }
}
