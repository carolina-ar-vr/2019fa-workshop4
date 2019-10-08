# AR - Whuac-A-Moley

In this workshop you will be going over how to make an AR game using Unity and deploying to both Android and iOS. 

The Whuac-A-Moley game utilizes AR Foundation's multiple image tracking to spawn moles on images which you can "whac" to get points. Since the images can be moved and since there is no limit to how many images can be tracked; you have the ability to set up the Whuac-A-Moley game in any way your heart desires.

### What this Workshop covers
    1. Unity Basics
    2. UI in unity
    3. Scripting in Unity 
    4. Image Tracking using AR Foundation
    5. Building and Deploying to both Android and iOS

### What you will need: 
    1. Unity Game Engine installed with supporting packages
    2. VS-Code / Visual Studio
    3. Mouse

---

## **Unity Basics**


### The Unity Interface

![](/imgs/Interface.png)

#### The Hierarchy Window
The Hierarchy Window shows a list of all game objects in the scene, including game objects, camera, etc.

#### The Project Window
The project window displays all assets we have available to build the game with, such as meshes, scripts, materials.

#### The Inspector Window
The Inspector Window is a context sensitive window which shows us the properties of any object we want to see. It also lets us add components to individual game objects.

#### The Scene View
The Scene View is where we are going to visually build the game. It allow us to view the layout before and after running the game.

#### The Game View
The Game View allows us to preview our game in the editor. 

---

### Moving Around in Unity


![](/imgs/move.jpg)


The `HandTool` is used to move around in the Unity Scene

    1. Left Click and drag to move
    2. Right Click and drag to pan
    3. Scroll wheel to zoom in and zoom out

The `MoveTool` is used to move the selected objects

The `RotateTool` is used to rotate the selected objects

The `ScaleTool` is used to scale the selected objects

### Hot Keys

First select and object, then: 

`Q` Pan

`W` Move

`E` Rotate

`R` Scale

`F` Focus on selected object (very useful when you cannot find the object)


---

### How to add Objects, Create Scripts, Import Assets and Create Prefabs

#### Adding Objects to Scene: 


![](/imgs/createObject.JPG)


In Top Navigation Menu -> GameObject -> Whatever you want

---

#### Creating C# Scripts 


![](/imgs/createScript.JPG)



In the Project/Assets window -> right click -> create -> C# Script

---

#### How to Import PreMade Assets: 

![](/imgs/import.JPG)

--- 

#### How to make a Prefab: 


Prefabs are pre-configured game objects which you can reuse. They can be configured in the scene and then pulled into your assets folder to be reused. All prefabs have the same properties, meaning changing one of them will change all of them.


Steps to make a Prefab: 

    1. Select the GameObject in the hierarchy window that you want to make into a prefab.
    2. Drag the GameObject from the hierarchy window into your Project/Assets window. 
    3. The GameObject in hierarchy will have a name with blue font, indicating that it's now a prefab.


---


### Adding Components to GameObjects: 

You can add components to your GameObjects to configure them. Components could be anything from textures, materials, scripts, physics and particle systems to lighting and sound. Anything is possible. 

<img src="/imgs/addComponent.JPG"  height="400" width="200" >


Steps to Add Component: 

    1. Select the GameObject you want to add a component to
    2. Go to Inspector Window and click on Add Component
    3. Select the component you want to add. It could be pre-made compotents, or components you created and stored in Project Window such as scripts you have written. You can use the search bar on top.

---

## **Making the Whuac-A-Moly Game** 


### Set-Up:

    1. Git Clone project, url: https://github.com/carolina-ar-vr/Whuac-A-Mole.git
    2. Open Project in Unity


### First Steps 

    1. Install AR-Foundation using the Package manager
    2. Open Game Scene

    ![](/imgs/ardepen.JPG)


### Setting up the scene 


#### Add AR Components to Scene 

    1. GameComponents -> XR -> AR Session Origin
    2. GameComponents -> XR -> AR Session
    3. Add Reference Image Library

    ![](/imgs/image name)

#### Add Images to the Image Library 

#### Set Up AR-Camera 

    1. Attach TouchCaster.cs script to AR-Camera under AR Session Origin

### Set Up AR Session Origin

    1. Add AR Tracked Image Manager Script Component to AR Session Origin
    2. Drag the created Reference Image Library in the Script 
    3. Set Max Number of Moving Images to 10
    4. Drag the Mole Prefab into the Tracked Image Prefab

![](/imgs/arsesh.JPG)


---


## Lets Get Coding


 CARVR - HACK NC workshop
