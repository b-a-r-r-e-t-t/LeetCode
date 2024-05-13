namespace LeetCode;

public class LC_13
{
    /*
        I can be placed before V (5) and X (10) to make 4 and 9. 
        X can be placed before L (50) and C (100) to make 40 and 90. 
        C can be placed before D (500) and M (1000) to make 400 and 900.
    */
    Dictionary<char, int> Numerals = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };

    public int RomanToInt(string s){
        char[] numerals = s.ToCharArray();

        int _return = 0;

        for(int i = 0; i < numerals.Length; i++) {
            
            char numeral = numerals[i];
            char next = '\0';

            if(i != numerals.Length - 1){
                next = numerals[i+1]; 
            }

            var x = (numeral, next) switch {
                { numeral: 'I', next: 'V' or 'X' } => -1,
                { numeral: 'X', next: 'L' or 'C' } => -10,
                { numeral: 'C', next: 'D' or 'M' } => -100,
                _ => Numerals[numeral]
            };

            _return += x;
        }
        return _return;
    }
}
