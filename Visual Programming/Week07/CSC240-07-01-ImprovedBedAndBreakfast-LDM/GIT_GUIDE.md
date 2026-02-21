# Git Commands Guide - Pushing Your Week 7 Project to GitHub

## Step-by-Step Instructions

### Step 1: Open Terminal in Visual Studio
1. In Visual Studio, go to **View** ? **Terminal**
2. Or press **Ctrl + `** (that's the backtick key, usually above Tab)

### Step 2: Make Sure You're in the Right Folder
```powershell
cd "D:\SCHOOL\SCHOOL\GitHubFolder\CSC-240 Visual Programming\Git\CSC240"
```

### Step 3: Check Git Status
See what files have changed:
```powershell
git status
```

You should see files like:
- Form1.cs (modified)
- Form1.Designer.cs (modified)
- README.md (modified)
- THREADING_GUIDE.md (new file)
- DESIGN_GUIDE.md (new file)

### Step 4: Add Your Changes
Add all the changed files to be committed:
```powershell
git add .
```

The `.` means "add everything in the current folder"

Or, add specific files:
```powershell
git add "Visual Programming/Week07/CSC240-07-01-ImprovedBedAndBreakfast-LDM/Form1.cs"
git add "Visual Programming/Week07/CSC240-07-01-ImprovedBedAndBreakfast-LDM/Form1.Designer.cs"
git add "Visual Programming/Week07/CSC240-07-01-ImprovedBedAndBreakfast-LDM/README.md"
git add "Visual Programming/Week07/CSC240-07-01-ImprovedBedAndBreakfast-LDM/THREADING_GUIDE.md"
git add "Visual Programming/Week07/CSC240-07-01-ImprovedBedAndBreakfast-LDM/DESIGN_GUIDE.md"
```

### Step 5: Commit Your Changes
Save your changes with a message:
```powershell
git commit -m "Improved Week 7 B&B project with threading, better colors, and enhanced layout"
```

### Step 6: Push to GitHub
Send your changes to GitHub:
```powershell
git push origin cardealer-code-LDM
```

(The branch name is `cardealer-code-LDM` based on your workspace info)

## If You Get Errors

### Error: "Please tell me who you are"
Set up your name and email:
```powershell
git config --global user.name "Your Name"
git config --global user.email "your.email@example.com"
```

Then try the commit again.

### Error: "Updates were rejected"
Someone else pushed changes, so you need to pull first:
```powershell
git pull origin cardealer-code-LDM
```

Then push again:
```powershell
git push origin cardealer-code-LDM
```

### Error: "Authentication failed"
You might need to log in to GitHub. Visual Studio should prompt you.

## Full Workflow (All Steps Together)

Here's the complete sequence of commands:

```powershell
# Navigate to your repository
cd "D:\SCHOOL\SCHOOL\GitHubFolder\CSC-240 Visual Programming\Git\CSC240"

# Check what changed
git status

# Add all changes
git add .

# Commit with a message
git commit -m "Week 7: Improved B&B with threading, better design, and documentation"

# Push to GitHub
git push origin cardealer-code-LDM
```

## Understanding Git Commands

| Command | What It Does | When to Use It |
|---------|--------------|----------------|
| `git status` | Shows what files changed | Before adding/committing to see what's different |
| `git add .` | Stages all changes | Before committing to select which changes to save |
| `git commit -m "message"` | Saves changes with a description | After adding, to create a checkpoint |
| `git push` | Uploads to GitHub | After committing, to share your work |
| `git pull` | Downloads from GitHub | Before starting work, to get latest changes |

## Good Commit Messages

### ? Good Examples
- "Added threading to all three buttons"
- "Improved color scheme and layout"
- "Week 7: Enhanced B&B project with documentation"
- "Fixed loading label visibility issue"

### ? Bad Examples
- "stuff" (not descriptive)
- "asdf" (meaningless)
- "changes" (too vague)
- "fix" (what did you fix?)

## Checking Your Work on GitHub

After pushing:
1. Go to https://github.com/MUMfordSCHOOLaccount/CSC240
2. Click on the `cardealer-code-LDM` branch
3. Navigate to `Visual Programming/Week07/CSC240-07-01-ImprovedBedAndBreakfast-LDM/`
4. You should see all your files there!

## Tips

1. **Commit often**: Make commits after each major change
2. **Write clear messages**: Explain what you did in your commit message
3. **Pull before push**: Always `git pull` before starting work
4. **Check status**: Use `git status` frequently to see what's changed
5. **Don't commit build files**: The `.gitignore` file should handle this automatically

## Quick Reference Card

```powershell
# See what changed
git status

# Add everything
git add .

# Save changes
git commit -m "Your message here"

# Upload to GitHub
git push

# Download from GitHub
git pull
```

## Need Help?

If you get stuck:
1. Read the error message carefully
2. Try the solutions in the "If You Get Errors" section
3. Search for the error message online
4. Ask your instructor or classmates

---
**Remember:** Git is like a time machine for your code. Each commit is a save point you can return to!
