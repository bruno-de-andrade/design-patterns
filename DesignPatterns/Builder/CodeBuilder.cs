using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class ClassElement
    {
        public string Name { get; set; }

        public List<FieldElement> Fields { get; set; }

        private const int IndentSize = 2;

        public ClassElement()
        {
            Fields = new List<FieldElement>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"public class {Name}");
            sb.AppendLine("{");

            foreach (var field in Fields)
            {
                sb.AppendLine($"{new string(' ', IndentSize)}public {field.Type} {field.Name};");
            }

            sb.AppendLine("}");

            return sb.ToString();
        }
    }

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

    public class CodeBuilder
    {
        private readonly string className;

        private ClassElement classElement = new ClassElement();

        public CodeBuilder(string className)
        {
            this.className = className;
            this.classElement.Name = className;
        }

        public CodeBuilder AddField(string name, string type)
        {
            classElement.Fields.Add(new FieldElement(name, type));

            return this;
        }

        public void Clear()
        {
            classElement = new ClassElement() { Name = className };
        }

        public override string ToString()
        {
            return classElement.ToString();
        }
    }
}
