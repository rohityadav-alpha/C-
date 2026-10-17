namespace StudentPortal.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string name { get; set; } = string.Empty;
        public int age { get; set; }
        public int marks { get; set; }

        public bool IsPass()
        {
            return marks >= 35;
        }
    }
}
