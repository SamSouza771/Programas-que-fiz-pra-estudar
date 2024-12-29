namespace LeetCode;

public class Solution {
    public static void Main(String[] args)
    {
        Console.WriteLine(IsPalindrome(121));
        Console.WriteLine(IsPalindrome(-121));
        Console.WriteLine(IsPalindrome(11));
        Console.WriteLine(IsPalindrome(12));
    }
    public static bool IsPalindrome(int x) {
        string strX = Convert.ToString(x);
        char[] strZ = strX.ToCharArray();
        Array.Reverse(strZ);
        string inverted = new string(strZ);

        if (inverted == strX)
        {
            return true;
        }

        return false;
    }
}