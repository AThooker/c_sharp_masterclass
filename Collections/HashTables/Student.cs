namespace HashTables
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(int id, string name, float gPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gPA;
        }
    }
}
