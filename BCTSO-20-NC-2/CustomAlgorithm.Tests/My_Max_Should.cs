namespace CustomAlgorithm.Tests
{
    public class My_Max_Should
    {
        [Fact]
        public void Find_Max_Value_Element()
        {
            List<int> intList = new() { 1, 2, 3 };
            var expected = 3;

            var actual = intList.MyMax();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Find_Max_Reference_Element()
        {
            //Arrange - მომზადება
            List<Student> students = new()
            {
                new Student("Giorgi",22),
                new Student("Daviti",19),
                new Student("Ana",20)
            };

            var expected = new Student("Giorgi", 22);

            var actual = students.MyMax();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
