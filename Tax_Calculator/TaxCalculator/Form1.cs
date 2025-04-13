namespace TaxCalculator;

public partial class Form1 : Form
{
    private List<Produkt> products;
    
    public Form1()
    {
        InitializeComponent();
        products = new List<Produkt>();
    }

    public void CalculateButton_Click(Object s, EventArgs e)
    {
        resultsBox.Clear();
        
        if (!double.TryParse(vatValueSADText.Text.Trim(), out double vatTotal) || vatTotal <= 0)
        {
            MessageBox.Show("Wprowadź poprawną kwotę VAT (> 0).");
            return;
        }

        if (products.Count == 0)
        {
            MessageBox.Show("Dodaj przynajmniej jeden produkt.");
            return;
        }

        int totalPieces = products.Sum(p => p.Pieces);
        
        const double VAT_RATE = 0.23;
        
        int piecesSum = 0;
        foreach (var product in products)
        {
            piecesSum += product.Pieces;
        }
        
        foreach (var product in products)
        {
            double proportion = (double)product.Pieces / piecesSum;
            product.Tax = Math.Round(int.Parse(vatValueSADText.Text) * proportion, 2);
        }
        
        double nettoSum = 0;
        double vatSum = 0;
        
        Console.WriteLine("Wyniki: ");
        
        foreach (var product in products)
        {
            double nettoPrice = product.Tax / VAT_RATE;
            double onePiecePrice = nettoPrice / product.Pieces;
        
            double mainPrice = Math.Floor(onePiecePrice * 100) / 100;
        
            int mainPieces = product.Pieces - 1;
        
            double rest = nettoPrice - (mainPieces * mainPrice);
            double priceLastPiece = Math.Round(rest, 2);
            
            double sumCheck = mainPieces * mainPrice + priceLastPiece;
            nettoSum += sumCheck;
            vatSum += product.Tax;
            
            
            resultsBox.AppendText($"Produkt: {product.Name}\n");
            resultsBox.AppendText($"Sztuki: {product.Pieces} sztuk\n");
            resultsBox.AppendText($"VAT: {product.Tax} PLN\n");
            resultsBox.AppendText($"Netto overall: {nettoPrice:F2} PLN\n");
            resultsBox.AppendText($"Cena jednostkowa dokładna: {onePiecePrice:F6} PLN\n");
            resultsBox.AppendText($"Cena główna: {mainPrice:F2} PLN\n");
            resultsBox.AppendText(" - Podział w PZ:\n");
            resultsBox.AppendText($"  - {mainPieces} sztuk po {mainPrice:F2} PLN\n");
            resultsBox.AppendText($"  - 1 sztuka po {priceLastPiece:F2} PLN\n");
            resultsBox.AppendText($"Suma: {sumCheck:F2} PLN\n");
            resultsBox.AppendText("\n");
        }
        resultsBox.AppendText("\n======================================================\n");
        resultsBox.AppendText($"Łączna suma NETTO: {nettoSum:F2} PLN\n");
        resultsBox.AppendText($"Łączna suma VAT: {vatSum:F2} PLN\n");
    }

    public void AddProductButton_Click(object s, EventArgs e)
    {
        string productNameInput = productName.Text.Trim();

        if (!int.TryParse(numberOfPiecesText.Text.Trim(), out int pieces) || pieces <= 0 || string.IsNullOrEmpty(productNameInput))
        {
            MessageBox.Show("Wprowadź poprawną nazwę produktu i ilość sztuk (> 0).");
            return;
        }

        products.Add(new Produkt { Name = productNameInput, Pieces = pieces });

        productsListBox.Items.Add($"{productNameInput} - {pieces} sztuk");

        numberOfPiecesText.Clear();
        productName.Clear();
    }

}