# IronPPT.Examples

Runnable C# examples for [IronPPT](https://ironsoftware.com/csharp/ppt/), a .NET library for creating, reading, and editing PPTX presentations without Microsoft PowerPoint or Office Interop.

## Install

```bash
dotnet add package IronPPT
```

## Quickstart

```csharp
using IronPPT;
using IronPPT.Models;

// Create a new presentation
var document = new PresentationDocument();

// Add a slide with text
var slide = new Slide();
slide.AddText("Hello from IronPPT!");
document.AddSlide(slide);

document.Save("hello.pptx");
```

To edit an existing deck, use `new PresentationDocument("existing.pptx")` and access slides through the `Slides` collection — for example, `document.Slides[0].TextBoxes[0].AddText("Updated title")`. Images, shapes, and styled paragraphs follow the same pattern: construct, configure, add to a slide.

For production use, set a license key via `License.LicenseKey = "YOUR-KEY"`. Without one, presentations include a watermark.

## What's in this repo

Each folder contains a self-contained .NET project you can open and run:

- `examples/` — focused snippets demonstrating individual features
- `get-started/` — minimal first projects including license-key setup
- `how-to/` — task-oriented guides for specific presentation operations
- `quickstart/` — end-to-end project scaffolds
- `tutorials/` — longer walkthroughs (including the `slide-element` tutorial covering text boxes, paragraphs, images, and shapes)

## Common tasks covered

- Creating and loading PPTX files
- Adding slides, text boxes, and styled paragraphs
- Text styling: font family, size, color, bold, italic, underline, alignment
- Inserting images with positioning, scaling, and sizing
- Adding shapes with fill color, outline, rotation, and shape type (rectangle, triangle, ellipse, cloud, and more)
- Slide layout: size, orientation, background color
- Reading text and structural content from existing decks
- Bullet and numbered lists with custom indentation

## Current scope

IronPPT supports programmatic creation and editing of `.pptx` files. Rendering presentations to PDF or images, and slideshow playback, are not currently supported — for PDF output from a presentation, generate the PPTX with IronPPT and convert it separately.

## Platform support

.NET 10, 9, 8, 7, 6, 5, .NET Core 3.1, .NET Standard 2 and 2.1, and .NET Framework 4.6.2+. Windows, macOS, Linux, Docker, Azure, and AWS. See the [installation docs](https://ironsoftware.com/csharp/ppt/docs/) for environment-specific notes.

## Documentation and support

- Full documentation: [ironsoftware.com/csharp/ppt/docs/](https://ironsoftware.com/csharp/ppt/docs/)
- API reference: [ironsoftware.com/csharp/ppt/object-reference/api/](https://ironsoftware.com/csharp/ppt/object-reference/api/)
- Issues with these examples: file directly on this repository
- Product support: [support@ironsoftware.com](mailto:support@ironsoftware.com)

## About

This repository is maintained by [Iron Software](https://ironsoftware.com/). IronPPT is a commercial library — see [licensing](https://ironsoftware.com/csharp/ppt/licensing/) for terms and trial details.
