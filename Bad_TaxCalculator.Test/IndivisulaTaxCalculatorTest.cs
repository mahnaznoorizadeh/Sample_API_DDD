using System;
using Xunit;

namespace Bad_TaxCalculator.Test
{
    public class IndivisulaTaxCalculatorTest
    {
        [Fact]
        public void None_Residence_SHOULD_NOT_BE_CONSIDER_TO_PAY_TAX()
        {
            //Arrange
            var taxPayer = new TaxPayer()
            {
                TaxCitizen = false
            };
            IndividualTaxCalculator individualTaxCalculator = new IndividualTaxCalculator();

            //Act
            var exp_message = "You are not tax citizen";
            var result = Assert.Throws< InvalidOperationException>(() => 
                individualTaxCalculator.CalculateTaxPercentage(taxPayer));


            //Assert
            Assert.Equal(exp_message, result.Message);

        }
    }
}