namespace DesignPatterns.Structural;

public class AdapterDemo
{
    public AdapterDemo()
    {
        LegacyPrinter legacyPrinter = new LegacyPrinter();
        PrinterAdapter printerAdapter = new PrinterAdapter(legacyPrinter);
        printerAdapter.Print();
    }

}