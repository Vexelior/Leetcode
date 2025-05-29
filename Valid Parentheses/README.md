# Solution

## Problem Description

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

## Problem Explanation

An input string is valid if:

1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.
3. Every close bracket has a corresponding open bracket of the same type.

### Code

```csharp
    private static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> parenthesesMap = new Dictionary<char, char>
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'},
        };

        foreach (char c in s)
        {
            if (parenthesesMap.ContainsKey(c))
            {
                stack.Push(c);
            }
            else if (parenthesesMap.ContainsValue(c))
            {
                if (stack.Count == 0 || parenthesesMap[stack.Pop()] != c)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
```

### How It Works

The function `IsValid` checks if the input string `s` is valid by using a stack to keep track of open brackets. It iterates through each character in the string:

- If the character is an opening bracket (i.e., '(', '{', or '['), it is pushed onto the stack.
- If the character is a closing bracket (i.e., ')', '}', or ']'), it checks if the stack is empty or if the top of the stack does not match the corresponding opening bracket. If either condition is true, the function returns false.
- If the character is a closing bracket and the stack is not empty, it pops the top of the stack and checks if it matches the corresponding opening bracket. If it does not match, the function returns false.
- After processing all characters, if the stack is empty, it means all opening brackets were matched with closing brackets, and the function returns true. If the stack is not empty, it means there are unmatched opening brackets, and the function returns false.

### Complexity

- **Time Complexity**: O(n), where n is the length of the string `s`. Each character is processed once.
- **Space Complexity**: O(n) in the worst case, where all characters are opening brackets and stored in the stack.

### Example

```csharp
IsValid("()"); // returns true
IsValid("()[]{}"); // returns true
IsValid("(]"); // returns false
IsValid("([)]"); // returns false
IsValid("{[]}"); // returns true
```

## Limitations

This solution assumes that the input string only contains valid characters: '(', ')', '{', '}', '[' and ']'. If the input contains other characters, the function may not behave as expected. It is also case-sensitive, meaning that it does not handle uppercase or lowercase variations of the brackets.

## Conclusion

The provided solution effectively checks for valid parentheses in a string using a stack data structure. It ensures that all opening brackets are properly matched with their corresponding closing brackets in the correct order. This approach is efficient and straightforward, making it suitable for solving the problem of validating parentheses in strings.
