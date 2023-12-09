
# Documentation
This document explains rapidly how to use the project. It is composed of two scenes, one usable in unity directly through the editor and the other one is to be used in AR, with an android device (Apple has not been tested).

Time took to make the project : ~25 hours.

Song used : [The Weeknd - Blinding Lights (Guy Arthur Remix)](https://www.youtube.com/watch?v=Ll1BPWvN044)

# Unity scene
The camera can be moved with the WASD / ZQSD keys. Use the mouse to rotate the camera.

Pressing "T" will remove the wall that is meant to obstruct the sound coming from the cube. To really see the difference, place yourself behind the wall and experience between switching it on and off.

This is a really quick way to test the audio spatialization on the computer and it is clearly not the most important scene.

# AR Scene

Here is an example of what can be done (sound needed) :
![Demo](https://github.com/TotallyNotAB0t/XRSound/assets/85309955/c2e83adc-1d4b-4fca-8b5f-7c2397fb8b5f)

This is where the fun begins.

You will need 4 Vuforia markers to setup the scene. The first one is an A4 format, in the center.
The next 3 are the Drone, Fissure and Oxygen samples from Vuforia.

The UI is made to work on Landscape mode. The applications takes some seconds to start, do not worry if the screens is black.

You need to track these markers at the same time so that our little moles starts making music.
When the trackers are gones, so are the moles and their music goes off.

- Left mole sings
- Up mole plays guitar
- Right moles plays piano (and other important things)
- The center of the scene (the A4 marker) plays bass

You can interact through hiding the moles with your hands to make them stop. Move around them to experience audio spatialization.

The UI on your phone is meant to do a bit more that just hiding moles. You can select one of the three moles and then choose to :

- Mute the audio source
- Create a wall around our mole, this will obfuscate the sound produced
- Modify the volume
- Modify the pitch
> **Note** : modifying the pitch this will also create a desynchronisation between the other moles, use at your own risks
# This is pretty much all there is to do.
Thanks for passing by.
