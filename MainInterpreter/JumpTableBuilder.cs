namespace BrainFInterpreter
{
    public static class JumpTableBuilder
    {
        public static Dictionary<int, int> BuildJumpTalbe(string code)
        {
            var jump = new Dictionary<int, int>();
            var stack = new Stack<int>();

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '[')
                {
                    stack.Push(i);
                }
                else if (code[i] == ']')
                {
                    int openIndex = stack.Pop();
                    int closeIndex = i;

                    jump[openIndex] = closeIndex;
                    jump[closeIndex] = openIndex;
                }
            }

            return jump;
        }
    }
}
