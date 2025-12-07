# How to Manage Images in PowerPoint Presentations

***Based on <https://ironsoftware.com/how-to/manage-image/>***


Images play a crucial role in enhancing PowerPoint presentations by providing visual support to the content, making it memorable and engaging. Mastery of inserting, updating, and removing visuals is essential to keep the presentation looking professional and up-to-date.

Here's a tutorial on how to manage images effectively in PowerPoint using IronPPT.

### Begin with IronPPT

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

-------------------------------

## Inserting Images

To insert an image into a PowerPoint slide with IronPPT, start by either creating a new presentation or opening an existing file. Initiate an image object using the `Image` class that points to your desired file. After the image is prepared, insert it into the desired slide and customize its attributes like `Height`, `Width`, and `Angle`. When finished, save the presentation to include the new image.

```csharp
using IronPPT;
using IronPPT.Models;

// Initialize a new presentation
var document = new PresentationDocument();

// Load an image from a file
Image image = new Image();
image.LoadFromFile("image.jpg");

// Insert the image into the first slide (index 0)
var newImage = document.AddImage(image, 0);

// Set the image rotation to 180 degrees
newImage.Angle = 180;

// Save the updated presentation as a .pptx file
document.Save("adding-image.pptx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/ppt/how-to/manage-image/manage-image-add-image.webp" alt="Add image to PowerPoint slide" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Image Attributes Reference

Below is a reference table for the different properties you can adjust on an image.

<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px; overflow:hidden;padding:10px 5px;word-break:normal;}
.tg th{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px; font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg .tg-fymr{border-color:inherit;font-weight:bold;text-align:left;vertical-align:top}
.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top}
</style>
<table class="tg">
<thead>
<tr>
<th class="tg-fymr">Property</th>
<th class="tg-fymr">Description</th>
<th class="tg-fymr">Example</th>
</tr>
</thead>
<tbody>
<tr>
<td class="tg-0pky"><code>Height</code></td>
<td class="tg-0pky">Adjusts the image's height in points.</td>
<td class="tg-0pky"><code>image.Height = 300;</code></td>
</tr>
<tr>
<td class="tg-0pky"><code>Width</code></td>
<td class="tg-0pky">Adjusts the image's width in points.</td>
<td class="tg-0pky"><code>image.Width = 400;</code></td>
</tr>
<tr>
<td class="tg-0pky"><code>Angle</code></td>
<td class="tg-0pky">Rotates the image by a specified number of degrees.</td>
<td class="tg-0pky"><code>image.Angle = 45;</code></td>
</tr>
<tr>
<td class="tg-0pky"><code>Position</code></td>
<td class="tg-0pky">Sets the image's position on the slide with x and y coordinates.</td>
<td class="tg-0pky"><code>image.Position = (200, 200);</code></td>
</tr>
<tr>
<td class="tg-0pky"><code>FrameShape</code></td>
<td class="tg-0pky">Determines the frame shape of the image using ShapeType enum values.</td