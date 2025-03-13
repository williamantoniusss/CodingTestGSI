using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using CodeTestGSI.Models;

namespace CodeTestGSI.Pages
{
    public class IndexModel : PageModel
    {
        public string InputText { get; set; }
        public List<int> Step1 { get; set; }
        public string Step2 { get; set; }
        public string Step3 { get; set; }
        public string Step4 { get; set; }
        public List<int> Step5 { get; set; }

        public void OnPost(string inputText)
        {
            InputText = inputText;
            Step1 = Converter.ConvertTextToNumbers(inputText);
            Step2 = Converter.CalculateAlternatingSum(Step1, out int finalResult);
            Step3 = Converter.GenerateIncrementalSeriesWithLetters(finalResult);
            Step4 = Converter.ConvertFinalOutput(Step3);
            Step5 = Converter.ConvertToFinalNumbers(Step4);
        }
    }
}
