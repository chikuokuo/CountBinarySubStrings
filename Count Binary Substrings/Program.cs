// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var solution = new Solution();
var result = solution.CountBinarySubstrings("11100110010001");
public class Solution {
    public int CountBinarySubstrings(string s)
    {
        int[] groups = new int[s.Length];
        int t = 0;
        groups[0] = 1;
        for(int i = 1;i<s.Length;i++)
        {
            if(s[i] != s[i-1])
            {
                groups[++t] = 1;
            }
            else
            {
                groups[t]++;
            }
        }
        int res = 0;
        for(int i = 1; i<=t;i++)
        {
            res += Math.Min(groups[i-1], groups[i]);
        }
        return res;
        
        // var count = 0;
        // var currentIndex = 0;
        // for (var i = 0; i < s.Length; i++)
        // {
        //     var zeroCount = 0;
        //     var oneCount = 0;
        //     var startChar = s[i];
        //     var isChange = false;
        //     for (var j = i; j < s.Length; j++)
        //     {
        //         if (startChar == s[j])
        //         {
        //             if (isChange)
        //             {
        //                 i = i + zeroCount + oneCount - 1;
        //                 break;
        //             }
        //             if (s[j] == '0')
        //             {
        //                 zeroCount++;
        //             }
        //
        //             if (s[j] == '1')
        //             {
        //                 oneCount++;
        //             }
        //         }
        //         else
        //         {
        //             if (s[j] == '0')
        //             {
        //                 isChange = true;
        //                 oneCount--;
        //             }
        //
        //             if (s[j] == '1')
        //             {
        //                 isChange = true;
        //                 zeroCount--;
        //             }
        //         }
        //         
        //         if (zeroCount == oneCount)
        //         {
        //             count++;
        //             break;
        //         }
        //     }
        // }
        //
        // return count;
    }
}