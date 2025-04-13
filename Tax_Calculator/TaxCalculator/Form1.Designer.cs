using System.Diagnostics;

namespace TaxCalculator;

partial class Form1
{
    private System.Windows.Forms.TextBox vatValueSADText;
    private System.Windows.Forms.TextBox numberOfPiecesText;
    
    private System.Windows.Forms.Label vatValueSADLabel;
    private System.Windows.Forms.Label numberOfPiecesLabel;
    
    private System.Windows.Forms.TextBox productName;
    private System.Windows.Forms.Label productLabel;
    private System.Windows.Forms.ListBox productsListBox;
    private System.Windows.Forms.Label productsListLabel;
    private System.Windows.Forms.Button addProductButton;
    private System.Windows.Forms.Button deleteProductButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Button calculateButton;
    private System.Windows.Forms.RichTextBox resultsBox;
    private System.Windows.Forms.Label resultsLabel;
    
    
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
        #region Labels
            //VAT
            this.vatValueSADLabel = new System.Windows.Forms.Label();
            this.vatValueSADText = new System.Windows.Forms.TextBox();
            //Produkt
            this.productLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.numberOfPiecesLabel = new System.Windows.Forms.Label();
            this.numberOfPiecesText = new System.Windows.Forms.TextBox();
            
            this.addProductButton = new System.Windows.Forms.Button();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            
            this.clearButton = new System.Windows.Forms.Button();
            
            //Oblicz
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.RichTextBox();
        
            
            this.productsListLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
        #endregion
        
        #region Customize
            //VAT
            this.vatValueSADLabel.Location = new System.Drawing.Point(20, 20);
            this.vatValueSADLabel.Size = new System.Drawing.Size(70, 23);
            this.vatValueSADLabel.Text = "VAT z SADu:";
            this.vatValueSADText.Location = new System.Drawing.Point(100, 20);
            this.vatValueSADText.Size = new System.Drawing.Size(100, 20);
            this.vatValueSADText.Text = "B00 Kwota VAT...";
            this.vatValueSADText.ForeColor = Color.Gray;
            this.vatValueSADText.GotFocus += VAT_Enter;
            this.vatValueSADText.LostFocus += VAT_Leave;
            
            //Produkt name
            this.productName.Location = new System.Drawing.Point(100, 60);
            this.productName.Size = new System.Drawing.Size(100, 23);
            this.productName.Text = "Wpisz nazwę...";
            this.productName.ForeColor = Color.Gray;
            this.productName.GotFocus += ProductName_Enter;
            this.productName.LostFocus += ProductName_Leave;

            //Produkt label
            this.productLabel.Text = "Nazwa:";
            this.productLabel.Location = new System.Drawing.Point(20, 60);
            this.productLabel.Size = new System.Drawing.Size(50, 23);
            //Produkt pieces text
            this.numberOfPiecesText.Location = new System.Drawing.Point(100, 85);
            this.numberOfPiecesText.Size = new System.Drawing.Size(100, 23);
            this.numberOfPiecesText.Text = "Wpisz liczbę...";
            this.numberOfPiecesText.ForeColor = Color.Gray;
            this.numberOfPiecesText.GotFocus += Pieces_Enter;
            this.numberOfPiecesText.LostFocus += Pieces_Leave;
            
            //Product pieces label
            this.numberOfPiecesLabel.Text = "Sztuk: ";
            this.numberOfPiecesLabel.Location = new System.Drawing.Point(20, 85);
            this.numberOfPiecesLabel.Size = new System.Drawing.Size(50, 23);
            
            //Add procukt button
            this.addProductButton.Text = "Dodaj";
            this.addProductButton.Location = new System.Drawing.Point(230, 50);
            this.addProductButton.Size = new System.Drawing.Size(75, 30);
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            this.addProductButton.BackColor = Color.CadetBlue;
            this.addProductButton.FlatAppearance.BorderSize = 2;
            this.addProductButton.FlatStyle = FlatStyle.Flat;
            this.addProductButton.FlatAppearance.BorderColor = Color.LightSeaGreen;
        
            //Delete product button
            this.deleteProductButton.Text = "Usuń";
            this.deleteProductButton.Location = new System.Drawing.Point(230, 85);
            this.deleteProductButton.Size = new System.Drawing.Size(75, 30);
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            this.deleteProductButton.BackColor = Color.IndianRed;
            this.deleteProductButton.FlatAppearance.BorderSize = 2;
            this.deleteProductButton.FlatStyle = FlatStyle.Flat;
            this.deleteProductButton.FlatAppearance.BorderColor = Color.DarkRed;
            
            //Produkt list
            this.productsListBox.Location = new System.Drawing.Point(20, 140);
            this.productsListBox.Size = new System.Drawing.Size(300, 100);
            this.productsListBox.BackColor = Color.LightGray;
            
            //Calculate button
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.Location = new System.Drawing.Point(350, 150);
            this.calculateButton.Size = new System.Drawing.Size(75, 30);
            this.calculateButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            this.calculateButton.BackColor = Color.DarkSeaGreen;
            this.calculateButton.FlatAppearance.BorderSize = 2;
            this.calculateButton.FlatStyle = FlatStyle.Flat;
            this.calculateButton.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            
            //Clear button
            this.clearButton.Text = "Wyczyść";
            this.clearButton.Location = new System.Drawing.Point(350, 185);
            this.clearButton.Size = new System.Drawing.Size(75, 30);
            this.clearButton.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.clearButton.BackColor = Color.LightBlue;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatStyle = FlatStyle.Flat;
            this.clearButton.FlatAppearance.BorderColor = Color.PowderBlue;
            
            //Results box
            this.resultsBox.Location = new System.Drawing.Point(20, 270);
            this.resultsBox.Size = new System.Drawing.Size(500, 380);
            this.resultsBox.ReadOnly = true;
            this.resultsBox.BackColor = Color.LightGray;
            
            //Product list label
            this.productsListLabel.Text = "Produkty:";
            this.productsListLabel.Location = new System.Drawing.Point(20, 123);
            this.productsListLabel.Size = new System.Drawing.Size(100, 20);
            
            
            //Results label
            this.resultsLabel.Text = "Wyniki:";
            this.resultsLabel.Location = new System.Drawing.Point(20, 250);
            this.resultsLabel.Size = new System.Drawing.Size(100, 20);

        #endregion
        
        #region AddControls
            this.Controls.Add(this.vatValueSADLabel);
            this.Controls.Add(this.vatValueSADText);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.numberOfPiecesLabel);
            this.Controls.Add(this.numberOfPiecesText);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.productsListLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.clearButton);
        #endregion
        
        
        this.components = new System.ComponentModel.Container();
        this.BackColor = Color.DarkGray;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 660);
        this.Text = "Kalkulator PZ";
        this.Icon = new Icon(Path.Combine(Application.StartupPath, "favicon.ico"));
    }

    #endregion
}