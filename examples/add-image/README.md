***Based on <https://ironsoftware.com/examples/add-image/>***

When crafting PowerPoint presentations, effectively using visuals to complement and enhance textual information is essential. By integrating images, presenters can clarify and reinforce their messages. Moreover, the ability to tailor specific aspects such as placement on the slide, image orientation, and size adds a customizable touch to the presentations.

IronPPT offers a comprehensive solution that enables developers to personalize the placement and appearance of images within their PowerPoint slides.

## 5-Step Code to Incorporate Images
- `Image photo = new Image();`
- `photo.LoadFromFile("example.png");`
- `var insertedImage = document.AddImage(photo, 0);`
- `insertedImage.Position = (200, 200);`
- `insertedImage.Angle = 45;`

## Code Breakdown

To begin adding an image, we create an instance of the `Image` class and load an image using the `LoadFromFile` method, in this case, `example.png`. Next, we incorporate the image into the presentation by using the `AddImage` method of the document object. This operation places the newly loaded image on the first slide.

Once the image is added to the slide, you can position it by setting the `Position` property to specific x and y coordinates, with both set to 200 in our example.

For further customization, such as rotating the image, we adjust the `Angle` property to set the rotation to 45 degrees.

[Learn to Manage PowerPoint Slides with IronPPT.](https://ironsoftware.com/csharp/ppt/how-to/manage-slide/)