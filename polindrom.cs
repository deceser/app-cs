using System; // підключаємо стандартну бібліотеку для Console.WriteLine

class Solution
{
    static bool IsPalindrome(int x)
    {
        if (x < 0) return false; // від'ємні числа не можуть бути паліндромами

        int original = x, reversed = 0; // зберігаємо оригінал; reversed — перевернуте число, починаємо з 0

        while (x > 0) // повторюємо, поки залишились цифри
        {
            reversed = reversed * 10 + x % 10; // зсуваємо reversed вліво і дописуємо останню цифру x
            x /= 10; // відкидаємо останню цифру x
        }

        return original == reversed; // паліндром, якщо оригінал і перевернуте число рівні
    }

    static void Main()
    {
        Console.WriteLine(IsPalindrome(121));   // true
        Console.WriteLine(IsPalindrome(-121));  // false
        Console.WriteLine(IsPalindrome(10));    // false
        Console.WriteLine(IsPalindrome(0));     // true
        Console.WriteLine(IsPalindrome(1221));  // true
    }
}
