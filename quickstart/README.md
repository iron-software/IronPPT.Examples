# Getting Started with IronPPT

***Based on <https://ironsoftware.com/docs/docs/>***


## Introduction to IronPowerPoint: PowerPoint Library for .NET Developers

**IronPPT** is crafted by Iron Software to enable extensive manipulation of PowerPoint presentations directly within .NET applications.

- Open, modify, and save .ppt and .pptx files with ease.
- **SlideSetup**: Adjust slide dimensions, orientation, background, and layout.
- **Text Management**: Control text blocks, styles, additions, modifications, and insertions of text boxes.
- **TextStyle Options**: Modify text appearance including font, size, color, styles, and alignment.
- **Shape Tools**: Introduce and adjust shapes regarding their size, placement, type, and rotation.
- **Image Handling**: Embed images in slides, with flexibility in scaling and positioning.


## Setting Up

### Installing IronPPT

The installation of IronPPT is streamlined and user-friendly. Import the library by executing:

```shell
Install-Package IronPPT
```

Alternatively, you can acquire it directly from [IronPPT on NuGet](https://www.nuget.org/packages/IronPPT).

Post-installation, just prepend your C# files with `using IronPPT;` to integrate its functionalities.

## License Configuration

To activate IronPPT functionalities, input a valid license or trial key by modifying the **LicenseKey** parameter. Implement this segment right after including the library and before utilizing any IronPPT capabilities:

```csharp
/// <summary>
/// Apply the license key for IronPPT to unlock comprehensive features.
/// Confirm your project references IronPPT correctly by including its namespace.
/// </summary>

using System;
using IronPPT;

namespace IronPPTApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeLicense();
        }

        /// <summary>
        /// Initialize the IronPPT license to activate all features.
        /// Replace "IRONPPT.MYLICENSE.KEY.1EF01" with your licensed key.
        /// </summary>
        static void InitializeLicense()
        {
            IronPPT.License.LicenseKey = "IRONPPT.MYLICENSE.KEY.1EF01";
            Console.WriteLine("License key applied successfully.");
        }
    }
}
```

## Practical Code Examples

Let’s delve into some practical uses and capabilities of IronPPT.

## Constructing a PowerPoint Presentation

Generate a new PowerPoint file by creating a `PresentationDocument` instance. This allows you to add slides and text content to your document, and then save it:

```csharp
using IronPPT;

var presentation = new PresentationDocument();
var newSlide = new Slide();
newSlide.AddText("Welcome to IronPPT!");

presentation.AddSlide(newSlide);
presentation.Save("IntroPresentation.pptx");
```

## Integrating a Shape

To add a shape to a slide, utilize the `AddShape` method from the slide instance:

```csharp
using IronPPT;
using IronPPT.Drawing;
using IronPPT.Enums;

var ppt = new PresentationDocument("IntroPresentation.pptx");

Shape rectangle = new Shape
{
    Name = "rectangle",
    Type = ShapeType.Rectangle,
    Width = 120,
    Height = 60,
    FillColor = new Color("#555555"),
    OutlineColor = Color.Black,
    Position = new System.Drawing.Point(150, 150)
};

if (ppt.Slides.Count > 0)
{
    ppt.Slides[0].AddShape(rectangle);
}
else
{
    var newSlide = new Slide();
    ppt.Slides.Add(newSlide);
    ppt.Slides[0].AddShape(rectangle);
}

ppt.Save("UpdatedPresentation.pptx");
```

## Embedding an Image

This example demonstrates adding an image to a slide, modifying its attributes, and updating the PowerPoint file:

```csharp
using IronPPT;
using System.Drawing;

var presentation = new PresentationDocument();

if (presentation.Slides.Count == 0)
{
    presentation.Slides.Add(new Slide());
}

Image img = new Image();
img.LoadFromFile("sample.png");

var slideImage = presentation.Slides[0].AddImage(img);
slideImage.Position = new Point(250, 250);
slideImage.Angle = 30;
slideImage.Name = "Slide Image";
slideImage.Width = 200;
slideImage.Height = 200;

presentation.Save("FinalPresentation.pptx");
```

## Licensing & Support

**IronPPT** offers [complimentary trial licenses](https://ironsoftware.com/csharp/ppt/trial-license).

For comprehensive details about Iron Software, visit [our homepage](https://ironsoftware.com/). For support or queries, feel free to [reach out to our support team](https://www.ironsoftware.com/csharp/ppt/#live-chat-support).

### Assistance from Iron Software

For general support and technical queries, connect with us via email at <support@ironsoftware.com>.