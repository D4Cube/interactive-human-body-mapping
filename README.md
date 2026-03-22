# Interactive Human Body Mapping Tool

This project is a desktop application module developed in C# that allows users to select specific body regions through an interactive human body diagram.

## 🧠 Problem

In the original system, users had to manually search through a long list of over 100 anatomical regions to register data, which was inefficient and error-prone.

## 💡 Solution

I designed and implemented an interactive image-based selection system that allows users to click directly on a body diagram.

## ⚙️ How it works

The system uses two images:

- A **visible image** displayed to the user
- A **hidden reference image** with color-coded regions

When the user clicks on the image:

1. The application captures the click coordinates
2. Reads the pixel color from the reference image
3. Maps the color to a predefined body region
4. Automatically fills the corresponding field

## 🛠 Technologies

- C#
- Desktop Application Development
- Image Processing Logic
- GitHub

## 👨‍💻 My Role

- Designed the interaction logic
- Implemented pixel detection system
- Created mapping logic between colors and body regions

## 📌 Notes

This project was developed as part of a university team project. My contribution focused on the interactive body selection feature.

## 🚀 Future Improvements

- Improve UI/UX design
- Add zoom and precision selection
- Integrate with database system
