Mars Rover Kata
===============================

This Kata will help you learn more about TDD development. The summary of this kata would be: Develop an api that moves a rover around on a grid.

Table of Contents
=================

  1. Preparing your machine
  2. Mars Rover Kata

Preparing your machine
===============

1.1. Installing Visual Studio
-----------------
Download visual studio installation from the link below and install it on your machine:
* https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx

1.2. Adding Visual Studio extensions
--------------------------------
Because we will be using Nunit, it will be useful to add Nunit test adapter extension to visual studio in order to run tests from within the test explorer:
* Open Visual Studio and go to Tools > Extensions and Updates.
* Search for NUnit test adapter on the online gallery and add it.

1.3. Creating the test project
---------------------------
Finally, create a new library project and add reference to the following packages via Nuget Manager console:
* Open Visual Studio and go to Tools > NuGet package manager > NuGet package manager console and type these commands.
* Install-Package NUnit
* Install-Package NSubstitute
   
Mars Rover Kata
===============

Rules:
1. You are given the initial starting point (x,y) of a rover and the direction (N,S,E,W) it is facing.
1. The rover receives a character array of commands.
1. Implement commands that move the rover forward/backward (f,b).
1. Implement commands that turn the rover left/right (l,r).
1. Implement wrapping from one edge of the grid to another. (planets are spheres after all)
1. Implement obstacle detection before each move to a new square. If a given sequence of commands encounters an obstacle, the rover moves up to the last possible point and reports the obstacle.


Additional links:
1. https://martinfowler.com/bliki/EvansClassification.html
1. https://www.culttt.com/2014/04/30/difference-entities-value-objects/
1. http://www.jspcore.com/mars-rover-kata/
