using System.Text;

public static class Identifier {
    public static string Clean(string identifier) {
        StringBuilder sb = new StringBuilder(identifier);
        for (int i = sb.Length - 1; i >= 0; i--) {
            if (Char.IsWhiteSpace(sb[i])) {
                sb.Replace(sb[i], '_');
            } else if (Char.IsControl(sb[i])) {
                sb.Remove(i, 1);
                sb.Insert(i, "CTRL");
            } else if (sb[i] == '-') {
                sb.Insert(i + 1, Char.ToUpper(sb[i + 1]));
                sb.Remove(i + 2, 1);
                sb.Remove(i, 1);
            } else if (!Char.IsLetter(sb[i]) && sb[i] != '_') {
                sb.Remove(i, 1);
            } else if (sb[i] >= 'α' && sb[i] <= 'ω') {
                sb.Remove(i, 1);
            }
        }
        return sb.ToString();
    }
}
