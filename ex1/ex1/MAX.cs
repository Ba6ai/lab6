namespace ex1
{
    internal class MAX
    {
        protected int x = 0;
        protected int y = 0;
        protected int z = 0;

        public MAX(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public MAX(MAX i)
        {
            this.x = i.x;
            this.y = i.y;
            this.z = i.z;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int GetMAX()
        {
            return Math.Max(this.x, Math.Max(this.y, this.z));
        }

        
        public override string ToString()
        {
            return x + " " + y + " " + z;
        }
    }
}
