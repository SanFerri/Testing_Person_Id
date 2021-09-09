using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Person person = new Person("Santiago Ferraro", "5.307.722-8");
        }
        [Test]
        public void TestRealId() // Probamos con una ID real que es la de arriba si efectivamente sirvio.
        {
            Person person = new Person("Santiago Ferraro", "5.307.722-8");
            const string expected = "5.307.722-8";
            Assert.AreEqual(expected, person.ID);
        }
        [Test]
        public void TestIdUtils_Length() // Verificamos que el isvalid funcione para verificar el largo de un Id. 
        {
            Person person = new Person("Santiago Ferraro", "5.307.722-8");
            const string expected = "5.307.722-8";
            person.ID = "5.07.722-8";
            Assert.AreEqual(expected, person.ID); // Si sirvio el person.ID deberia mantenerse ya que el que se intento poner deberia ser invalido
        }
        [Test]
        public void TestIdUtils_CheckDigit() // Verificamos que el isvalid funcione para verificar el numero verificador.
        {
            Person person = new Person("Santiago Ferraro", "5.307.722-8");
            const string expected = "5.307.722-8";
            person.ID = "5.307.722-4";
            Assert.AreEqual(expected, person.ID); // Si sirvio el person.ID deberia mantenerse ya que el que se intento poner deberia ser invalido
        }
    }
}
