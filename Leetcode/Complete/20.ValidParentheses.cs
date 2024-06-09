public class ValidParentheses {
    public bool IsValid(string s) {
        if(s.Length%2==1) { return false; }
        Stack<char> stk = new Stack<char>();

        foreach(char c in s) {
            if(c == '(') { stk.Push(')'); continue; }
            if(c == '{') { stk.Push('}'); continue; }
            if(c == '[') { stk.Push(']'); continue; }
            if(stk.Count == 0 || c != stk.Pop()) return false;
        }
        return stk.Count == 0;
    }
}