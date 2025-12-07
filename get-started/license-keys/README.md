# Utilizing IronPPT License Keys

***Based on <https://ironsoftware.com/get-started/license-keys/>***


## Acquiring a License Key

Implementing an IronPPT license key in your project is essential for deploying without restrictions or watermarks.

You can [purchase a license key here](https://ironsoftware.com/csharp/ppt/licensing/) or start a [30-day free trial here](https://ironsoftware.com/trial-license).

---

## Step 1: Download the Latest Release of IronPPT

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

---

## Step 2: Implement Your License Key

### Implement your license programmatically

Place the following code at the beginning of your application startup (e.g., in `Program.cs` or `Startup.cs`) to ensure all IronPPT functionalities are licensed properly:

```csharp
// Assigns the IronPPT license key to authorize library usage.
// Verify you replace "IRONPPT.MYLICENSE.KEY.1EF01" with your actual license key.
// Place this code early in your application's initialization sequence,
// just after referencing the IronPPT namespace and its related assemblies.

IronPPT.License.LicenseKey = "IRONPPT.MYLICENSE.KEY.1EF01";
```

### Implement your license key via an `appsettings.json` for .NET Core

Incorporating the license key into a .NET Core application globally involves:

- Creating a JSON configuration file named `appsettings.json` at the project's root.
- Inserting a `IronPPT.LicenseKey` setting in the JSON file with your license key.
- Configuring the file's properties to _Copy to Output Directory: Copy always_.

File: _appsettings.json_

```json
{
    "IronPPT.LicenseKey": "IronPPT.MYLICENSE.KEY.1EF01"
}
```

---

## Step 3: Confirm Your License Key Installation

### Check Your Installed License Key

Validate if the license key is successfully installed using this code:

```csharp
// Code snippet for checking the activation status of the IronPPT license.
// It utilizes the License class from the IronPPT library.

// Creates a boolean variable that holds the license status
bool licensed = IronPPT.License.IsLicensed;

// Ensure you have referenced IronPPT and set the license information before this point.
// This boolean returns true if the license is correctly applied, otherwise false.

// Example usage in your application:
if (licensed)
{
    Console.WriteLine("The IronPPT license has been successfully installed.");
}
else
{
    Console.WriteLine("The IronPPT license is not correctly installed. Check your license details.");
}
```

### Confirm the License Key

To confirm your license or trial key’s validity, integrate the following code:

```csharp
// THIS CODE SNIPPET IS NOT AVAILABLE!
```

If it returns `true`, the key is correctly applied, allowing you to proceed with IronPPT. If `false`, the key is invalid.

---

## Step 4: Begin Your Project with IronPPT

For an effective start with IronPPT, follow our detailed [Getting Started with IronPPT guide](https://ironsoftware.com/csharp/ppt/docs/). It provides extensive guidelines and examples to help you understand the basics of using IronPPT.

---

## Questions or Require Assistance?

For operational projects using IronPPT, obtaining a license key, either paid or trial, is necessary. Licenses can be purchased [here](https://ironsoftware.com/csharp/ppt/licensing/) or start a trial by clicking [this link](https://ironsoftware.com/trial-license).

Explore a wealth of resources such as code samples, tutorials, license information, and complete documentation in the [IronPPT section](https://ironsoftware.com/csharp/ppt/) on our site.

For further inquiries, please contact <support@ironsoftware.com>.