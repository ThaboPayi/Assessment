using System.Web.UI;

namespace Assessment.CoinAssessment
{
    public interface ICoinJar : ICoin
    {
        void AddCoin(ICoin coin);
        decimal TotalAmount { get; }
        void Reset();
    }
}
