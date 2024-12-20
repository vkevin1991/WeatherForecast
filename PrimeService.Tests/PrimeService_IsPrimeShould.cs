using Prime.Services;

namespace Prime.UnitTests.Services
{
  public class PrimeService_IsPrimeShould
  {
    [Fact]
    public void IsPrime_InputIs1_ReturnFalse()
    {
      var primeService = new PrimeService();
      bool result = primeService.IsPrime(1);

      Assert.False(result, "1 should not be prime");
    }

    [Fact]
    public void ShouldBeAbleToDivide()
    {
      var primeService = new PrimeService();
      int result = primeService.Divide(2, 2);
      Assert.Equal(1, result);
    }
  }
}
