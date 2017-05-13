# Bomber Command
"Inspired" by reading of Bomber Command's horrific bombing of German cities during World War Two and my memories of this being one of the first computer games I ever played, on a VIC20 when I was 10 or 11 years old.

It is deliberately retro - how I remember the feel of the game - clunky, monochrome, an extremely simple mechanic and the forced sense of panic.

This version is also a deliberate attempt to explore object oriented design ideas that are generally outside what many people are practicing as OO. If this was performance constrained (e.g. being created on the original VIC20 in assembler or some crazy new 3D graphics) the implementation details would overwhelm the ability to model the problem in an object way. One of the possible benefits of this approach is the visibility of the "domain" at the top level - all the classes should be something relevant to the game.

... and yes I know that no serious games developer uses WinForms and GDI... 

## Instructions
You are a pilot on a bombing raid over an enemy city. You don't have enough fuel to get home so to survive you must raise the city and land on the cleared ground. Good luck!

## Screenshots

![Screenshot](screenshot.PNG)

## Known Issues
* A pure random distribution makes the game way too hard and possibly unwinnable in some situations. Need to hard code some sensible values or create a better distribution for the buildings.
* The window is a fixed size (in pixels) so is likely to look wrong on different resolution displays (it was developed on a MacBook Pro Retina display)

## Improvements
* Make the bomber look like a bomber
* Allow the game to be reset
* Add a score so even if you don't win you get some sense of satisfaction
* Split the graphics out from the core game classes to remove their GDI dependency

