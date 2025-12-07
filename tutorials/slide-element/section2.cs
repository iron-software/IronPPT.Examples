using IronPPT.Models;
using IronPPT;
namespace IronPPT.Examples.Tutorial.SlideElement
{
    public static class Section2
    {
        public static void Run()
        {
            // Create a new PowerPoint presentation
            var document = new PresentationDocument();
            
            // Ensure there is at least one slide to work with
            if (document.Slides.Count == 0)
            {
                document.Slides.Add(new Slide());
            }
            
            // Add text to the first slide
            var text = document.Slides[0].AddText("Hello");
            
            // Append text to the existing text on the slide
            text.Content += " There!";
            
            // Check if there is any text element to remove from the first slide
            if (document.Slides[0].Texts.Count > 0)
            {
                document.Slides[0].Texts[0].Remove();
            }
            
            // Export the PowerPoint presentation with the specified file name
            document.Save("addText.pptx");
        }
    }
}