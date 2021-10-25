using NUnit.Framework;
using claseMath;

namespace claseMath.Test
{
    public class Tests
    {
        private claseMath _math;

        [OneTimeSetUp]

        [SetUp]
        public void Setup()
        {
            //lo que valla aqui
            _math = new claseMath();
           

        }

        [Test]
        public void Suma_Dos_Argumentos()
        {
            var result = _math.Add(1, 2);
            //Assert.AreEqual(result,3);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Suma_Dos_Argumentos_1()
        {
            var result = _math.Add(2, 2);

            Assert.That(result, Is.EqualTo(4));
            //Assert.AreEqual(result, 4);
        }


        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(1,1,1)]        
        public void Obtener_el_Valor_Mayor(int a, int b, int valoresperado)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(valoresperado));
            //Assert.AreEqual(result, 4);
        }

        [TestCase(1, 1, 7)]
        public void Obtener_el_Valor_Mayor_1(int a, int b, int valoresperado)
        {
            var result = _math.Max(a, b);

            Assert.That(result + 6, Is.EqualTo(valoresperado));
            //Assert.AreEqual(result, 4);
        }


        [Test]
        public void Resta_Dos_Argumentos()
        {
            var result = _math.Subtract(4, 2);
            

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Resta_Dos_Argumentos_1()
        {
            var result = _math.Subtract(2, 2);

            Assert.That(result, Is.EqualTo(0));
            
        }

        [Test]
        [TestCase(1, 2, -1)]
        [TestCase(2, 1, 1)]
        [TestCase(7, 4, 3)]
        public void Resta_Dos_Argumentos_1(int a, int b, int valoresperado)
        {
            var result = _math.Subtract(a, b);

            Assert.That(result, Is.EqualTo(valoresperado));

        }

    }
}
