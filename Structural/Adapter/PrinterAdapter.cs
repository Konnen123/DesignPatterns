namespace DesignPatterns.Structural;

public class PrinterAdapter : IPrinter
{
    private readonly LegacyPrinter legacyPrinter;

    public PrinterAdapter(LegacyPrinter legacyPrinter)
    {
        this.legacyPrinter = legacyPrinter;
    }

    public void Print()
    {
        legacyPrinter.PrintDocument();
    }
}