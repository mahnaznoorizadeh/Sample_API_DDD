namespace Bad_TaxCalculator;
public class IndividualTaxCalculator
{
    public int CalculateTaxPercentage(TaxPayer taxPayer)
    {
        if (!taxPayer.TaxCitizen)
            throw new InvalidOperationException("You are not tax citizen");
        
        return 0;
    }
}
