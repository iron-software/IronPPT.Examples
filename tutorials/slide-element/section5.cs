using IronPPT.Enums;
using IronPPT;
namespace IronPPT.Examples.Tutorial.SlideElement
{
    public static class Section5
    {
        public static void Run()
        {
            // Load a PowerPoint presentation.
            // The PresentationDocument is assumed to represent an entire PPTX file loaded from disk.
            var document = new PresentationDocument("output.pptx");
            
            // Configure a new shape.
            // Shape is assumed to be a model object representing drawable elements on a slide.
            Shape shape = new Shape
            {
                Name = "triangle",
                Type = ShapeType.Triangle,
                Width = 100,
                FillColor = new Color("#444444"),
                OutlineColor = Color.Black,
            
                // Position is set via assumed X and Y positioning properties.
                // It's important that these properties are set to valid coordinates for display on the slide.
                XPosition = 200,
                YPosition = 200
            };
            
            // Add the shape to the first slide in the presentation.
            // Slides[0] refers to the first slide in the collection. Ensure a slide exists at this index.
            document.Slides[0].AddShape(shape);
            
            // Export the modified PowerPoint presentation.
            // Saves the changes to a new file, ensuring the original presentation is not overwritten.
            document.Save("addShape.pptx");
        }
    }
}