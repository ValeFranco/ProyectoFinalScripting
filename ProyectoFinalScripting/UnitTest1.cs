using NUnit.Framework;
using static ProyectoFinalScripting.TorreJugador;
using static ProyectoFinalScripting.Jugador;
using System.Collections.Generic;

namespace ProyectoFinalScripting
{
    public class Tests
    {
        private Juego juego = new Juego();
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

            Assert.AreEqual(listaJugadorTest, torreTest.listaJugador); 
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
        public void GanaContraObstaculo()
        {
            Jugador jugador4 = new Jugador(15, "Pruebita");
            TorreJugador torreJugador = new TorreJugador(3, jugador4);

            Atacable obstaculo = new Atacable(true, 3);
            TorreEnemigo torreEnemigo = new TorreEnemigo(4, obstaculo);

            torreJugador.Atacar(obstaculo, torreEnemigo);

            Assert.AreEqual(18, torreJugador.Jugador.poder);
        }

        [Test]
        public void UltimaTorreEnemigo()
        {
            List<Torre> torreEsperada = new List<Torre>(0);
            Atacable atacable = new Atacable(false, 2);

            Jugador jugador = new Jugador(5, "Juan");
            TorreJugador torreJugador = new TorreJugador(3, jugador);

            TorreEnemigo torreEnemigo = new TorreEnemigo(1, atacable);

            torreJugador.Atacar(atacable, torreEnemigo);

            juego.LimpiarLista();

            Assert.AreEqual(torreEsperada, juego.listaTorres);
        }

        [Test]
        public void PierdeVida()
        {
            bool falso = false;

            Jugador jugador2 = new Jugador(15, "Pruebita");
            TorreJugador torreJugador = new TorreJugador(3, jugador2);

            Atacable derrota = new Atacable(falso, 33);
            TorreEnemigo torreEnemigo = new TorreEnemigo(4, derrota);

            torreJugador.Atacar(derrota, torreEnemigo);

            Assert.AreEqual(2, torreJugador.Jugador.vidas);
        }

        [Test]
        public void GanaSiEsMayorPierdeSiHayEmpate()
        {
            bool falso = false;
            
            Jugador jugador = new Jugador(15, "Pruebita");
            Atacable empate = new Atacable(falso, 18);
            Atacable victoria = new Atacable(falso, 3);
            Atacable derrota = new Atacable(falso, 33);

            //Assert.IsFalse(jugador.Atacar(derrota));
            //Assert.IsTrue(jugador.Atacar(victoria));
            //Assert.IsFalse(jugador.Atacar(empate));  
        }

        [Test]

        public void AumentaPoderPersonaje()
        {
            Jugador jugador4 = new Jugador(15, "Pruebita");
            TorreJugador torreJugador = new TorreJugador(3, jugador4);

            Atacable victoria = new Atacable(false, 3);
            TorreEnemigo torreEnemigo = new TorreEnemigo(4, victoria);

            torreJugador.Atacar(victoria, torreEnemigo);

            Assert.AreEqual(18, torreJugador.Jugador.poder);
        }

        [Test]
        public void TestLimpiarLista()
        {
            List<Torre> torreEsperada = new List<Torre>(0);
            Atacable atacable = new Atacable(false, 2);

            Jugador jugador = new Jugador(5, "Juan");
            TorreJugador torreJugador = new TorreJugador(3, jugador);

            TorreEnemigo torreEnemigo = new TorreEnemigo(1, atacable);

            torreJugador.Atacar(atacable, torreEnemigo);

            juego.LimpiarLista();

            Assert.AreEqual(torreEsperada, juego.listaTorres);
        }

        [Test]
        public void TestCombate()
        {
            Juego juego = new Juego();
            
            List<Torre> torres = new List<Torre>(2);

            Atacable atacable1 = new Atacable(false, 2);
            Atacable atacable2 = new Atacable(false, 3);
            Atacable atacable3 = new Atacable(false, 1);
            Atacable atacable4 = new Atacable(false, 4);

            TorreEnemigo torreEnemigo1 = new TorreEnemigo(2, atacable1);
            TorreEnemigo torreEnemigo2 = new TorreEnemigo(2, atacable2);

            torreEnemigo1.listaAtacable.Add(atacable3);
            torreEnemigo2.listaAtacable.Add(atacable4);

            Jugador jugador = new Jugador(6, "Valentina");
            TorreJugador torreJugador = new TorreJugador(3, jugador);
            juego.torreJugador = torreJugador;

            juego.listaTorres.Add(torreEnemigo1);
            juego.listaTorres.Add(torreEnemigo2);
        
            torreJugador.Atacar(atacable1, torreEnemigo1);
            torreJugador.Atacar(atacable3, torreEnemigo1);

            juego.LimpiarLista();

            torreJugador.Atacar(atacable2, torreEnemigo2);
            torreJugador.Atacar(atacable4, torreEnemigo2);

            string mensaje = juego.LimpiarLista();
            Assert.AreEqual("Pasaste de nivel", mensaje);
        }
    }
}