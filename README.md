
# Project Documentation

## Overview
This document provides a concise guide on how to use the project. It consists of two scenes: one for Unity, accessible directly through the editor, and the other for AR, designed for Android devices (Apple compatibility has not been tested).

### Project Details
- **Development Time**: Approximately 25 hours.
- **Song used**: [The Weeknd - Blinding Lights (Guy Arthur Remix)](https://www.youtube.com/watch?v=Ll1BPWvN044)

## Unity Scene
In the Unity scene, users can control the camera using the following keys:  

- **WASD / ZQSD**: Move the camera.
- **Mouse**: Rotate the camera.

Additional functionality:  

- Pressing **"T"** removes the wall that obstructs sound from the cube. To observe the difference, position yourself behind the wall and toggle it on and off.
- While this scene primarily serves as a quick test for audio spatialization on the computer, it's not the focal point of the project.

## AR Scene
The AR scene is where the real fun begins! Here's what you can do (sound required): [Demo](https://drive.google.com/file/d/1bAaKD3Tc6uA5Z4wJqYtyfNvEWL3Yz5xx/view?usp=sharing)

### Setup Instructions:
1. **Vuforia Markers**: You'll need four Vuforia markers:
   - The first marker is an A4 format, positioned at the center. Here is the [file](https://drive.google.com/file/d/1FN74YKgntXEf8v9C3SqrSgmHMn3QvDcY/view?usp=sharing).
   - The remaining three markers represent the Drone, Fissure, and Oxygen samples from Vuforia.

2. **UI and Landscape Mode**:
   - The UI is optimized for landscape mode.
   - The application may take a few seconds to start; don't worry if the screen appears black initially.

3. **Mole Music Ensemble**:
   - To activate our musical moles, track all four markers simultaneously.
   - When the markers are lost, the moles stop playing their instruments.
   - Each mole has a role:
     - **Left Mole**: Sings
     - **Up Mole**: Plays guitar
     - **Right Mole**: Masters the piano (and other important things)
     - **Center (A4 Marker)**: Provides the bassline

4. **Interaction**:
   - Interact by hiding the moles with your hands to silence them.
   - Move around the moles to experience audio spatialization.

5. **Mobile UI**:
   - The UI on your phone offers more than just mole-hiding capabilities. You can select one of the three moles and:
     - **Mute the Audio Source**
     - **Create a Sound-Obfuscating Wall**: Surround a mole to alter the sound it produces.
     - **Modify Volume**
     - **Modify Pitch**

> **Note** : modifying the pitch this will also create a desynchronisation between the other moles, use at your own risks.  

## This is pretty much all there is to do.
Thanks for passing by.
