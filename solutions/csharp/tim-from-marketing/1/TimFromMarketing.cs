static class Badge{
    public static string Print(int? Id, string Name, string? Department){
        string IdString, DepartmentFinal;
        IdString = Id == null ? "" : "[" + Id + "] - ";
        DepartmentFinal = Department == null ? " - OWNER" : $" - {Department.ToUpper()}";
        return $"{IdString}{Name}{DepartmentFinal}";
    }
}