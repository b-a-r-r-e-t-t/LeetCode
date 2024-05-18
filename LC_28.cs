using System.ComponentModel;

namespace LeetCode;

public class LC_28
{
    public int StrStr_Original(string haystack, string needle){
        return haystack.IndexOf(needle);
    }


    public int StrStr(string haystack, string needle){
        if (haystack.Length < needle.Length) { return -1; }
        int comp = 0;
        int i = 0;
        for(; i < haystack.Length; i++){
            if(needle.Length > haystack.Length - i) { return -1; }
            if(comp <= needle.Length - 1 && haystack[i] == needle[comp]) { 
                do{
                    if(comp == needle.Length - 1) { return i; }
                } while(needle[++comp] == haystack[i+comp]);
            }

            comp = 0;
        }
        return -1;
    }
}
