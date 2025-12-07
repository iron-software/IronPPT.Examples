***Based on <https://ironsoftware.com/examples/manage-slide/>***

Working programmatically with PowerPoint slides is efficiently handled using IronPPT, which allows developers to automate processes effectively. This tool makes it possible to modify slides — including removing them, reordering them, and setting visibility — through a series of simple commands, enabling full command over the slides’ configuration and display.

## Step-by-Step Instructions for Slide Manipulation with IronPPT

- `document.AddSlide();`
- `document.Slides[0].Remove();`
- `document.Slides[0].Index = 1;`
- `document.Slides[0].Show = false;`
- `document.Save("manageSlide.pptx");`


### Understanding the Code

Initially, a new `PresentationDocument` is created. To introduce a new slide, simply invoke `AddSlide`, which appends a blank slide to the presentation.

The `PresentationDocument` bootstraps the `Slides` property, representing a collection of all the slides in the document that behaves like an array. Deleting a slide is straightforward: find the slide at the desired index and apply the `Remove` method. Note that index numbering begins at 0, hence the first slide is `Slides[0]`. Using the correct index number is crucial to avoid errors when interfacing with this array structure.

To rearrange slides, alter the index property. In the provided example, the index of the first slide is modified from 0 to 1, effectively shifting its position.

To conceal a slide from view, identify the slide using its index and then set the `Show` property to false. Altering this attribute to false ensures the slide is hidden during presentations.

[Learn more about managing slides with IronPPT](https://ironsoftware.com/csharp/ppt/how-to/manage-slide/)