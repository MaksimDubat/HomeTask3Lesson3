namespace homework8
{
    abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Eat();

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}