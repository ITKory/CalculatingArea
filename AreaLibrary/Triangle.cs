

namespace AreaLibrary
{
    public class Triangle : BaseClass
    {
        private readonly double _halfЬeter;
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
  
        public Triangle(double a, double b, double c)
        {
            _halfЬeter =  (a+b+c)/2 ;
            _a = a;
            _b = b;
            _c = c;
            
          Area = Math.Sqrt(_halfЬeter * (_halfЬeter - _a) * (_halfЬeter - _b) * (_halfЬeter - _c));
        }

      

        public bool ISRightTriangle()
        {
            double[] sides = new[] { _a, _b, _c } ;
            double min = sides.Min();
            double middle = sides.Sum() - (sides.Max()+min);
            return Area == (min*middle)/2 ;
        }
    }
}
