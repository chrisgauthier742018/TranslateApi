namespace CSSINC;

public partial class UI : Form
{
    public UI()
    {
        InitializeComponent();
        
    }

    private void UI_Load(object sender, EventArgs e)
    {
        
    }
    
    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
    

    private void Translate_Click(object sender, EventArgs e)
    {
        String textToBeTranslated;
        textToBeTranslated = TranslationService.TextTranslation.translateText(inputString.Text);
        outputString.Text = textToBeTranslated;
        
    }
}
