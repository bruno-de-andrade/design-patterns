using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class Token
    {
        public TokenType TokenType;

        public string Text;

        public Token(TokenType tokenType, string text)
        {
            TokenType = tokenType;
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
        }
    }
}
