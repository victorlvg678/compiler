namespace compiler
{
    public class LexicalComponent : ICloneable
    {
        private string _lexeme;
        private string _token;
        private int _number;

        public LexicalComponent() 
        {
            _lexeme = string.Empty;
            _token = string.Empty;
        }


        public LexicalComponent(string lexeme) : this()
        {
            _lexeme = !string.IsNullOrWhiteSpace(lexeme) ? lexeme : string.Empty;
        }

        public LexicalComponent(string lexeme, string token) : this(lexeme)
        {
            _token = !string.IsNullOrWhiteSpace(token) ? token : string.Empty;
        }

        public LexicalComponent(string lexeme, string token, int number) : this(lexeme, token)
        {
            _number = number;
        }

        public string Lexeme
        {
            get => _lexeme;
            set => _lexeme = !string.IsNullOrWhiteSpace(value) ? value : string.Empty;
        }

        public string Token
        {
            get => _token;
            set => _token = !string.IsNullOrWhiteSpace(value) ? value : string.Empty;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string getTokenInSpanish()
        {
            if (_token.ToUpper().Equals("IDENTIFIER"))
                return "Identificador";

            if (_token.ToUpper().Equals("NUMBER"))
                return "Número";

            if (_token.ToUpper().Equals("SEMICOLON"))
                return "PuntoYComa";

            if (_token.ToUpper().Equals("ENDOFLINE"))
                return "FinDeLinea";

            if (_token.ToUpper().Equals("ASSIGNMENTOPERATOR"))
                return "Asignación";

            if (_token.ToUpper().Equals("ADDITIONOPERATOR"))
                return "Suma";

            if (_token.ToUpper().Equals("SUBSTRACTIONOPERATOR"))
                return "Resta";

            if (_token.ToUpper().Equals("SUBSTRACTIONOPERATOR"))
                return "Resta";

            if (_token.ToUpper().Equals("MULTIPLICATIONOPERATOR"))
                return "Multiplicación";

            if (_token.ToUpper().Equals("DIVISIONOPERATOR"))
                return "División";

            return "Desconocido";
        }
    }
}
