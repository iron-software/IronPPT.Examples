using IronPPT.Models;
using IronPPT;
namespace IronPPT.Examples.HowTo.AddText
{
    public static class Section1
    {
        public static void Run()
        {
            // Create a new presentation
            var document = new PresentationDocument();
            
            // Append text to the first slide
            document.Slides[0].AddText("Hello from IronPPT!");
            
            // Save the presentation
            document.Save("adding-text.pptx");
        }
    }
}