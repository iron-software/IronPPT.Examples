# C# Slide Element Guide – IronPPT

***Based on <https://ironsoftware.com/tutorials/slide-element/>***


IronPPT serves as a powerful PowerPoint toolkit, enabling .NET C# developers to efficiently manage creation, reading, and modification of PowerPoint slides within their software solutions. Slides are crucial, as they help articulate and structure the presentation content clearly.

*as-heading:2(Getting Started: Embedding Text into Slides)*

Learn how simple it is to embed text onto a slide using IronPPT. Whether you're starting from scratch or updating an existing slide, this snippet shows you how to quickly insert text and save your work with minimal coding.

```cs
:title=Instant Slide Text Addition
var ppt = new IronPPT.PresentationDocument();
var newSlideText = ppt.Slides.Count > 0 ? ppt.Slides[0].AddText("Insert Text Easily") : ppt.Slides.Add(new IronPPT.Models.Slide()).AddText("Insert Text Easily");
ppt.Save("updatedSlide.pptx");
```

## Table of Contents

- **Text Manipulation**
  - [Editing Text](#text-content) (Add, Append & Delete)
  - [Styling Text](#set-styling) (Font Type & Size, Color, Weight & Italic, Linethrough, Underline)
- **Image Integration**
  - [Image Insertion](#add-images) (File & Stream Input)
  - [Adjust Dimensions & Orientation](#add-images) (Size & Rotation)
  - [Placement Customization](#add-images)
- **Shape Incorporation**
  - [Define Shape](#add-shapes)
  - [Size Adjustment](#add-shapes) (Scale)
  - [Color Customization](#add-shapes)
  - [Precise Placement](#add-shapes)

## Text Manipulation

### Editing Text

The text handling functionality in IronPPT lets you fully manage how text appears in your slides, enabling clear communication through well-designed text placements and styles.

```csharp
using IronPPT;
using IronPPT.Models;

// Instantiate a PowerPoint file
var pptFile = new PresentationDocument();

// Ensure there is a slide available
if (pptFile.Slides.Count == 0)
{
    pptFile.Slides.Add(new Slide());
}

// Insert text into the first available slide
var newText = pptFile.Slides[0].AddText("Greetings");

// Extend the current text on the slide
newText.Content += " World!";

// Remove any text elements if present
if (pptFile.Slides[0].Texts.Count > 0)
{
    pptFile.Slides[0].Texts[0].Remove();
}

// Save the presentation with the new text
pptFile.Save("updatedText.pptx");
```

### Styling Text

Enhancing the visual appeal of your text is straightforward with IronPPT. Define the text's style by adjusting its various attributes to better suit the presentation's theme.

```csharp
using IronPPT;
using IronPPT.Models; // Confirm library availability

// Begin a new presentation
var pptDocument = new PresentationDocument();

// Set up and customize the text appearance
var styleOfText = new TextStyle
{
    IsBold = true,                      // Set text to bold
    IsItalic = true,                    // Apply italic styling to text
    Color = Color.Blue,                 // Change text color to blue
    Strike = StrikeValue.SingleStrike,  // Apply a single strikethrough
    Outline = true,                     // Enable text outline
    NoProof = true,                     // Disable proofing tools for the text
    Spacing = 10.0,                     // Adjust spacing to 10 units
    Underline = new Underline 
    {
        LineValue = UnderlineValues.Single,   // Apply a single underline
        Color = Color.Red                     // Set underline color to red
    },
    Languages = "en-US",               // Set text language to English (US)
    SpecVanish = false,                // Keep special formatting visible
};

// Initialize and style text
var styledText = new Text("Sample Text");
styledText.TextStyle = styleOfText; 

// Add a slide if none exist
if (pptDocument.Slides.Count == 0)
{
    pptDocument.Slides.Add(new Slide());
}

// Incorporate styled text into the first slide
pptDocument.Slides[0].AddText(styledText);

// Commit the presentation to file
pptDocument.Save("styledText.pptx");
```

## Image Integration

Configure image properties to match presentation needs, ensuring each image fits well within its surroundings and contributes positively to the slide's layout.

```csharp
using IronPPT;
using IronPPT.Models;
using System.Drawing;

// Scripting for adding images to PowerPoint slides using IronPPT.
// An image is embedded, adjusted, and the modified presentation is saved.

// Instantiate a new PowerPoint document
var ppt = new PresentationDocument();

// Load an image and initialize a new Image object
var img = new Image();
img.LoadFromFile("sample.png");

// Add and configure the image in the first slide
var configuredImage = ppt.AddImage(img, 0);

// Adjust positioning using a Point object
configuredImage.Position = new Point(100, 100); // Modify the image's coordinates
configuredImage.Angle = 30; // Rotate the image
configuredImage.Name = "inserted image"; // Name the image for reference
configuredImage.Width = 120; // Specify image width
configuredImage.Height = 120; // Define image height

// Save the amended presentation to a file
ppt.Save("enhancedImage.pptx");
```

## Shape Incorporation

Adding and customizing shapes within your presentation allows for a creative and structured layout, enhancing the visual appeal and effectiveness of your slides.

```csharp
using IronPPT;
using IronPPT.Models;
using IronPPT.Enums;

// Begin with a loaded presentation document.
var ppt = new PresentationDocument("presentation.pptx");

// Set up a new shape to be added to a slide.
Shape shapeConfig = new Shape
{
    Name = "ellipse",
    Type = ShapeType.Ellipse,
    Width = 150,
    FillColor = new Color("#888888"),
    OutlineColor = Color.White,

    // Ensure the shape's position is correctly set.
    XPosition = 250,
    YPosition = 250
};

// Embed the configured shape into the first slide.
ppt.Slides[0].AddShape(shapeConfig);

// Finalize changes by saving the modified presentation to a new file.
ppt.Save("shapeAdded.pptx");
```