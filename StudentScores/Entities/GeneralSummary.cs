namespace StudentScores.Entities
{
    public class GeneralSummary
    {
        public int TotalStudentsCount { get; set; }

        public int MinScore { get; set; }

        public int MaxScore { get; set; }
        public double AvgScore { get; set; }
    }
}