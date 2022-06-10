namespace TranslationService;
using Google.Cloud.Translation.V2;
public class TextTranslation
{
    public static String translateText(String textToBeTranslated)
    {

        var client = TranslationClient.Create();
        var response = client.TranslateText(textToBeTranslated, LanguageCodes.French, LanguageCodes.English);
        return response.TranslatedText;
        
    }


}
