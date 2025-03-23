using IronPPT.Models;
using IronPPT;
namespace IronPPT.Examples.Tutorial.SlideElement
{
    public static class Section1
    {
        public static void Run()
        {
            // Create new PowerPoint presentation
            var document = new PresentationDocument();
            
            // Add text
            var text = document.Slides[0].AddText("Hello");
            
            // Append text
            text.Append(new Text(" There!"));
            
            // Remove text
            document.Slides[0].Texts[0].Remove();
            
            // Export PowerPoint presentation
            document.Save("addText.pptx");
        }
    }
}