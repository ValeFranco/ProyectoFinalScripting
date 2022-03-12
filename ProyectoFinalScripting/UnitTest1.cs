using NUnit.Framework;

namespace ProyectoFinalScripting
{
    public class Tests
    {
        
        
        private TorreJugador? Test1torreJugador;
        private TorreEnemigo? Test1torreEnemigo;
        Jugador Test1Jugador = new Jugador();
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
    }
}