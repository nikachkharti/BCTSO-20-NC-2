namespace CustomAlgorithm.Tests
{
    public class My_Distinct_Should
    {
        [Fact]
        public void Find_Unique_Value_Elements()
        {
            List<int> intList = new() { 1, 2, 3, 1, 2 };
            List<int> expected = new() { 1, 2, 3 };

            var actual = intList.MyDistinct();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Find_Unique_Reference_Elements()
        {
            List<Student> students = new()
            {
                new Student("Giorgi",22),
                new Student("Daviti",19),
                new Student("Daviti",19),
                new Student("Ana",20),
                new Student("Ana",20)
            };

            var expected = new List<Student>()
            {
                new Student("Giorgi",22),
                new Student("Daviti",19),
                new Student("Ana",20)
            };

            var actual = students.MyDistinct();

            Assert.Equal(expected, actual);

        }
    }
}
