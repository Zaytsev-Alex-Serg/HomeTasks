// Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
// Исходная строка считается допустимой при условии:
// 1. Открытые скобки должны быть закрыты скобками того же типа.
// 2. Открытые скобки должны быть закрыты в правильном порядке.
// 4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.

bool isValid (string test)
{
    if(test.Length % 2 != 0)
    {
        return false;
    }

    Stack<char> stack = new Stack<char>();

    for(int i = 0; i < test.Length; i++)
    {
        if (test[i] == '(')
            stack.Push(')');
        else if (test[i] == '[')
            stack.Push(']');
        else if (test[i] == '{')
            stack.Push('}');
        else if (stack.Count == 0 || test[i] != stack.Pop())
            return false;
    }
    return stack.Count == 0;
}


string test = "()({})";

Console.WriteLine(isValid(test));
