using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
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
}
