using NUnit.Framework;
using static ProyectoFinalScripting.TorreJugador;
using static ProyectoFinalScripting.Jugador;
using System.Collections.Generic;

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
        public void TestTorreContineJugador()
        {

            Jugador jugador = new Jugador(5, "Sebastian");
            uint altura = 3;
            TorreJugador torreTest = new TorreJugador(altura, jugador);
            List<Jugador> listaJugadorTest = new List<Jugador>(3);
            listaJugadorTest.Add(jugador);

            Assert.AreEqual(listaJugadorTest, torreTest.l_jugador);
            
        }
        [Test]
        public void TestTorreTieneNiveles()
        {
            TorreJugador testTorreJugador;
            var exception = Assert.Throws<System.Exception>(() => testTorreJugador = new TorreJugador(0, Test1Jugador));
            Assert.AreEqual("La altura de la torre no puede ser cero", exception.Message);
        }

        [Test]
        public void TestJugador()
        {
            Jugador testJugador;
            var exception = Assert.Throws<System.Exception>(() => testJugador = new Jugador(0, "carlos"));
            Assert.AreEqual("el poder inicial del usuario no puede ser cero", exception.Message);

        }

        [Test]
        public void TorreJugador()
        {

        }

          [Test]
        public void TorreEnemigo()
        {

        }

        [Test]
        public void Gana_SiEsMayor_Pierde_SiHayEmpate()
        {
            bool falso = false;
            
            Jugador jugador = new Jugador(15, "Pruebita");
            Atacable empate = new Atacable(falso, 18);
            Atacable victoria = new Atacable(falso, 3);
            Atacable derrota = new Atacable(falso, 33);

            Assert.IsFalse(jugador.Atacar(derrota));
            Assert.IsTrue(jugador.Atacar(victoria));
            Assert.IsFalse(jugador.Atacar(empate));
            
        }

    }
}