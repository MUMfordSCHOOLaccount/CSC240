# Bailey's Bed & Breakfast - Improved Version

## Project Overview
This is the **Week 7 Improved** Bed and Breakfast project for Visual Programming (CSC-240). It builds upon the Week 6 version with enhanced design, better colors, improved layout, and beginner-level threading.

## What's New in Week 7
### Visual Improvements
- **Better Color Scheme**: Changed from bright yellow to a soft AliceBlue background with coordinating colors
- **Improved Fonts**: Using modern Segoe UI font family with different sizes and styles
- **Better Layout**: Increased form size to 800x500 pixels for more breathing room
- **Picture Box**: Added a logo area (you can add your own image later!)
- **GroupBox**: Controls are organized in a nice group box for better visual organization
- **Description Label**: Added a welcoming description of the B&B

### New Features
- **Three Interactive Buttons**: 
  - View Room Rates
  - Make Reservation
  - Our Amenities
- **Loading Messages**: Shows feedback while "loading" data
- **More Information**: Each button provides different helpful information

### Threading Implementation (Beginner Level)
This project now includes **4 separate threads** to demonstrate basic multi-threading concepts:

1. **Thread 1 - LoadRates()**: Runs on a separate thread when clicking "View Room Rates"
2. **Thread 2 - CheckAvailability()**: Runs on a separate thread when clicking "Make Reservation"
3. **Thread 3 - ShowAmenities()**: Runs on a separate thread when clicking "Our Amenities"
4. **Thread 4 - RotateImages()**: Runs continuously in the background, rotating through 3 images every 3 seconds! ⭐

#### How Threading Works in This Project
- When you click a button, it starts a new thread
- The button is disabled so you can't click it again while loading
- A loading message appears to give user feedback
- The thread sleeps for 1.5-2 seconds to simulate getting data from a database
- After loading, the thread uses `Invoke()` to safely update the UI
- Finally, the button is re-enabled and the loading message disappears

#### Why Use Threads?
In a real application, you might need to:
- Get data from a database (which takes time)
- Connect to the internet to check availability
- Process large amounts of data

Threading prevents the form from "freezing" while doing these tasks!

## Color Scheme Used
- **Background**: AliceBlue (soft, calming blue-white)
- **Title Text**: DarkSlateBlue (professional, readable)
- **Subtitle Text**: SlateGray (subtle, elegant)
- **Buttons**: LightSteelBlue (matches the theme)
- **GroupBox**: Lavender (soft accent color)
- **Loading Text**: DarkOrange (stands out for important feedback)

## Room Rates
- Standard Room: $75 per night
- Deluxe Room: $120 per night
- Suite: $200 per night

## Technical Details
- **Framework**: .NET 8
- **Language**: C# 12.0
- **UI Framework**: Windows Forms
- **IDE**: Visual Studio 2022
- **Threading**: Basic Thread class usage with Invoke for UI updates

## How to Use
1. Run the application
2. Click any of the three buttons to see different information
3. Watch the loading message appear (demonstrates threading!)
4. Read the information in the message boxes

## Future Enhancements You Could Add
- Add a real image to the PictureBox (right-click > Properties > Image)
- Change button colors when hovering (MouseEnter/MouseLeave events)
- Add a date picker for selecting check-in dates
- Create a custom dialog instead of using MessageBox
- Add sound effects (optional, for fun!)

## Learning Points
- How to use different colors and fonts in Windows Forms
- How to organize controls using GroupBox
- Basic threading with the Thread class
- Using Invoke() to safely update UI from another thread
- Enabling/disabling controls based on application state
- Providing user feedback during operations

## Author
Created for CSC-240 Visual Programming course - Week 7

---
*This is an improved version of the Week 6 project, demonstrating growth in design skills and basic threading concepts.*
