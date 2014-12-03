namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            r1 = new Rectangle();

            r1.SetLength(10);
            r1.SetWidth(20);

            int W = r1.GetWidth();
            int L = r1.GetLength();
            int A = r1.ComputeArea();
            int S = r1.ComputeScaledArea(3);
        }
    }
}