public static class Acronym {
    public static string Abbreviate(string phrase) {
        char[] characters_to_split = [' ', '-', '_'];
        string acronym ="";
        string[] phrase_split = phrase.Split(characters_to_split);

        for (int i = 0; i < phrase_split.Length; i++) {
            foreach (char first_letter in phrase_split[i]) {
                acronym = acronym + first_letter;
                break;
            }
        }
        return acronym.ToUpper();
    }
}