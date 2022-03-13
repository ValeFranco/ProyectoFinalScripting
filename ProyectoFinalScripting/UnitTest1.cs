using NUnit.Framework;

namespace ProyectoFinalScripting
{
    public class Tests
    {
        
        
        private TorreJugador? Test1torreJugador;
        private TorreEnemigo? Test1torreEnemigo;
        Jugador Test1Jugador = new Jugador(15, "carlos");
        uint Test1Altura;

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
        public void CrearTorreJugador()
        {
           // Assert.IsTrue(new TorreJugador(3,Test1Jugador)==);
            
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
            Atacable empate = new Atacable(falso, 18);
            Atacable victoria = new Atacable(falso, 3);
            Atacable derrota = new Atacable(falso, 33);

            Assert.IsFalse(jugador.Atacar(derrota));
            Assert.IsTrue(jugador.Atacar(victoria));
            Assert.IsFalse(jugador.Atacar(empate));
            

            


        }

    }
}