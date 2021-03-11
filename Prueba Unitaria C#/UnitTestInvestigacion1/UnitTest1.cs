using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestInvestigacion1
{
    [TestClass]
    public class UnitTest1
    {
 
        [TestMethod]
        public void TestLoginTrue()
        {
            //Este test es para el flujo de cuando es correcta el ingreso del User y el Password
            //Pasamos los Valores de Prueba para el Test
            bool result = Investigacion1.Program.Login("azofeifa", "123456");
            //Comparamos lo que tendriamos que recibir si la Verificacion fue correcta 
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestLoginFalse()
        {
            //Este test es para el flujo de cuando es incorrecto el ingreso del User y el Password
            //Pasamos los Valores de Prueba para el Test
            bool result = Investigacion1.Program.Login("der", "1234");
            //Comparamos lo que tendriamos que recibir si la Verificacion fue correcta 
            Assert.AreEqual(false, result);
        }
    }
}
