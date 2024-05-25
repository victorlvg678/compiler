namespace compiler
{
    internal class AsmInstruction
    {
        public string Instruction { get; set; }
        public string Operand1 { get; set; }
        public string Operand2 { get; set; }

        public AsmInstruction(string instruction, string operand1, string operand2 = "")
        {
            Instruction = instruction;
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public override string ToString()
        {
            return $"{Instruction} {Operand1}{(Operand2 != "" ? ", " + Operand2 : "")}";
        }
    }

    internal class Generator
    {
        public static List<AsmInstruction> GenerateAsm(List<LexicalComponent> elements)
        {
            var asmInstructions = new List<AsmInstruction>();

            for (int position = 0; position < elements.Count; position++) {
                if (elements[position].Token.ToUpper().Equals("IDENTIFIER") && elements[position + 1].Token.ToUpper().Equals("ASSIGNMENTOPERATOR")) {
                    var destination = elements[position].Lexeme;

                    
                    if (elements[position + 2].Token.ToUpper().Equals("NUMBER")) 
                    {
                        asmInstructions.Add(new AsmInstruction("MOV", destination, elements[position + 2].Lexeme));
                        position += 2;
                        continue;
                    }
                    
                    if (elements[position + 2].Token.ToUpper().Equals("IDENTIFIER")) 
                    {
                        asmInstructions.Add(new AsmInstruction("MOV", destination, elements[position + 2].Lexeme));
                        position += 2;
                        continue;
                    }

                    if (elements[position + 2].Token.ToUpper().Equals("ADDITIONOPERATOR") || 
                               elements[position + 2].Token.ToUpper().Equals("SUBSTRACTIONOPERATOR") ||
                               elements[position + 2].Token.ToUpper().Equals("MULTIPLICATIONOPERATOR") ||
                               elements[position + 2].Token.ToUpper().Equals("DIVISIONOPERATOR")) {
                        
                        var tempReg = "EAX";
                        asmInstructions.Add(new AsmInstruction("MOV", tempReg, elements[position + 2].Lexeme));
                        asmInstructions.Add(new AsmInstruction("MOV", destination, tempReg));
                    }

                    position += 2;

                    continue;
                }

                if (elements[position].Token.ToUpper().Equals("ADDITIONOPERATOR") ||
                         elements[position].Token.ToUpper().Equals("SUBSTRACTIONOPERATOR") ||
                         elements[position].Token.ToUpper().Equals("MULTIPLICATIONOPERATOR") ||
                         elements[position].Token.ToUpper().Equals("DIVISIONOPERATOR")) {

                    var destination = elements[position - 1].Lexeme;
                    var tempReg = "EAX";

                    if (elements[position + 1].Token.ToUpper().Equals("NUMBER") || elements[position + 1].Token.ToUpper().Equals("IDENTIFIER")) {
                        asmInstructions.Add(new AsmInstruction("MOV", tempReg, elements[position + 1].Lexeme));

                        if (elements[position].Token.ToUpper().Equals("ADDITIONOPERATOR"))
                        { 
                            asmInstructions.Add(new AsmInstruction("ADD", destination, tempReg));
                            position++;
                            continue;
                        }

                        if (elements[position].Token.ToUpper().Equals("SUBSTRACTIONOPERATOR"))
                        { 
                            asmInstructions.Add(new AsmInstruction("SUB", destination, tempReg));
                            position++;
                            continue;
                        }

                        if (elements[position].Token.ToUpper().Equals("MULTIPLICATIONOPERATOR"))
                        { 
                            asmInstructions.Add(new AsmInstruction("MUL", destination, tempReg));
                            position++;
                            continue;
                        }

                        if (elements[position].Token.ToUpper().Equals("DIVISIONOPERATOR"))
                        {
                            asmInstructions.Add(new AsmInstruction("DIV", tempReg));
                            asmInstructions.Add(new AsmInstruction("MOV", destination, "EAX"));
                        }

                        position += 1;
                    }
                }
            }

            return asmInstructions;
        }
    }   

}
