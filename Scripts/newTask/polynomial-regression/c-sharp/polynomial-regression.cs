using System;
class Program
{

        static void Main(string[] args)
        {
            const int degree = 2;
            var x = new[] {0.0, 1.0,  2.0,  3.0,  4.0,  5.0,   6.0,   7.0,   8.0,   9.0,  10.0};
            var y = new[] {1.0, 6.0, 17.0, 34.0, 57.0, 86.0, 121.0, 162.0, 209.0, 262.0, 321.0};
            var p = Polyfit(x, y, degree);
            foreach (var d in p) Console.Write("{0} ",d);
            Console.WriteLine();
            for (int i = 0; i < x.Length; i++ )
                Console.WriteLine("{0} => {1} diff {2}", x[i], Polyval(p,x[i]), y[i] - Polyval(p,x[i]));
            Console.ReadKey(true);
        }

         public static double[] Polyfit(double[] x, double[] y, int degree)
        {
            // Vandermonde matrix
            var v = new DenseMatrix(x.Length, degree + 1);
            for (int i = 0; i < v.RowCount; i++)
                for (int j = 0; j <= degree; j++) v[i, j] = Math.Pow(x[i], j);
            var yv = new DenseVector(y).ToColumnMatrix();
            QR qr = v.QR();
            // Math.Net doesn't have an "economy" QR, so:
            // cut R short to square upper triangle, then recompute Q
            var r = qr.R.SubMatrix(0, degree + 1, 0, degree + 1);
            var q = v.Multiply(r.Inverse());
            var p = r.Inverse().Multiply(q.TransposeThisAndMultiply(yv));
            return p.Column(0).ToArray();
        }

}
