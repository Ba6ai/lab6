namespace ex1
{
    internal class MAX
    {
        protected int _x;
        protected int _y;
        protected int _z;

        public MAX(int x, int y, int z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public MAX(MAX i)
        {
            this._x = i._x;
            this._y = i._y;
            this._z = i._z;
        }

        public int X
        {
            get 
            {
                return _x; 
            }
            set 
            {
                _x = value;
            }
        }

        public int GetMAX()
        {
            return Math.Max(this._x, Math.Max(this._y, this._z));
        }

        
        public override string ToString()
        {
            return _x + " " + _y + " " + _z;
        }
    }
}
