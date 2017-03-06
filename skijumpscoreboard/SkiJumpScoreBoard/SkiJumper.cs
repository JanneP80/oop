namespace SkiJumpScoreBoard
{
    internal class SkiJumper
    {

        private int _id;
        private string _competitorName;
        private float _points;


        public SkiJumper(int id, string competitorName, float points)
        {
            _id = id;
            _competitorName = competitorName;
            _points = points;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string CompetitorName
        {
            get { return _competitorName; }
            set { _competitorName = value; }
        }

        public float Points
        {
            get { return _points; }
            set { _points = value; }
        }
    }
}