# Getting Started with IronPPT

***Based on <https://ironsoftware.com/docs/docs/>***


## Introducing IronPowerPoint: .NET PowerPoint Library

**IronPPT** by Iron Software offers powerful capabilities for handling PowerPoint presentations within .NET applications.

- **Load, Manipulate, and Save PowerPoint Presentations**: Seamlessly work with .pptx and .ppt files.
- **SlideSetup**: Set up slide properties such as size, orientation, background color, and layout.
- **Text**: Manage text including styling, splitting, appending, and adding text boxes.
- **TextStyle**: Control text appearance with settings for font type, size, color, boldness, italics, underlining, and alignment.
- **Shapes**: Insert and adjust shapes, customizing size, position, type, and rotation.
- **Images**: Embed images into slides, with options for resizing, aligning, and positioning.

## Installing the Library

### Setting Up IronPPT

IronPPT installation is quick and efficient. Incorporate the package through the following command:

```shell
Install-Package IronPPT
```

You can also download it directly from the [official IronPPT NuGet page](https://www.nuget.org/packages/IronPPT).

Once installed, simply include `using IronPPT;` at the beginning of your C# project files to begin using it.

## License Activation

To activate IronPPT, apply a valid or trial license key by setting the **LicenseKey** property as shown below. This should be done right after the library import and before utilizing any IronPPT features:

```csharp
IronPPT.License.LicenseKey = "IRONPPT.MYLICENSE.KEY.1EF01";
```

## Practical Code Examples

Below are some examples demonstrating how to use IronPPT features effectively.

## Creating a PowerPoint Presentation

Start by creating a new PowerPoint file using the `PresentationDocument` class. You can add both slides and textual content using the appropriate methods, and then save the presentation with the `Save` method.

```csharp
using IronPPT;

// Initialize a new PowerPoint document
var document = new PresentationDocument();

// Add a new empty slide
document.AddSlide();

// Construct and add a new slide with text
Slide slide = new Slide();
slide.AddText("Hello!");
document.AddSlide(slide);

// Save the constructed PowerPoint file
document.Save("output.pptx");
```

## Inserting Shapes

Utilize the `AddShape` method from a slide to add and customize shapes. You can set the shape's properties such as fill color, outline color, position, angle, and type.

```csharp
using IronPPT;

// Open an existing PowerPoint file
var document = new PresentationDocument("output.pptx");

// Define a new shape
Shape shape = new Shape();
shape.Name = "triangle";
shape.Type = IronPPT.Enums.ShapeType.Triangle;
shape.Width = 100;
shape.FillColor = new Color("#444444");
shape.OutlineColor = Color.Black;
shape.Position = (200, 200);

// Add the shape to a slide
document.Slides[0].AddShape(shape);

// Re-export the updated PowerPoint presentation
document.Save("addShape.pptx");
```

## Embedding Images

Adding an image to a slide involves straightforward methods to load, position, and adjust the image’s properties before saving the presentation again.

```csharp
using IronPPT;

// Start with a new presentation
var document = new PresentationDocument();

// Load and add an image to the first slide
Image image = new Image();
image.LoadFromFile("sample.png");
var newImage = document.Slides[0].AddImage(image);

// Modify the image's properties
newImage.Position = (200, 200);
newImage.Angle = 45;
newImage.Name = "new image";
newImage.Width = 150;
newImage.Height = 150;

// Save the final presentation
document.Save("addImage.pptx");
```

## Licensing & Customer Support

**IronPPT** is available under a commercial license with free trial options accessible [here](https://ironsoftware.com/ppt/trial-license).

For more comprehensive details on Iron Software offerings or to get help from our team, please visit our website at <https://ironsoftware.com/>. For support queries or further information, reach out via our [contact page](https://ironsoftware.com/#live-chat-support).

### Iron Software Customer Service

For general assistance and technical support, please contact us via email at: <support@ironsoftware.com>