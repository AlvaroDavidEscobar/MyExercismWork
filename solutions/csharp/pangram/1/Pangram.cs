public static class Pangram {
    public static bool IsPangram(string input) {
        bool[] english_letters_present = new bool[26];
        int index, letter_count = 0;
        input = input.ToLower();
        foreach (char Character in input) {
            if (Char.IsLetter(Character)) {
                index = Character - 'a';
                if (!english_letters_present[index]) {
                    english_letters_present[index] =  true;
                    letter_count++;
                }
            }
        }
        return letter_count == 26;
    }
}
