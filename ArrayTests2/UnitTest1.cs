using Xunit;

namespace ArrayTests2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ArrayExamples examples = new ArrayExamples();
            int[] results = new int[10];
            examples.Array1((i, n) => results[i] = n);

            Assert.Equal(10, results[0]);
            Assert.Equal(9, results[1]);
            Assert.Equal(8, results[2]);
            Assert.Equal(7, results[3]);
            Assert.Equal(6, results[4]);
        }

        [Fact]
        public void Concatenare_Test1()
        {
            string[] prenume = new string[1];
            string[] nume = new string[1];

            prenume[0] = "Ghita";
            nume[0] = "Muresan";

            ArrayExamples examples = new ArrayExamples();
            string[] rezultate = examples.ConcatenareNume(prenume, nume);

            Assert.Equal(1, rezultate.Length);
            Assert.Equal("Ghita Muresan", rezultate[0]);
        }

        [Fact]
        public void Concatenare_Test2()
        {
            string[] prenume = new string[2];
            string[] nume = new string[1];

            prenume[0] = "Ghita";
            prenume[1] = "Marcel";
            nume[0] = "Muresan";

            ArrayExamples examples = new ArrayExamples();
            string[] rezultate = examples.ConcatenareNume(prenume, nume);

            Assert.Equal(0, rezultate.Length);
        }

        [Fact]
        public void Concatenare_Test3()
        {
            string[] prenume = new string[1];
            string[] nume = new string[2];

            prenume[0] = "Ghita";
            nume[0] = "Muresan";
            nume[1] = "Popa";

            ArrayExamples examples = new ArrayExamples();
            string[] rezultate = examples.ConcatenareNume(prenume, nume);

            Assert.Equal(0, rezultate.Length);
        }
    }
}