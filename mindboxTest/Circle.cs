namespace mindboxTest
{
    public class Circle:IFigure
    {
        double Radius;


        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверно указан радиус круга");
            this.Radius = radius;
        }

        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}