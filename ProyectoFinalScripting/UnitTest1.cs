using NUnit.Framework;
using static ProyectoFinalScripting.TorreJugador;

namespace ProyectoFinalScripting
{
    public class Tests
    {

        private TorreJugador Test1torreJugador;
        private TorreEnemigo Test1torreEnemigo;
        uint Test1Altura = 5;
        Jugador Test1Jugador = new Jugador(3, "nombre");

        [SetUp]
        public void Setup()
        {
            Test1torreJugador = new TorreJugador(Test1Altura, Test1Jugador);
        }

        [TearDown]
        public void TearDown()
        {
            Test1torreJugador = null;
        }

        [Test]
        public void TestCrearTorreJugador()
        {
            // Assert.IsTrue(new TorreJugador(3,Test1Jugador)==);

            Jugador jugador = new Jugador(5, "Sebastian");
            uint altura = 3;

            Assert.IsTrue(new TorreJugador(altura, jugador) == CrearTorreJugador(Test1torreJugador));
            Assert.AreEqual(new TorreJugador(1, jugador), CrearTorreJugador(Test1torreJugador));

        }

        [Test]
        public void TestJugador()
        {
            Jugador testJugador;
            var exception = Assert.Throws<System.Exception>(() => testJugador = new Jugador(0, "carlos"));
            Assert.AreEqual("el poder inicial del usuario no puede ser cero", exception.Message);

        }

        [Test]
        public void Gana_SiEsMayor_Pierde_SiHayEmpate()
        {
            bool falso = false;
            
            Jugador jugador = new Jugador(15, "Pruebita");
            Atacable empate = new Atacable(falso, 15);
            Atacable victoria = new Atacable(falso, 3);
            Atacable derrota = new Atacable(falso, 33);

            Assert.IsFalse(jugador.Atacar(derrota));
            Assert.IsTrue(jugador.Atacar(victoria));
            Assert.IsFalse(jugador.Atacar(empate));
            
        }

    }
}