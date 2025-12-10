namespace BrainFInterpreter;

public class Interpreter
{
    public void Run(string code)
    {
        byte[] tape = new byte[30000];
        int ptr = 0;
        int pc = 0;

        var jump = JumpTableBuilder.BuildJumpTalbe(code);

        while (pc < code.Length)
        {
            char cmd = code[pc];

            switch (cmd)
            {
                // --- Moving ---
                case '>':
                    ptr++;
                    break;
                case '<':
                    ptr--;
                    break;
                
                // --- Incrementing and Decrementing ---
                case '+':
                    tape[ptr]++;
                    break;
                case '-':
                    tape[ptr]--;
                    break;
                
                // --- Input and Output
                case '.':
                    Console.Write((char)tape[ptr]);
                    break;
                case ',':
                    tape[ptr] = (byte)Console.Read();
                    break;
                
                // --- Looping ---
                case '[':
                    if (tape[ptr] == 0) pc = jump[pc];
                    break;
                case ']':
                    if (tape[ptr] != 0) pc = jump[pc];
                    break;
            }

            pc++;
        }
    }

}
