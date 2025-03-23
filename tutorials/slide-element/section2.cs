using IronPPT.Models;
using IronPPT;
namespace IronPPT.Examples.Tutorial.SlideElement
{
    public static class Section2
    {
        public static void Run()
        {
            var document = new PresentationDocument();
            
            // Customize text style
            var textStyle = new TextStyle
            {
                IsBold = true,
                IsItalic = true,
                Color = Color.Blue,
                Strike = StrikValue.SingleStrike,
                Outline = true,
                NoProof = true,
                Spacing = 10.0,
                Underline = new Underline { LineValue = UnderlineValues.Single, Color = Color.Red },
                Languages = "en-US",
                SpecVanish = false,
            };
            
            // Add style to text
            var text = new Text("Hello World");
            text.TextStyle = textStyle;
            
            // Add text
            document.Slides[0].AddText(text);
            
            document.Save("textStyle.pptx");
        }
    }
}