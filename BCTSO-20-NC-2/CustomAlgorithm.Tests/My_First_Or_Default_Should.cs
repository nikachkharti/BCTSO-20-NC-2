using System.Diagnostics.CodeAnalysis;

namespace CustomAlgorithm.Tests
{
    public class My_First_Or_Default_Should
    {
        [Fact]
        public void Find_First_Value_Element()
        {
            //Arrange - მომზადება
            List<int> testData = new() { 1, -2, 3 };
            var expected = -2;

            //Act
            var actual = testData.MyFirstOrDefault(x => x < 0);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Throw_ArgumentNullException_If_Predicate_Is_Null()
        {
            //Arrange
            List<int> testData = new() { 1, -2, 3 };

            //Assert Act
            Assert.Throws<ArgumentNullException>(() => testData.MyFirstOrDefault(null));
        }

        [Fact]
        public void Find_First_Reference_Element()
        {
            //Arrange - მომზადება
            List<Student> students = new()
            {
                new Student("Giorgi",22),
                new Student("Daviti",19),
                new Student("Ana",20)
            };

            Student expected = new Student("Ana", 20);

            //Act
            var actual = students.MyFirstOrDefault(x => x.Name.EndsWith('a'));

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
