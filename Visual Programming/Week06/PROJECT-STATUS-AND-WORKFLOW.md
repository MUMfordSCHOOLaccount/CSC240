# Project Cleanup and Git Workflow Summary

## Current Projects Status

### 1. CSC240-06-01-BedAndBreakfast-LDM ?
**Location:** `CSC240-06-01-BedAndBreakfast-LDM/`
**Status:** Complete and correct
**Files:**
- Form1.cs (with showRatesButton_Click event handler)
- Form1.Designer.cs
- Form1.resx
- Program.cs
- CSC240-06-01-BedAndBreakfast-LDM.csproj
- CSC240-06-01-BedAndBreakfast-LDM.sln

### 2. CSC240-06-02-FiveColors2-LDM ?
**Location:** `CSC240-06-02-FiveColors2-LDM/`
**Status:** Complete with all requirements
**Files:**
- MainForm.cs (with color change and reset functionality)
- MainForm.Designer.cs (5 radio buttons + reset button)
- MainForm.resx
- Program.cs
- FiveColors2.csproj
- CSC240-06-02-FiveColors2-LDM.slnx

**Features Implemented:**
- 5 RadioButtons (Red, Green, Blue, Yellow, Purple)
- Reset button that clears selections and restores default background
- Proper event handlers for color changes

---

## Issues Found (To Be Fixed)

### Duplicate/Misplaced Folders:
1. ? `CSC240-06-01-BedAndBreakfast-LDM\FiveColors2\` - Should NOT exist here
2. ? `CSC240-06-01-BedAndBreakfast-LDM\Visual Programming\Week06\CSC240-06-02-FiveColors2-LDM\` - Duplicate nested path

---

## Cleanup Steps

### Step 1: Run the Cleanup Script
```powershell
.\cleanup-duplicates.ps1
```

### Step 2: Verify the Cleanup
After running the script, your Week06 folder should contain ONLY:
```
Week06/
??? CSC240-06-01-BedAndBreakfast-LDM/
?   ??? Form1.cs
?   ??? Form1.Designer.cs
?   ??? Form1.resx
?   ??? Program.cs
?   ??? CSC240-06-01-BedAndBreakfast-LDM.csproj
?   ??? CSC240-06-01-BedAndBreakfast-LDM.sln
?
??? CSC240-06-02-FiveColors2-LDM/
?   ??? MainForm.cs
?   ??? MainForm.Designer.cs
?   ??? MainForm.resx
?   ??? Program.cs
?   ??? FiveColors2.csproj
?   ??? CSC240-06-02-FiveColors2-LDM.slnx
?
??? cleanup-duplicates.ps1 (this cleanup script)
```

---

## Git Workflow (Required for Assignment)

### Current Branch
You are on: `fivecolors-code-LDM`

### Expected Branches for Assignment 6.1 (Bed & Breakfast):
1. `bedandbreakfast-design-LDM` - For GUI design
2. `bedandbreakfast-code-LDM` - For coding implementation

### Expected Branches for Assignment 6.2 (Five Colors):
1. `fivecolors-design-LDM` - For GUI design
2. `fivecolors-code-LDM` - For coding implementation (? Current branch)

### Git Commands to Complete the Workflow:

#### For the current FiveColors cleanup:
```bash
# Stage all changes
git add .

# Commit the cleanup
git commit -m "Clean up duplicate folders and finalize FiveColors2 implementation"

# Push to GitHub
git push origin fivecolors-code-LDM

# Go to GitHub and create a Pull Request
# Merge fivecolors-code-LDM into main

# Switch back to main
git checkout main
git pull origin main
```

#### To verify all branches exist:
```bash
git branch -a
```

You should see:
- bedandbreakfast-design-LDM
- bedandbreakfast-code-LDM
- fivecolors-design-LDM
- fivecolors-code-LDM
- main

---

## Assignment Submission Checklist

### Assignment 6.1 - Bed and Breakfast:
- [ ] bedandbreakfast-design-LDM branch created and merged
- [ ] bedandbreakfast-code-LDM branch created and merged
- [ ] Form has "Bailey's Bed and Breakfast" title
- [ ] Two labels with correct text and formatting
- [ ] Button that shows room rates in MessageBox
- [ ] Instructor invited as collaborator
- [ ] Screenshot of GitHub Code screen taken

### Assignment 6.2 - Five Colors:
- [ ] fivecolors-design-LDM branch created and merged
- [ ] fivecolors-code-LDM branch created and merged
- [ ] 5 RadioButtons (Red, Green, Blue, Yellow, Purple)
- [ ] Form background changes when radio button clicked
- [ ] Reset button clears selections and restores default
- [ ] Instructor invited as collaborator
- [ ] Screenshot of GitHub Code screen taken

---

## Next Actions

1. **Run cleanup script:** `.\cleanup-duplicates.ps1`
2. **Stage changes:** `git add .`
3. **Commit:** `git commit -m "Clean up duplicate folders"`
4. **Push:** `git push origin fivecolors-code-LDM`
5. **Go to GitHub** and create Pull Request to merge into main
6. **Check all branches exist** - create any missing ones if needed
7. **Invite instructor** as collaborator on GitHub
8. **Take screenshot** of GitHub Code screen
9. **Submit to assignments**

---

## GitHub Repository
**URL:** https://github.com/MUMfordSCHOOLaccount/CSC240
**Current Branch:** fivecolors-code-LDM
