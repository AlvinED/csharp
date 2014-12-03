namespace FinalExam
{
    class Rectangle
    {
        private int _length;
        private int _width;

        public void SetLength(int len)
        {
            _length = len;
        }

        public void SetWidth(int wid)
        {
            _width = wid;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetLength()
        {
            return _length;
        }

        public int ComputeArea()
        {
            return _width * _length;
        }

        public int ComputeScaledArea(int scale)
        {
            return _width * _length * scale;
        }
    }
}