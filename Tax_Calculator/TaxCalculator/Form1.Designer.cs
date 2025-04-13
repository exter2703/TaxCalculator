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
            
            //Produkt name
            this.productName.Location = new System.Drawing.Point(100, 60);
            this.productName.Size = new System.Drawing.Size(100, 23);
            //Produkt label
            this.productLabel.Text = "Nazwa:";
            this.productLabel.Location = new System.Drawing.Point(20, 60);
            this.productLabel.Size = new System.Drawing.Size(50, 23);
            //Produkt pieces text
            this.numberOfPiecesText.Location = new System.Drawing.Point(100, 85);
            this.numberOfPiecesText.Size = new System.Drawing.Size(100, 23);
            //Product pieces label
            this.numberOfPiecesLabel.Text = "Sztuk: ";
            this.numberOfPiecesLabel.Location = new System.Drawing.Point(20, 85);
            this.numberOfPiecesLabel.Size = new System.Drawing.Size(50, 23);
            
            //Add procukt button
            this.addProductButton.Text = "Dodaj produkt";
            this.addProductButton.Location = new System.Drawing.Point(230, 80);
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            
            //Produkt list
            this.productsListBox.Location = new System.Drawing.Point(20, 140);
            this.productsListBox.Size = new System.Drawing.Size(300, 100);
            
            //Calculate button
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.Location = new System.Drawing.Point(350, 170);
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            
            //Results box
            this.resultsBox.Location = new System.Drawing.Point(20, 270);
            this.resultsBox.Size = new System.Drawing.Size(500, 380);
            this.resultsBox.ReadOnly = true;
            
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
        #endregion
        
        
        this.components = new System.ComponentModel.Container();
        this.BackColor = Color.LightGray;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 660);
        this.Text = "Form1";
    }

    #endregion
}