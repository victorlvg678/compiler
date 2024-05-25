namespace compiler
{
    public class SemanticAnalyzer
    {
        private List<LexicalComponent> _elements;
        private List<string> _variables;
        private List<string> _variablesStatus;
        
        public SemanticAnalyzer()
        {
            _elements = new List<LexicalComponent>();
            _variables = new List<string>();
            _variablesStatus = new List<string>();
        }

        public SemanticAnalyzer(List<LexicalComponent> elements) : this()
        {
            _elements = elements;
        }

        public SemanticAnalyzer(List<LexicalComponent> elements, List<string> variables) : this(elements)
        {
            _variables = variables;
        }

        public SemanticAnalyzer(List<LexicalComponent> elements, List<string> variables, List<string> variablesStatus) : this(elements, variables)
        {
            _variablesStatus = variablesStatus;
        }

        public void ClearAnalysis()
        {
            _elements = new List<LexicalComponent>();
            _variables = new List<string>();
            _variablesStatus = new List<string>();
        }

        public void setElements(List<LexicalComponent> elements)
        {
            _elements = elements;
        }

        public void setVariables(List<string> variables)
        {
            _variables = variables;
        }

        public void setVariablesStatus(List<string> variablesStatus)
        {
            _variablesStatus = variablesStatus;
        }

        public void Analyze()
        {
            for (int position = 0; position < _elements.Count; position++)
            {
                if (_elements[position].Number != (int)Tokens.Identifier)
                    continue;
                
                if (_elements[position + 1].Number == (int)Tokens.AssignmentOperator)
                {
                    if (_variables.Contains(_elements[position].Lexeme))
                    {
                        _variables.Add(_elements[position].Lexeme);
                        _variablesStatus.Add($"La variable {_elements[position].Lexeme} se está usando pero no se declaró");
                    }
                    else
                    {
                        _variables.Add(_elements[position].Lexeme);
                        _variablesStatus.Add($"Se declaró la variable {_elements[position].Lexeme}");
                    }
                    continue;
                }

                if (_variables.Contains(_elements[position].Lexeme))
                    continue;

                _variables.Add(_elements[position].Lexeme);
                _variablesStatus.Add($"La variable {_elements[position].Lexeme} se está usando pero no se declaró");
            }   
        }


    }
}
