public static class Acronym {
    public static string Abbreviate(string phrase) {
        char[] characters_to_split = [' ', '-', '_'];
        string acronym ="";
        string[] phrase_split = phrase.Split(characters_to_split);

        for (int i = 0; i < phrase_split.Length; i++) {
            if (phrase_split[i] != "") acronym = acronym + phrase_split[i][0];
        }
        return acronym.ToUpper();
    }
}