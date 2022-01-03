﻿using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> parentheses = new Dictionary<char, char>()
                { { '(', ')' }, { '[', ']' }, { '{', '}' } };
            Stack<char> stack = new Stack<char>();
            string sequence = Console.ReadLine();
            bool isBalanced = true;

            foreach (var c in sequence)
            {
                if (parentheses.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0 || parentheses[stack.Pop()] != c)
                {
                    isBalanced = false;
                    break;
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
