using System;
using System.Collections.Generic;

namespace File_Destruture_sanwix.MessUps
{
    public class Token<T> where T : ITokenType
    {
        T type;
        private const string SIGNITURE = "Sanwix<MH3Token>";
        public string Id { get; set; }

        public string Number { get; set; }
        public string Data { get; set; }
        public string Signiture { get {return Signiture;} }

        public Token(T type)
        {
            Id = Guid.NewGuid().ToString();
            this.type = type;
        }

        private Token(string uniqe)
        {
            Id = uniqe;
        }
        private Token<T> SetNumber(int number)
        {
            Number = number.ToString();
            return this;
        }
        private Token<T> SetData(string data)
        {
            Data = data;
            return this;
        }
        

        public void GenerateTokens(ref List<string> data)
        {
            for (int index = 0; index < data.Count; index++)
                data[index] = new Token<T>(Id)
                                .SetNumber(index)
                                .SetData(data[index])
                                .ToString();
        }

        

        public override string ToString()
        {
            return $"{type.StartKey}.{Id}.{Number}.{type.EndKey}.{Data}.{type.StartKey}.{Signiture}.{type.EndKey}";
        }
    }
}