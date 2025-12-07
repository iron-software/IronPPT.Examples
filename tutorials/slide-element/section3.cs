using IronPPT.Models;
using IronPPT;
namespace IronPPT.Examples.Tutorial.SlideElement
{
    public static class Section3
    {
        public static void Run()
        {
            // Ensure the library is available
            
            // Create a new presentation document
            var document = new PresentationDocument();
            
            // Define and customize the text style
            var textStyle = new TextStyle
            {
                IsBold = true,                      // Text is bold
                IsItalic = true,                    // Text is italic
                Color = Color.Blue,                 // Text color is blue
                Strike = StrikeValue.SingleStrike,  // Text is single struck-off
                Outline = true,                     // Text has an outline
                NoProof = true,                     // Disables proofing for the text
                Spacing = 10.0,                     // Text spacing is set to 10
                Underline = new Underline 
                {
                    LineValue = UnderlineValues.Single,   // Single underline
                    Color = Color.Red                     // Underline color is red
                },
                Languages = "en-US",               // Text language is set to U.S. English
                SpecVanish = false,                // Text does not vanish when special formatting is applied
            };
            
            // Create text content and apply the defined style
            var text = new Text("Hello World");   // Instantiate text with a string
            text.TextStyle = textStyle;           // Apply the defined style to the text
            
            // Add a new slide if none exist
            if (document.Slides.Count == 0)
            {
                document.Slides.Add(new Slide());   // Add a new slide to the document
            }
            
            // Add the styled text to the first slide
            document.Slides[0].AddText(text);      // Add the newly created text object to the first slide
            
            // Save the presentation document to a file
            document.Save("textStyle.pptx");        // Save the document with the filename "textStyle.pptx"
        }
    }
}