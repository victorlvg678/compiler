namespace compiler
{
    public class SyntaxAnalyzer
    {
        private List<LexicalComponent> _elements;
        private bool _isValid;
        private int _state;

        public SyntaxAnalyzer()
        {
            _elements = new List<LexicalComponent>();
        }

        public SyntaxAnalyzer(List<LexicalComponent> elements)
        {
            _elements = elements;
        }

        public void setElements(List<LexicalComponent> elements)
        {
            _elements = elements;
        }

        private void TransitionToState6(int position)
        {
            if (_elements[position].Number == (int)Tokens.EndOfLine)
                _isValid = true;

            _state = -1;
        }

        private void TransitionToState5(int position)
        {
            if (_elements[position].Number == (int)Tokens.Identifier)
            { 
                _state = 3;
                return;
            }

            if (_elements[position].Number == (int)Tokens.Number)
            {
                _state = 4;
                return;
            }

            _state = -1;
        }

        private void TransitionToState4(int position)
        {
            if (_elements[position].Number == (int)Tokens.AdditionOperator || _elements[position].Number == (int)Tokens.MultiplicationOperator)
            { 
                _state = 5;
                return;
            }

            if (_elements[position].Number == (int)Tokens.Semicolon)
            { 
                _state = 6;
                return;
            }

            _state = -1;
        }

        private void TransitionToState3(int position)
        {
            if (_elements[position].Number == (int)Tokens.AdditionOperator || _elements[position].Number == (int)Tokens.MultiplicationOperator)
            {
                _state = 5;
                return;
            }

            if (_elements[position].Number == (int)Tokens.Semicolon)
            { 
                _state = 6;
                return;
            }

            _state = -1;
        }

        private void TransitionToState2(int position)
        {
            if (_elements[position].Number == (int)Tokens.Identifier)
            { 
                _state = 3;
                return;
            }

            if (_elements[position].Number == (int)Tokens.Number)
            { 
                _state = 4;
                return;
            }

            _state = -1;
        }

        private void TransitionToState1(int position)
        {
            _state = _elements[position].Number == (int)Tokens.AssignmentOperator ? 2 : -1;
        }

        private void TransitionToState0(int position)
        {
            _state = _elements[position].Number == (int)Tokens.Identifier ? 1 : -1;
        }

        private void StateTransition(int position)
        {
            if (_state == 0)
            {
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

            if (_state == 4)
            {
                TransitionToState4(position);
                return;
            }

            if (_state == 5)
            {
                TransitionToState5(position);
                return;
            }

            if (_state == 6)
            {
                TransitionToState6(position);
            }
        }

        public bool Analyze()
        {
            for (int position = 0; position < _elements.Count; position++)
            {
                StateTransition(position);

                if (_state == -1)
                    break;
            }

            return _isValid;
        }

        public void ClearAnalysis()
        {
            _state = 0;
            _isValid = false;
            _elements = new List<LexicalComponent>();
        }
    }
}
