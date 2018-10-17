namespace DataStructures
{
    public struct Teacher
    {
        public string Name { get; }

        public string Department { get; }

        public Teacher(string name, string department)
        {
            Name = name;
            Department = department;
        }
    }
}
