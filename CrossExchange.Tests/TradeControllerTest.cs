
using System;
using System.Threading.Tasks;
using CrossExchange.Controller;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Moq;

namespace CrossExchange.Tests
{
    public class TradeControllerTests
    {
        private readonly ITradeRepository _tradeRepositoryMock = new TradeRepository();
        private readonly Mock<IPortfolioRepository> _portfolioRepositoryMock = new Mock<IPortfolioRepository>();
        private readonly Mock<IShareRepository> _shareRepositoryMock = new Mock<IShareRepository>();

        private readonly TradeController _tradeController;

        public TradeControllerTests()
        {
            _tradeController = new TradeController(_shareRepositoryMock.Object, _tradeRepositoryMock.Object, _portfolioRepositoryMock.Object);
        }

        [Test]
        public  void get_latestRate()
        {
            string Symbol = "CBI";

            var result = _tradeController.GetCurrentRate(Symbol);

           

            // Assert
            Assert.NotNull(result);
          
        }
        
    }
}
