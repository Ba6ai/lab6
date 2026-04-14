namespace ex1
{
    internal class MAX
    {
        protected int x, y, z;

        // Конструктор (по улмолчанию)
        public MAX(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Копирование
        public MAX(MAX i)
        {
            this.x = i.x;
            this.y = i.y;
            this.z = i.z;
        }

        // Свойства
        public int getX
        {
            get { return x; }
            set { x = value; }
        }

        // Получение максимума
        public int GetMAX()
        {
            return Math.Max(this.x, Math.Max(this.y, this.z));
        }

        // Методы
        public override string ToString()
        {
            return x + " " + y + " " + z;
        }
    }
}
