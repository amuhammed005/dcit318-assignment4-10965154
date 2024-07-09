
# DCIT318_Assignment_4 

## Overview

This repository contains a Visual Studio solution with three projects: `LoginScreen`, `AddressBook`, and `CanvasDrawApp`. Each project serves a different purpose and utilizes Windows Forms for its graphical user interface.

## Projects

### 1. LoginScreen

#### Description
The `LoginScreen` project simulates a basic login interface where users can input a username and password. Upon clicking the "Login" button, a success message is displayed with the entered credentials. The "Cancel" button clears the input fields.

#### Features
- **Login Functionality:** Allows users to enter a username and password.
- **Success Message:** Displays a success message upon clicking the "Login" button.
- **Clear Input Fields:** Clears the username and password fields upon clicking the "Cancel" button.

#### Usage
1. **Run the application:** Start the `LoginScreen` application to access the login interface.
2. **Enter credentials:** Input a username and password.
3. **Login:** Click the "Login" button to see the success message.
4. **Clear fields:** Click the "Cancel" button to clear the input fields.

### 2. AddressBook

#### Description
The `AddressBook` project allows users to enter contact information including full name, email, and phone number. It validates the email format (presence of '@' symbol) and ensures the phone number contains only digits. Upon successful validation, a success message confirms the information saving.

#### Features
- **Contact Information Entry:** Users can enter full name, email, and phone number.
- **Validation:** Validates email format and phone number format.
- **Feedback Messages:** Displays success or error messages based on validation results.

#### Usage
1. **Run the application:** Start the `AddressBook` application to access the contact information interface.
2. **Enter contact details:** Input full name, valid email, and valid phone number.
3. **Save information:** Click the "Save" button to validate and save the information.
4. **Validation:** Ensures all fields are correctly filled and formats are valid.

### 3. CanvasDrawApp

#### Description
The `CanvasDrawApp` project is a drawing application where users can draw lines on a canvas using different colors. It provides radio buttons to select the drawing color (Red, Green, Black, Blue, Purple). Users can click and drag the mouse to draw lines of the selected color.

#### Features
- **Drawing Canvas:** Allows users to draw lines on a canvas.
- **Color Selection:** Provides options to select drawing color.
- **Real-time Drawing:** Draws lines based on mouse movement.

#### Usage
1. **Run the application:** Start the `CanvasDrawApp` to access the drawing interface.
2. **Draw on canvas:** Click and drag the mouse on the canvas to draw lines.
3. **Select color:** Choose a color using the radio buttons before drawing.
4. **Clear canvas:** Close and reopen the application to clear the canvas.

## Installation

1. **Clone the repository:**
   ```sh
   git clone <repository_url>
   ```
2. **Open the solution:**
   Open the `YourSolutionName.sln` file in Visual Studio.
3. **Build the solution:**
   Build the solution using Visual Studio to restore any required dependencies.
