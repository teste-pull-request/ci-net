using TesteCI.Lib;

namespace TesteCI.Teste;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int a = 10;
        int b = 10;
        OperacoesMath operacoes = new OperacoesMath();
        int res = operacoes.Soma(a,b);
        Assert.AreEqual(20, res);
    }
}