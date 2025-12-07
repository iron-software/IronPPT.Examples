# How to Insert Text into PowerPoint Slides Using IronPPT

***Based on <https://ironsoftware.com/how-to/add-text/>***


Text plays a pivotal role in presentations, and with IronPPT, dynamically adding text to slides directly through your program is streamlined and efficient.

This tutorial will demonstrate how to add text to PowerPoint slides using IronPPT.

### Getting Started with IronPPT

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

---

## Inserting Text

IronPPT simplifies the process of inserting text into a PowerPoint slide. Begin by creating an instance of the `PresentationDocument`, then use `Slides[index].AddText("")` to place text onto your desired slide. Don't forget to save the document to retain your modifications to the presentation.

```csharp
using IronPPT; // Import IronPPT namespace
using IronPPT.Models; // Import IronPPT Models namespace

// Instantiate a new presentation document
PresentationDocument presentation = new PresentationDocument();

// Add text to the first slide in the presentation
presentation.Slides[0].AddText("Welcome to IronPPT!");

// Save the modified presentation
presentation.Save("updated-presentation.pptx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/ppt/how-to/add-text/add-text.webp" alt="Demonstration of adding text to a PowerPoint slide" class="img-responsive add-shadow">
    </div>
</div>