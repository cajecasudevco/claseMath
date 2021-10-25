using NUnit.Framework;
using claseMath;
using System.Linq;

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
        public void Add_Obtener_el_Valor_Mayor(int a, int b, int valoresperado)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(valoresperado));
            //Assert.AreEqual(result, 4);
        }

        [TestCase(1, 1, 7)]
        public void Add_Obtener_el_Valor_Mayor_1(int a, int b, int valoresperado)
        {
            var result = _math.Max(a, b);

            Assert.That(result + 6, Is.EqualTo(valoresperado));
            //Assert.AreEqual(result, 4);
        }

        [Test]
        public void GetOddNumbers_Lista_No_Nula()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.Not.Empty);        

            //Assert.That(result + 6, Is.EqualTo(valoresperado));
            //Assert.AreEqual(result, 4);
        }

        [Test]
        public void GetOddNumbers_Cantidad_de_Elementos()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result.Count(), Is.EqualTo(3));
        }


        [Test]
        public void GetOddNumbers_Contenga_En_Base_Al_limite_Los_Impares()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);

        }
    }
}
