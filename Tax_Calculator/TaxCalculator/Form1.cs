namespace TaxCalculator;

public partial class Form1 : Form
{
    private List<Produkt> _products;
    
    public Form1()
    {
        InitializeComponent();
        _products = new List<Produkt>();
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        resultsBox.Clear();

        if (!double.TryParse(vatValueSADText.Text.Trim(), out var vatTotal) || vatTotal <= 0)
        {
            MessageBox.Show("Wprowadź poprawną kwotę VAT (> 0).");
            return;
        }

        if (_products.Count == 0)
        {
            MessageBox.Show("Dodaj przynajmniej jeden produkt.");
            return;
        }

        
        int totalPieces = _products.Sum(p => p.Pieces);

        
        double vatSoFar = 0;
        double vatSum = 0;

        for (int i = 0; i < _products.Count; i++)
        {
            var proportion = (double)_products[i].Pieces / totalPieces;

            if (i < _products.Count - 1)
            {
                _products[i].Tax = Math.Round(vatTotal * proportion, 2);
                vatSoFar += _products[i].Tax;
                vatSum += vatSoFar;
            }
            else
            {
                _products[i].Tax = Math.Round(vatTotal - vatSoFar, 2);
            }
        }
        
        double nettoSoFar = 0;

        for (int i = 0; i < _products.Count; i++)
        {
            var product = _products[i];
            double netto = product.Tax / 0.23;
            double unitExact = netto / product.Pieces;

            double mainPrice = Math.Floor(unitExact * 100) / 100;
            double fullMainValue = mainPrice * product.Pieces;

            double lastPiecePrice = mainPrice;
            int piecesWithMainPrice = product.Pieces;

            
            if (i == _products.Count - 1)
            {
                const double vatRate = 0.23;
                double nettoExpected = Math.Ceiling((vatTotal / vatRate) * 100) / 100;

                double correction = Math.Round(nettoExpected - (nettoSoFar + fullMainValue), 2);

                if (Math.Abs(correction) > 0.005)
                {
                    lastPiecePrice = mainPrice + correction;
                    piecesWithMainPrice = product.Pieces - 1;
                }
            }

            double sumFinal = piecesWithMainPrice * mainPrice + (product.Pieces - piecesWithMainPrice) * lastPiecePrice;
            nettoSoFar += sumFinal;
            
            
            resultsBox.AppendText($"{product.Name}\n");
            resultsBox.AppendText($"  Sztuk: {product.Pieces}\n");
            resultsBox.AppendText($"  VAT: {product.Tax:F2} PLN\n");
            resultsBox.AppendText($"  Netto: {netto:F2} PLN\n");
            resultsBox.AppendText($"  Cena jednostkowa dokładna: {unitExact:F6} PLN\n");
            resultsBox.AppendText($"  Główna cena: {mainPrice:F2} PLN\n");
            resultsBox.AppendText($"  Podział:\n");
            resultsBox.AppendText($"    {piecesWithMainPrice} szt. po {mainPrice:F2} PLN\n");

            if (product.Pieces != piecesWithMainPrice)
            {
                resultsBox.AppendText($"    1 szt. po {lastPiecePrice:F2} PLN\n");
            }

            resultsBox.AppendText($"  Suma netto: {sumFinal:F2} PLN\n\n");
        }
        double vatFinal = nettoSoFar * 0.23;

        resultsBox.AppendText("====================================\n");
        resultsBox.AppendText($"Łączna suma NETTO: {nettoSoFar:F2} PLN\n");
        resultsBox.AppendText($"Łączna suma VAT: {vatFinal:F4} PLN\n");
    }


    private void AddProductButton_Click(object s, EventArgs e)
    {
        string productNameInput = productName.Text.Trim();

        if (!int.TryParse(numberOfPiecesText.Text.Trim(), out int pieces) || pieces <= 0 || string.IsNullOrEmpty(productNameInput))
        {
            MessageBox.Show("Wprowadź poprawną nazwę produktu i ilość sztuk (> 0).");
            return;
        }

        _products.Add(new Produkt { Name = productNameInput, Pieces = pieces });

        productsListBox.Items.Add($"{productNameInput} - {pieces} sztuk");

        numberOfPiecesText.Clear();
        productName.Clear();
    }

    public void DeleteProductButton_Click(object s, EventArgs e)
    {
        int selectedProduct = productsListBox.SelectedIndex;
        if (selectedProduct == -1)
        {
            MessageBox.Show("Wybierz produkt z listy, który chcesz usunąć.");
            return;
        }
        _products.RemoveAt(selectedProduct);
        productsListBox.Items.RemoveAt(selectedProduct);
    }
    
    private void ProductName_Enter(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(productName.Text) && productName.Text == "Wpisz nazwę...")
        {
            productName.Text = "";
            productName.ForeColor = Color.Black;
        }
    }

    private void ProductName_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(productName.Text))
        {
            productName.Text = "Wpisz nazwę...";
            productName.ForeColor = Color.Gray;
        }
    }
    
    private void Pieces_Enter(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(numberOfPiecesText.Text) && numberOfPiecesText.Text == "Wpisz liczbę...")
        {
            numberOfPiecesText.Text = "";
            numberOfPiecesText.ForeColor = Color.Black;
        }
    }

    private void Pieces_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(numberOfPiecesText.Text))
        {
            numberOfPiecesText.Text = "Wpisz liczbę...";
            numberOfPiecesText.ForeColor = Color.Gray;
        }
    }
    
    private void VAT_Enter(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(vatValueSADText.Text) && vatValueSADText.Text == "B00 Kwota VAT...")
        {
            vatValueSADText.Text = "";
            vatValueSADText.ForeColor = Color.Black;
        }
    }

    private void VAT_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(vatValueSADText.Text))
        {
            vatValueSADText.Text = "B00 Kwota VAT...";
            vatValueSADText.ForeColor = Color.Gray;
        }
    }


}