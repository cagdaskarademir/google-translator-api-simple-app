using System;
using Google.Cloud.Translation.V2;

namespace GoogleTranslatorApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS","google-authentication-file.json");
            TranslationClient client = TranslationClient.Create();

            var result = client.TranslateText("Yurtta sulh, cihanda sulh", LanguageCodes.English, LanguageCodes.Turkish);

            var translatedText = result.TranslatedText;

            Console.WriteLine(translatedText);
        }
    }
}