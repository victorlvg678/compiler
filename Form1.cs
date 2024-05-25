namespace compiler
{
    public partial class Form1 : Form
    {
        private List<List<LexicalComponent>> lexicalComponents;
        private List<string> variables;
        private List<string> variablesStatus;

        public Form1()
        {
            InitializeComponent();

            lexicalComponents = new List<List<LexicalComponent>>();
            variables = new List<string>();
            variablesStatus = new List<string>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLexicalAnalyzer_Click_1(object sender, EventArgs e)
        {
            lexicalComponents.Clear();
            listView1.Items.Clear();

            var lines = new List<string>();

            foreach (string line in textBoxInput.Lines)
                lines.Add(line + "$");

            var lexicalAnalyzer = new LexicalAnalyzer();

            foreach (string line in lines)
            {
                lexicalAnalyzer.ClearAnalysis();
                lexicalAnalyzer.setLine(line);
                lexicalAnalyzer.setElements(new List<LexicalComponent>());
                lexicalAnalyzer.Analyze();
                lexicalComponents.Add(lexicalAnalyzer.getElements().Clone().ToList());
            }

            foreach (List<LexicalComponent> lineComponentes in lexicalComponents)
            {
                foreach (LexicalComponent component in lineComponentes)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { component.Lexeme, component.getTokenInSpanish(), component.Number.ToString() }));
                }
            }
        }

        private void buttonSemanticAnalyzer_Click_1(object sender, EventArgs e)
        {
            listViewSymbolsTable.Items.Clear();
            variables.Clear();
            variablesStatus.Clear();

            var semanticAnalyzer = new SemanticAnalyzer();
            foreach (List<LexicalComponent> lineComponents in lexicalComponents)
            {
                semanticAnalyzer.ClearAnalysis();
                semanticAnalyzer.setElements(lineComponents);
                semanticAnalyzer.setVariables(variables);
                semanticAnalyzer.setVariablesStatus(variablesStatus);
                semanticAnalyzer.Analyze();
            }

            for (int i = 0; i < variables.Count; i++)
            {
                listViewSymbolsTable.Items.Add(new ListViewItem(new string[] { variables[i], variablesStatus[i] }));
            }
        }

        private void buttonSintaxAnalyzer_Click_1(object sender, EventArgs e)
        {
            textBoxSyntaxAnalyzeOutput.Clear();

            var lineComponents = new List<LexicalComponent>();
            var syntaxAnalyzer = new SyntaxAnalyzer();
            for (int i = 0; i < lexicalComponents.Count; i++)
            {
                syntaxAnalyzer.ClearAnalysis();
                lineComponents = lexicalComponents[i];
                syntaxAnalyzer.setElements(lineComponents);

                if (syntaxAnalyzer.Analyze())
                    textBoxSyntaxAnalyzeOutput.AppendText($"El texto ingresado en la línea {(i + 1)} es válido");
                else
                    textBoxSyntaxAnalyzeOutput.AppendText($"El texto ingresado en la línea {(i + 1)} no es válido\n");

                textBoxSyntaxAnalyzeOutput.AppendText(Environment.NewLine);
            }
        }

        private void buttonGenerateAsmCode_Click_1(object sender, EventArgs e)
        {
            textBoxGeneratedASM.Clear();

            textBoxGeneratedASM.AppendText(".MODEL SMALL" + Environment.NewLine);
            textBoxGeneratedASM.AppendText(".STACK" + Environment.NewLine);
            textBoxGeneratedASM.AppendText(".DATA" + Environment.NewLine);
            textBoxGeneratedASM.AppendText(".CODE" + Environment.NewLine + Environment.NewLine);

            textBoxGeneratedASM.AppendText("MAIN:" + Environment.NewLine + Environment.NewLine);

            foreach (List<LexicalComponent> lineComponentes in lexicalComponents)
            {
                foreach (AsmInstruction instruction in Generator.GenerateAsm(lineComponentes))
                {
                    textBoxGeneratedASM.AppendText(instruction.ToString() + Environment.NewLine);
                }
            }

            textBoxGeneratedASM.AppendText(Environment.NewLine + "END MAIN");
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}