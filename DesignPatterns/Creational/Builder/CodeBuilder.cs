namespace DesignPatterns.Creational.Builder
{
    public class CodeBuilder
    {
        private readonly string _className;

        private ClassElement _classElement;

        public CodeBuilder(string className)
        {
            _className = className;
            _classElement = new ClassElement()
            {
                Name = className
            };
        }

        public CodeBuilder AddField(string name, string type)
        {
            _classElement.Fields.Add(new FieldElement(name, type));

            return this;
        }

        public void Clear()
        {
            _classElement = new ClassElement() { Name = _className };
        }

        public ClassElement GetClassElement()
        {
            return _classElement;
        }

        public override string ToString()
        {
            return _classElement.ToString();
        }
    }
}
