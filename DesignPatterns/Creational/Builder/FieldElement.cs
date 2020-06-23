namespace DesignPatterns.Creational.Builder
{
    public class FieldElement
    {
        public string Name { get; }

        public string Type { get; }

        public FieldElement(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
