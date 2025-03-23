# IronPPT Slide Element Guide

***Based on <https://ironsoftware.com/tutorials/slide-element/>***


IronPPT is a powerful PowerPoint library tailored specifically for .NET C# developers, enabling them to effortlessly add capabilities for creating, reading, and modifying PowerPoint presentations in their applications. Slides play a crucial role within a PowerPoint presentation, serving as the core components that help structure and showcase the content effectively.

## Contents

- **Text Manipulation**
  - [Text Handling](#anchor-text-content) (Add, Amend & Delete)
  - [Text Styling](#anchor-set-styling) (Font Style & Size, Color, Embolden & Italics, Strikethrough, Underlining)
- **Image Integration**
  - [Image Input](#anchor-add-images) (File Input & FileStream)
  - [Adjust Size & Orientation](#anchor-add-images) (Set Dimensions)
  - [Placement Customization](#anchor-add-images)
- **Shape Customization**
  - [Select Shape](#anchor-add-shapes)
  - [Dimension Settings](#anchor-add-shapes) (Define Size)
  - [Color and Outline Adjustment](#anchor-add-shapes)
  - [Positioning](#anchor-add-shapes)

<h3>Begin with IronPPT</h3>
  
------------------

## Text Manipulation

### Text Handling

When building a new presentation or improving an existing one, the text management capabilities of IronPPT provide precise control over text assignments and layout, enabling the creation of slides that accurately deliver your message with clarity and professionalism.

```cs
using IronPPT;
using IronPPT.Models;

// Initialize a new PowerPoint presentation
var document = new PresentationDocument();

// Insert text
var text = document.Slides[0].AddText("Hello");

// Extend the text string
text.Append(new Text(" There!"));

// Erase text
document.Slides[0].Texts[0].Remove();

// Save the modified PowerPoint presentation
document.Save("addText.pptx");
```

### Text Styling

By styling text, you refine its visual appeal by specifying characteristics such as font size, color, style type, strikethrough, and underlining. Application of these styles elevates the text's impact and enhances the document's aesthetic.

```cs
using IronPPT;
using IronPPT.Models;
 
var document = new PresentationDocument();

// Define text appearance
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

// Assign style and add text
var text = new Text("Hello World");
text.TextStyle = textStyle;
document.Slides[0].AddText(text);

document.Save("textStyle.pptx");
```

## Image Integration

Proper configuration of image settings is crucial for ensuring the visual effectiveness and appropriateness of images within a presentation context.

```cs
using IronPPT;
using IronPPT.Models;
 
// Create a new PowerPoint presentation
var document = new PresentationDocument();
 
// Load and add an image
Image image = new Image();
image.LoadFromFile("sample.png"); // loading an image from file
var newImage = document.AddImage(image, 0);
 
// Modify image properties
newImage.SetPosition(200, 200);
newImage.Rotate(45);
newImage.SetDimensions(150, 150);
newImage.Identifier = "new image";
 
// Save the presentation
document.Save("addImage.pptx");
```

## Shape Customization

IronPPT allows for easy addition and tailoring of shapes in your presentation by selecting predefined types, setting dimensions, adjusting color attributes, and positioning them strategically on slides.

```cs
using IronPPT;
using IronPPT.Models;
 
// Initialize a new PowerPoint presentation
var document = new PresentationDocument();
 
// Load and place an image (used here for demonstration purposes)
Image image = new Image();
image.LoadFromFile("sample.png");
var newImage = document.AddImage(image, 0);
 
// Configure image settings
newImage.SetPosition(200, 200);
newImage.Rotate(45);
newImage.Name = "custom shape";
newImage.SetDimensions(150, 150);
 
// Export the completed presentation
document.Save("customShape.pptx");
```