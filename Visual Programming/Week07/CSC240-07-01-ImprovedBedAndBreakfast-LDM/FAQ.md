# Frequently Asked Questions (FAQ)

## General Questions

### Q1: What's the main difference between Week 6 and Week 7 projects?
**A:** Week 7 has:
- Better colors (AliceBlue instead of bright Yellow)
- More controls (3 buttons instead of 1, plus PictureBox, GroupBox, etc.)
- Threading! (3 separate threads for learning)
- Better layout and spacing
- More professional appearance

---

## Threading Questions

### Q2: What is threading and why do I need it?
**A:** Threading lets your program do multiple things at once. Without it, when your program is working (like loading data), the whole window freezes. With threading, the window stays responsive and users can see loading messages.

### Q3: What does `Thread.Sleep(1500)` do?
**A:** It makes the thread wait for 1500 milliseconds (1.5 seconds). In this learning project, it simulates work being done (like getting data from a database). In a real app, you'd replace this with actual work.

### Q4: Why do we use `this.Invoke(...)`?
**A:** Because only the main UI thread can update the form. When we create a new thread to do work, that thread can't directly change the UI. We use `Invoke()` to safely ask the UI thread to make the changes for us.

### Q5: What happens if I don't use `Invoke()`?
**A:** Your program will crash with an error like "Cross-thread operation not valid". This error means you're trying to update the UI from the wrong thread.

### Q6: Can I have more than 3 threads?
**A:** Yes! You can create as many threads as you need. This project uses 3 to show different examples, but you could add more buttons with more threads.

### Q7: Do the threads run at the same time?
**A:** Yes! If you click all three buttons quickly, all three threads will be running at the same time. That's why we disable the buttons - to prevent creating too many threads at once.

---

## Design Questions

### Q8: How do I add a real image to the PictureBox?
**A:** 
1. Open Form1 in the Designer (double-click Form1.Designer.cs)
2. Click on the PictureBox
3. In the Properties window, find "Image"
4. Click the "..." button next to Image
5. Select "Local resource"
6. Click "Import" and choose your image file
7. Set "SizeMode" to "StretchImage" or "Zoom" to fit the box

### Q9: Can I change the colors?
**A:** Absolutely! Colors are set in `Form1.Designer.cs` in the `InitializeComponent()` method. Look for lines like:
```csharp
this.BackColor = System.Drawing.Color.AliceBlue;
```
Change `AliceBlue` to any other color name (like `LightGreen`, `Lavender`, `Honeydew`, etc.)

### Q10: How do I change the form size?
**A:** Find this line in `Form1.Designer.cs`:
```csharp
this.ClientSize = new System.Drawing.Size(800, 500);
```
Change the numbers (800 is width, 500 is height). Try `1000, 600` for a bigger form!

### Q11: Can I change the button text?
**A:** Yes! Find the button in `Form1.Designer.cs` and change its Text property:
```csharp
this.showRatesButton.Text = "View Room Rates";  // Change this text!
```

---

## Code Questions

### Q12: Where is the code that runs when I click a button?
**A:** In `Form1.cs`, look for methods with names like:
- `showRatesButton_Click` - runs when you click "View Room Rates"
- `reservationButton_Click` - runs when you click "Make Reservation"
- `amenitiesButton_Click` - runs when you click "Our Amenities"

### Q13: What does `sender` and `e` mean in the button click methods?
**A:** 
- `sender` - the control that was clicked (the button)
- `e` - event arguments (extra information about the click)
For now, you don't need to use them, but they're required by C#.

### Q14: What's the difference between Form1.cs and Form1.Designer.cs?
**A:** 
- **Form1.cs** - Your code logic (what happens when buttons are clicked)
- **Form1.Designer.cs** - The visual design (what the form looks like, where controls are placed)
- Generally, you write code in Form1.cs and use the Designer for Form1.Designer.cs

### Q15: Why do some methods start with `private`?
**A:** `private` means the method can only be used inside this class. Since our methods are only used by this form, they're private. Public methods can be called from anywhere.

---

## Error Questions

### Q16: I get an error "loadingLabel does not exist in the current context"
**A:** Make sure `loadingLabel` is declared in `Form1.Designer.cs` in the field declarations at the top:
```csharp
private System.Windows.Forms.Label loadingLabel;
```
And make sure it's created in `InitializeComponent()`.

### Q17: The form looks wrong when I run it
**A:** Make sure you saved all files (Ctrl+Shift+S) and rebuilt the project (Ctrl+Shift+B).

### Q18: My changes don't appear when I run the program
**A:** 
1. Make sure you saved the files
2. Rebuild the project (Build ? Rebuild Solution)
3. Make sure you're editing the right project (Week 7, not Week 6!)

---

## Git/GitHub Questions

### Q19: How do I upload my project to GitHub?
**A:** See the `GIT_GUIDE.md` file for step-by-step instructions. The basic steps are:
1. `git status` (see changes)
2. `git add .` (stage changes)
3. `git commit -m "message"` (save changes)
4. `git push` (upload to GitHub)

### Q20: What branch should I push to?
**A:** Based on your workspace, you're on the `cardealer-code-LDM` branch, so use:
```powershell
git push origin cardealer-code-LDM
```

---

## Learning Questions

### Q21: What should I learn next?
**A:** Some ideas:
1. Add more buttons with different functions
2. Try using async/await instead of Thread (more modern)
3. Add a TextBox for user input
4. Create a custom dialog instead of MessageBox
5. Add mouse hover effects to buttons

### Q22: How can I practice threading more?
**A:** Try these exercises:
1. Create a countdown timer using a thread
2. Make a progress bar that fills up while loading
3. Add a "Cancel" button that stops a running thread
4. Create multiple threads that update different labels

### Q23: What are some beginner mistakes to avoid?
**A:** 
1. ? Forgetting to use `Invoke()` when updating UI from a thread
2. ? Not disabling buttons before starting threads
3. ? Using very bright colors (like pure Yellow)
4. ? Making text too small or too large
5. ? Not providing user feedback (loading messages)
6. ? Committing to Git without a clear message

---

## Project-Specific Questions

### Q24: Can I change the business from a B&B to something else?
**A:** Yes! You could make it a hotel, restaurant, car dealer, etc. Just change:
- The form title
- The welcome message
- The button names and functions
- The information shown in message boxes

### Q25: How do I make this my portfolio piece?
**A:** 
1. Add a real logo image
2. Choose colors that look professional together
3. Write clear, descriptive text
4. Make sure everything is spelled correctly
5. Test all the buttons
6. Add comments to your code explaining what it does
7. Upload to GitHub with good commit messages

### Q26: What should I tell my instructor about this project?
**A:** Key points to mention:
- "I learned basic threading using the Thread class"
- "I implemented 3 separate threads for different functions"
- "I used Invoke() to safely update the UI from worker threads"
- "I improved the design with better colors, fonts, and layout"
- "I organized controls using a GroupBox"
- "I provided user feedback with loading messages"

---

## Troubleshooting

### Q27: My loading label never disappears
**A:** Make sure:
1. You set `loadingLabel.Visible = false;` in the constructor
2. You set it to `false` inside the `Invoke()` block after showing the message
3. The code inside `Invoke()` is actually running (add a MessageBox.Show to test)

### Q28: When I click a button, nothing happens
**A:** Check that:
1. The button's Click event is connected in Designer.cs: `+= new System.EventHandler(...)`
2. The method name matches exactly
3. The project has been rebuilt

### Q29: The window freezes when I click a button
**A:** This means the thread isn't working. Make sure:
1. You're creating a new Thread: `Thread myThread = new Thread(MethodName);`
2. You're starting it: `myThread.Start();`
3. You're not calling the method directly: `LoadRates()` ? vs `new Thread(LoadRates).Start()` ?

---

## Need More Help?

1. **Read the guides**: Check `THREADING_GUIDE.md` and `DESIGN_GUIDE.md`
2. **Check your code**: Compare with the examples in the guides
3. **Search online**: Copy the error message and search for it
4. **Ask for help**: Talk to your instructor or classmates
5. **Start small**: If something doesn't work, simplify it first

---

**Remember:** Everyone struggles when learning to program. The key is to keep trying, ask questions, and learn from mistakes!
