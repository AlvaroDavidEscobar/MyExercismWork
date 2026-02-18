public static class PlayAnalyzer {
    public static string AnalyzeOnField(int shirt_number) {
        switch (shirt_number) {
            case 1: return "goalie";
            case 2: return "left back";
            case 3: return "center back";
            case 4: return "center back";
            case 5: return "right back";
            case 6: return "midfielder";
            case 7: return "midfielder";
            case 8: return "midfielder";
            case 9: return "left wing";
            case 10: return "striker";
            case 11: return "right wing";
        }
        return "UNKNOWN";
    }

    public static string AnalyzeOffField(object report) => report switch {
            int i => $"There are {i} supporters at the match.",
            string i => i,
            Foul i => i.GetDescription(),
            Injury i => $"Oh no! {i.GetDescription()} Medics are on the field.",
            Incident i => i.GetDescription(),
            Manager i => i.Club == null ? i.Name : $"{i.Name} ({i.Club})",
            _ => ""
        };
}
