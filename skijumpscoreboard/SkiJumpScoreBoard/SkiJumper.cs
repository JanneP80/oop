namespace SkiJumpScoreBoard
{
    internal class SkiJumper
    {

        private int _id;
        private string _competitorName;
        private int _points;


        public SkiJumper(int id, string competitorName, int points)
        {
            _id = id;
            _competitorName = competitorName;
            _points = points;
        }
    }
}