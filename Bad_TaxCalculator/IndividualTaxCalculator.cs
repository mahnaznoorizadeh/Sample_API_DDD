namespace Bad_TaxCalculator;


public interface ITaxRule
{
    public int CalculateTaxPercentage(TaxPayer taxPayer, int currentTax);

}

public class IndividualTaxCalculator
{
    public int CalculateTaxPercentage(TaxPayer taxPayer)
    {
        if (!taxPayer.TaxCitizen)
            throw new InvalidOperationException("You are not tax citizen");
        
        return 0;
    }
}
