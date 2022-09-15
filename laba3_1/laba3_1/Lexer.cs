using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_1{
    public enum State { S, cm, id, ss, cf, st, dp, fin }
    public class Pair
    {
        public int n, m;
        public Pair(int n, int m)
        {
            this.n = n;
            this.m = m;
        }
        public override string ToString()
        {
            return String.Format("<{0}, {1}>", n, m);
        }
    }

    class Lexer
    {
        State T;

        public string[] Operators = new string[] {
            "const", "var", "integer",
            "string", "begin", "for",
            "to", "do", "end."
        };
        public string[] Operations = new string[] {
            "=", ":=", "+", "-", "/", "*"
        };
        public string[] Symbols = new string[] {
            ";", ":", ".", ",", "(", ")"
        };
        public List<string> Identificators = new();
        public List<string> Strings = new();
        public List<int> Integers = new();
        public List<Pair> output = new();

        string Buf = "";
        char[] Input;
        IEnumerator inputEnum;
        bool skip = true;

        public Lexer(string input) {
            Input = input.ToCharArray();
            inputEnum = Input.GetEnumerator();
        }

        public char GetInputChar() {
            if (!skip) {
                skip = true;
                return (char)inputEnum.Current;
            }
            if (!inputEnum.MoveNext()) {
                return 'Ʇ';
            }
            return (char)inputEnum.Current;
        }
        public void RevLit(char c) {
            skip = false;
        }

        public void PutInBuf(char c) {
            Buf += c;
        }

        public bool Number(char c) {
            return (c >= '0' && c <= '9');
        }

        public bool Letter(char c) {
            return ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_');
        }

        public int Buf_Intend_Key() {
            for (int i = 0; i < Operators.Length; i++) {
                if (Buf.Equals(Operators[i])) {
                    return i + 1;
                }
            }
            for (int i = 0; i < Identificators.Count; i++) {
                if (Buf.Equals(Identificators[i])) {
                    return i + 1;
                }
            }
            Identificators.Add(Buf);
            return Identificators.Count;
        }

        public int Buf_Oper() {
            for (int i = 0; i < Operations.Length; i++) {
                if (Buf.Equals(Operations[i])) {
                    return i + 1;
                }
            }
            return 0;
        }

        public int Buf_Spec() {
            for (int i = 0; i < Symbols.Length; i++) {
                if (Buf.Equals(Symbols[i])) {
                    return i + 1;
                }
            }
            return 0;
        }
        public int Buf_Num() {
            Integers.Add(Int32.Parse(Buf));
            return Integers.Count;
        }

        public int Buf_Str() {
            Strings.Add(Buf);
            return Strings.Count;
        }
        public void PutInOut(int N, int M) {
            output.Add(new Pair(N, M));
        }

        public int StepLexAnalize() {
            char c;
            T = State.S;
            Buf = "";
            do {
                c = GetInputChar();
                switch (T) {
                    case State.S:
                        if (c == ' ' || c == '\t' || c == '\r' || c == '\n')
                            break;
                        if (c == '{') {
                            T = State.cm; 
                            break;
                        }
                        if (c == '\"' || c == '\'') {
                            T = State.st; 
                            break;
                        }
                        if (c == 'Ʇ') return 0;
                        PutInBuf(c);
                        if (Letter(c)) {
                            T = State.id; 
                            break;
                        }
                        if (c == '=' || c == '+' || c == '-' || c == '/' || c == '*') return Buf_Oper();
                        if (c == ':') {
                            T = State.ss; 
                            break;
                        }
                        if (c == '.' || c == ';' || c == ',' || c == '(' || c == ')') return Buf_Spec();
                        if (Number(c)) {
                            T = State.cf; 
                            break;
                        }
                        return -1;

                    case State.id:
                        if (Number(c) || Letter(c)) {
                            PutInBuf(c); break;
                        } else {
                            RevLit(c);
                            return Buf_Intend_Key();
                        }

                    case State.cm:
                        if (c != '}') break;
                        T = State.S;
                        break;

                    case State.ss: 
                        if (c == '=') {
                            PutInBuf(c);
                            return Buf_Oper();
                        }
                        RevLit(c);
                        return Buf_Spec();

                    case State.cf:
                        if (Number(c)) {
                            PutInBuf(c);
                            break;
                        }
                        RevLit(c);
                        return Buf_Num();
                    case State.st:
                        if (c == '\"' || c == '\'') T = State.dp;
                        else PutInBuf(c);
                        break;
                    case State.dp:
                        if (c == '\"') {
                            PutInBuf(c);
                            T = State.st;
                        }
                        RevLit(c);
                        return Buf_Str();
                }
            } while (true);
        }
        public int LexAnalize() {
            int N;
            do {
                N = StepLexAnalize();
                if (N <= 0) return N;
                PutInOut(N, (int)T);
            } while (true);
        }
    }
}
