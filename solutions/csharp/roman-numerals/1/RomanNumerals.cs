public static class RomanNumeralExtension {
    public static string ToRoman(this int value) {
        string roman_number = "";
        while (value > 0) {
            if (value - 1000 >= 0) {
                value -= 1000;
                roman_number += "M";
            }
            else if (value - 900 >= 0)
            {
                value -= 900;
                roman_number += "CM";
            }
            else if (value - 500 >= 0)
            {
                value -= 500;
                roman_number += "D";
            }
            else if (value - 400 >= 0)
            {
                value -= 400;
                roman_number += "CD";
            }
            else if (value - 100 >= 0)
            {
                value -= 100;
                roman_number += "C";
            }
            else if (value - 90 >= 0)
            {
                value -= 90;
                roman_number += "XC";
            }
            else if (value - 50 >= 0)
            {
                value -= 50;
                roman_number += "L";
            }
            else if (value - 40 >= 0)
            {
                value -= 40;
                roman_number += "XL";
            }
            else if (value - 10 >= 0)
            {
                value -= 10;
                roman_number += "X";
            }
            else if (value - 9 >= 0)
            {
                value -= 9;
                roman_number += "IX";
            }
            else if (value - 5 >= 0)
            {
                value -= 5;
                roman_number += "V";
            }
            else if (value - 4 >= 0)
            {
                value -= 4;
                roman_number += "IV";
            }
            else if (value - 1 >= 0)
            {
                value -= 1;
                roman_number += "I";
            }
        }
        return roman_number;
    }
}