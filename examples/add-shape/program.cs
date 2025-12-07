using IronPPT;
using IronPPT.Models;

// Load a PowerPoint presentation
var document = new PresentationDocument("output.pptx");

// Configure new shape
Shape shape = new Shape();
shape.Name = "triangle";
shape.Type = IronPPT.Enums.ShapeType.Triangle;
shape.Width = 100;
shape.FillColor = new Color("#444444");
shape.OutlineColor = Color.Black;
shape.Position = (200, 200);

// Add shape
document.Slides[0].AddShape(shape);

// Export PowerPoint presentation
document.Save("addShape.pptx");