namespace TrianglePoints
{
    public class TrianglePointsSolver
    {
        private class Point
        {
            public double X {get; set; }
            public double Y {get; set; }
        }

        private static double Sign(Point point, Point line1, Point line2)
        {
            return (point.X - line2.X) * (line1.Y - line2.Y) - (line1.X - line2.X) * (point.Y - line2.Y);
        }

        public static bool WithinTriangle(int[] p1, int[] p2, int[] p3, int[] test)
        {
            var point1 = new Point() {X = p1[0], Y = p1[1]}; 
            var point2 = new Point() {X = p2[0], Y = p2[1]};
            var point3 = new Point() {X = p3[0], Y = p3[1]};
            var testPoint = new Point() {X = test[0], Y = test[1]};
            
            var d1 = Sign(testPoint, point1, point2);
            var d2 = Sign(testPoint, point2, point3);
            var d3 = Sign(testPoint, point3, point1);


            var hasNeg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            var hasPos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(hasNeg && hasPos);
        } 
    }
}