namespace OOLessons.test
{
    public class Chance
    {
        private readonly double possibility;

        public Chance(double possibility)
        {
            this.possibility = possibility;
        }

        public Chance Not()
        {
            return new Chance(1 - possibility);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Chance)) return false;
            var other = (Chance) obj;
            return other.possibility.Equals(possibility);
        }

        public override int GetHashCode()
        {
            return possibility.GetHashCode();
        }
    }
}