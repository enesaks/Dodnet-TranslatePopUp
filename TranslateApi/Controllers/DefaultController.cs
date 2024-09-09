using Microsoft.AspNetCore.Mvc;
using DeepL;
using System.Collections;

namespace TranslateApi.Controllers
{
    public class DefaultController : Controller
    {

        private static string sourceLanguage = "TR";
        private static string targetLanguage = "EN-US";
        // GET: DefaultController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TranslateText([FromBody] TextModel model)
        {
            var authKey = "51062dfb-8acd-43e3-bf31...";
            var translator = new Translator(authKey);

            System.Console.WriteLine(model.SourceLanguage + model.TargetLanguage);
            System.Console.WriteLine(model.Text);

            switch (model.TargetLanguage)
            {
                case "En":
                    targetLanguage = "EN-US";
                    break;
                case "Es":
                    targetLanguage = "ES";
                    break;
                case "Fr":
                    targetLanguage = "FR";
                    break;
                case "De":
                    targetLanguage = "DE";
                    break;
                case "Tr":
                    targetLanguage = "TR";
                    break;
                default:
                    targetLanguage = "EN-US";
                    break;
            }
            switch (model.SourceLanguage)
            {
                case "En":
                    sourceLanguage = "EN";
                    break;
                case "Es":
                    sourceLanguage = "ES";
                    break;
                case "Fr":
                    sourceLanguage = "FR";
                    break;
                case "De":
                    sourceLanguage = "DE";
                    break;
                case "Tr":
                    sourceLanguage = "TR";
                    break;
                default:
                    sourceLanguage = "EN";
                    break;
            }
            var translatedText = await translator.TranslateTextAsync(
                model.Text,
                sourceLanguage,
                targetLanguage);


            System.Console.WriteLine(translatedText.ToString());


            // JSON formatında döndürme
            return Json(new { translatedText = translatedText.Text });

        }



    }

    public class TextModel
    {
        public string Text { get; set; }
        public string TargetLanguage { get; set; }
        public string SourceLanguage { get; set; }
    }
}
