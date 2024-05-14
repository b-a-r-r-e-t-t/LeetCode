using System.Text.RegularExpressions;

namespace LeetCode;

public class LC_58
{
    public int LengthOfLastWord_Old(string s){
        int length = 0;
        char[] chars = s.Trim().ToCharArray();
        while(length < chars.Length) {
            if(!Char.IsWhiteSpace(chars[chars.Length - 1 - length])){ 
                length++;
            } else {
                break;
            }
        }
        return length;
    }

    public int LengthOfLastWord(string s){
        int length = 0;
        int skip = 0;
        while(length < s.Length) {
            if(length == skip && Char.IsWhiteSpace(s[s.Length - 1 - length])){ 
                skip++; length++;
                continue;
            } else if(!Char.IsWhiteSpace(s[s.Length - 1 - length])){ 
                length++;
            } else {
                break;
            }
        }
        return length - skip;
    }
    public int LengthOfLastWord_Regex(string s){
        Match match = Regex.Match(s, @"\b\w+\b(?=\W*$)");
        return match.Length;
        //\b\w+\b(?=\W*$)

    }
}

