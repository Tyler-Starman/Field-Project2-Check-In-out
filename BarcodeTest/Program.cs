using System;
using IronBarCode;
namespace BarcodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BarcodeResult barcodeResult = BarcodeReader.QuicklyReadOneBarcode("Barcode.png");
            Console.WriteLine(barcodeResult.Text);
        }
    }
}
