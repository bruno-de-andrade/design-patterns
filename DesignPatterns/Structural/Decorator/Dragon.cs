namespace DesignPatterns.Structural.Decorator
{
    public class Dragon : IBird, ILizard
    {
        private readonly Bird _bird = new Bird();
        private readonly Lizard _lizard = new Lizard();
        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                _bird.Age = value;
                _lizard.Age = value;
            }
        }

        public void Crawl()
        {
            _lizard.Crawl();
        }

        public void Fly()
        {
            _bird.Fly();
        }
    }
}
