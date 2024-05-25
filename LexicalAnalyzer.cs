namespace compiler
{
    public class LexicalAnalyzer
    {
        private int _state;
        private string _lexeme;
        private string _line;
        private List<LexicalComponent> _elements;

        public LexicalAnalyzer()
        {
            _state = 0;
            _lexeme = string.Empty;
        }

        public LexicalAnalyzer(string line) : this()
        {
            this._line = line;
        }

        public LexicalAnalyzer(string line, List<LexicalComponent> elements) : this(line)
        {
            this._elements = elements;
        }

        private void ClearTransition()
        {
            _state = 0;
            _lexeme = string.Empty;
        }

        public void ClearAnalysis()
        {
            _state = 0;
            _lexeme = string.Empty;
            _elements = new List<LexicalComponent>();
            _line = string.Empty;
        }

        public void setLine(string line)
        {
            _line = line;
        }

        public void setElements(List<LexicalComponent> elements)
        {
            _elements = elements;
        }

        public List<LexicalComponent> getElements()
        {
            return _elements;
        }

        private void TransitionToState3(int position)
        {
            if (char.IsDigit(_line[position]))
            {
                _state = 3;
                _lexeme += _line[position];
                return;
            }

            _elements.Add(new LexicalComponent(_lexeme, Tokens.Number.ToString(), (int)Tokens.Number));
            ClearTransition();
        }

        private void TransitionToState2(int position)
        {
            if (Char.IsDigit(_line[position]))
            {
                _state = 2;
                _lexeme += _line[position];
                return;
            }

            if (_line[position] == '.')
            {
                _state = 3;
                _lexeme += _line[position];
                return;
            }

            _elements.Add(new LexicalComponent(_lexeme, Tokens.Number.ToString(), (int)Tokens.Number));
            ClearTransition();
        }

        private void TransitionToState1(int position)
        {
            if (!Char.IsDigit(_line[position]) && !Char.IsLetter(_line[position]) && _line[position] != '_')
                return;

            _state = 1;
            _lexeme += _line[position];

            if (Char.IsDigit(_line[position + 1]) || Char.IsLetter(_line[position + 1]) || _line[position + 1] == '_')
                return;

            _elements.Add(new LexicalComponent(_lexeme, Tokens.Identifier.ToString(), (int)Tokens.Identifier));
            ClearTransition();
        }


        private void TransitionToState0(int position)
        {
            if (_line[position] == ' ' || _line[position] == '\t' || _line[position] == '\n')
            {
                ClearTransition();
                return;
            }

            if (Char.IsLetter(_line[position]) || _line[position] == '_')
            {
                _state = 1;
                _lexeme += _line[position];

                if (Char.IsDigit(_line[position + 1]) | Char.IsLetter(_line[position + 1]) || _line[position + 1] == '_')
                    return;

                _elements.Add(new LexicalComponent(_lexeme, Tokens.Identifier.ToString(), (int)Tokens.Identifier));
                ClearTransition();
                return;
            }

            if (Char.IsDigit(_line[position]))
            {
                _state = 2;
                _lexeme += _line[position];

                if (Char.IsDigit(_line[position + 1]) || _line[position] == '.')
                    return;

                _elements.Add(new LexicalComponent(_lexeme, Tokens.Number.ToString(), (int)Tokens.Number));
                ClearTransition();
                return;
            }

            if (_line[position] == ';')
            {
                _lexeme += _line[position];
                _elements.Add(new LexicalComponent(_lexeme, Tokens.Semicolon.ToString(), (int)Tokens.Semicolon));
                ClearTransition();
                return;
            }

            if (_line[position] == '$')
            {
                _lexeme += _line[position];
                _elements.Add(new LexicalComponent(_lexeme, Tokens.EndOfLine.ToString(), (int)Tokens.EndOfLine));
                ClearTransition();
                return;
            }

            if (_line[position] == '=')
            {
                _lexeme += _line[position];
                _elements.Add(new LexicalComponent(_lexeme, Tokens.AssignmentOperator.ToString(), (int)Tokens.AssignmentOperator));
                ClearTransition();
                return;
            }

            if (_line[position] == '+')
            {
                _lexeme += _line[position];
                _elements.Add(new LexicalComponent(_lexeme, Tokens.AdditionOperator.ToString(), (int)Tokens.AdditionOperator));
                ClearTransition();
                return;
            }

            if (_line[position] == '-')
            {
                _lexeme += _line[position];
                _elements.Add(new LexicalComponent(_lexeme, Tokens.SubstractionOperator.ToString(), (int)Tokens.SubstractionOperator));
                ClearTransition();
                return;
            }
            
            if (_line[position] == '*')
            {
                _lexeme += _line[position];
                _elements.Add(new LexicalComponent(_lexeme, Tokens.MultiplicationOperator.ToString(), (int)Tokens.MultiplicationOperator));
                ClearTransition();
                return;
            }

            if (_line[position] == '/')
            {
                _lexeme += _line[position];
                _elements.Add(new LexicalComponent(_lexeme, Tokens.DivisionOperator.ToString(), (int)Tokens.DivisionOperator));
                ClearTransition();
                return;
            }
        }

        private void StateTransition(int position)
        {
            if (_state == 0) { 
                TransitionToState0(position);
                return;
            }

            if (_state == 1)
            {
                TransitionToState1(position);
                return;
            }

            if (_state == 2)
            {
                TransitionToState2(position);
                return;
            }

            if (_state == 3)
            {
                TransitionToState3(position);
                return;
            }

        }
        public void Analyze()
        {
            for (var position = 0; position < _line.Length; position++)
            {
                StateTransition(position);
            }
        }
    }
}
