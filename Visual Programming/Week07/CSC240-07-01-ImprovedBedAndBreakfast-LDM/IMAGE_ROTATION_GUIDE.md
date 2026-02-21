# Image Rotation Feature - Threading Example

## What Was Added

We've added a **4th thread** to your project that automatically rotates through three images in the PictureBox!

## The Images

The following images rotate every **3 seconds**:
1. **Bed-and-breakfast.png** - The B&B building
2. **breakfast.png** - A breakfast plate
3. **Bed.png** - A bedroom/bed

## How It Works

### New Code Elements

#### 1. Class-Level Variables
```csharp
private int currentImageIndex = 0;      // Tracks which image to show
private string[] imagePaths;            // Holds the image file names
private bool isRunning = true;          // Controls the thread loop
```

#### 2. Constructor Setup
```csharp
imagePaths = new string[]
{
    "Bed-and-breakfast.png",
    "breakfast.png",
    "Bed.png"
};

Thread imageRotationThread = new Thread(RotateImages);
imageRotationThread.IsBackground = true;  // IMPORTANT!
imageRotationThread.Start();
```

**What's `IsBackground = true`?**
- Makes the thread a "background thread"
- When you close the form, the thread automatically stops
- Without this, the thread would keep running even after closing!

#### 3. The RotateImages Method (4th Thread!)
```csharp
private void RotateImages()
{
    while (isRunning)  // Runs continuously
    {
        try
        {
            this.Invoke(new Action(() =>  // Update UI safely
            {
                if (File.Exists(imagePaths[currentImageIndex]))
                {
                    logoPictureBox.Image = Image.FromFile(imagePaths[currentImageIndex]);
                    logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }));

            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            
            Thread.Sleep(3000);  // Wait 3 seconds before next image
        }
        catch (Exception)
        {
            Thread.Sleep(3000);  // If error, wait and try again
        }
    }
}
```

## Key Concepts Demonstrated

### 1. Continuous Loop Threading
```csharp
while (isRunning)
{
    // This runs forever (until form closes)
}
```

### 2. Circular Array Index
```csharp
currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
```
- Increments the index
- `% imagePaths.Length` wraps it back to 0 when reaching the end
- Creates an infinite loop: 0 ? 1 ? 2 ? 0 ? 1 ? 2...

### 3. File Existence Check
```csharp
if (File.Exists(imagePaths[currentImageIndex]))
```
- Prevents crashes if an image is missing
- Good programming practice!

### 4. Image Loading
```csharp
logoPictureBox.Image = Image.FromFile(imagePaths[currentImageIndex]);
logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
```
- Loads image from file
- `Zoom` mode fits the image while keeping proportions

### 5. Exception Handling
```csharp
try
{
    // Try to load and display image
}
catch (Exception)
{
    Thread.Sleep(3000);  // If it fails, just wait and try again
}
```

## Now You Have 4 Threads!

1. **Thread 1** - LoadRates() - Shows room rates
2. **Thread 2** - CheckAvailability() - Shows reservation info
3. **Thread 3** - ShowAmenities() - Shows amenities list
4. **Thread 4** - RotateImages() - Rotates images continuously! ?

## What Makes Thread 4 Different?

| Feature | Threads 1-3 | Thread 4 |
|---------|-------------|----------|
| **Trigger** | Button click | Starts automatically |
| **Duration** | Runs once | Runs continuously |
| **Background** | No | Yes (IsBackground = true) |
| **Loop** | No loop | Infinite while loop |
| **Purpose** | Response to user action | Automatic animation |

## Customization Ideas

### Change Rotation Speed
```csharp
Thread.Sleep(3000);  // Change 3000 to any milliseconds
// 1000 = 1 second
// 5000 = 5 seconds
```

### Add More Images
```csharp
imagePaths = new string[]
{
    "Bed-and-breakfast.png",
    "breakfast.png",
    "Bed.png",
    "newimage.png"  // Add more images here!
};
```

### Stop Rotation When Buttons Click
```csharp
// In any button click:
isRunning = false;  // Stops the rotation thread
```

### Add Fade Effect (Advanced)
You could modify the code to fade images in/out instead of instant switching!

## Troubleshooting

### Images Don't Show
1. **Check file names** - Must match exactly (case-sensitive!)
2. **Check file location** - Images must be in the project folder
3. **Check file format** - Must be PNG, JPG, or BMP

### Images Look Stretched
```csharp
// Try different SizeMode values:
logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;          // Fits with proportions
logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;  // Fills box
logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;   // Centers, no resize
```

### Too Fast/Too Slow
```csharp
Thread.Sleep(3000);  // Adjust this number!
```

## Learning Points

? **Background threads** - Automatically stop when app closes
? **Continuous loops** - Using `while` for ongoing operations
? **File I/O** - Loading images from disk
? **Array cycling** - Using modulo (%) to loop through arrays
? **Exception handling** - Gracefully handling errors
? **PictureBox properties** - Image and SizeMode

## What to Tell Your Instructor

"I implemented a 4th thread that runs continuously in the background, rotating through three images every 3 seconds. I learned about:
- Background threads using `IsBackground = true`
- Continuous while loops in threads
- Loading images dynamically with `Image.FromFile()`
- Using modulo operator to cycle through an array
- Exception handling to prevent crashes if images are missing"

---

**Great job!** You now have a fully functional image rotation feature powered by threading! ??
