# interactive-human-body-mapping
Desktop application module that allows users to select body regions through an interactive human body diagram using pixel color mapping.

# Interactive Human Body Mapping Tool

This project was developed as part of a university software development project.

The goal was to allow users to select specific body regions through an interactive human body diagram instead of manually searching through a long list of anatomical areas.

## How it works

The system uses two images:

1. A visible image shown to the user.
2. A hidden reference image containing color-coded regions.

When the user clicks on the diagram:

- The application captures the pixel coordinates.
- It reads the pixel color from the reference image.
- The color is mapped to a table containing the corresponding body region.

This allows accurate identification of body parts through image interaction.

## Technologies

- C#
- Desktop Application Development
- Image-based interaction logic

## Context

This module was implemented as part of a collaborative university project. My contribution focused on the design and implementation of the interactive body-region selection system.
