# Class 1

In this first class, you'll learn the following:
- use the game engine for basic tasks (moving the camera, creating and modifying assets, etc)
- create an object
- add components to an object
- modify properties of an object / its components
- retrieve user inputs
- understand basic principles of the physics system (colliders, rigidbodies)

## Creating a new project

Make sure you have the Unity version 6000.0.24f1 or later (earlier versions might use deprecated systems, but you should still be able to follow the class since it covers some general knowledge of the game engine).

Click on `new_project` and select the `Universal 3D` Template. You can set your project name and folder on the right. Once you're done setting up, click on `Create project`. The unity editor should start loading a new project.

![new project image](ClassTutorialAssets/new_project.png)  
![Universal 3D image](ClassTutorialAssets/urp.png)

## Navigating the editor

You should have spawned inside the editor, and your screen should look something like this:

![editor spawn point image](ClassTutorialAssets/editor_first_start.png)

There are a few different windows. 

*(MMB = Middle Mouse Button, RMB = Right Mouse Button, etc)*
- In the center, the `Scene` window. This is the place where you'll edit your game levels and ui. 
Use **MMB** to pan the view, **Shift + RMB** to rotate the view and **Scroll** to zoom in and out.

Now that you know how to move around in the scene, let's add an object to it. 
Go to the `GameObject` menu on the top of the editor, and under `3D Object`, click on `Cube`.
![creating a cube](ClassTutorialAssets/create_cube.png)

- On the left is the `Hierarchy`. If you haven't clicked anything after creating your cube, you should see that you can rename it as you want. 
The window represents the scene tree, where you'll find all the objects in the current scene. 
Make sure your cube is selected in the hierarchy (it should be highlighted in grey or blue).

You can press **F** while your cursor is over the Scene window to focus the currently selected object. 
This is extremely useful if you want to navigate directly to a specific object in your scene.
Use **Alt + LMB** to rotate around the currently focused object.

If you have multiple objects on top of each other, using **Ctrl+RMB** lets you choose which object you want to select without having to spam click until you have the right one.


- The tab `Game` next to `Scene` is where you'll be able to playtest your game. 
- At the bottom is the `Project` window. There, you'll find all your files and assets for this project. They can be found on your computer at `/path_to_project/Assets`.
It's best to keep it organized in different folders as the further in size your project grows, the harder it will be to find your files if not organized.
- You can find a few different tabs along the `Project` one, such as `Console` or `Animation`. `Console` will be where errors/warnings are reported, and where you'll be able to print debug states.
- On the right is the `Inspector`. In this window, you will be able to edit the properties of your objects. 

If your cube is still selected, you should see a bunch of different options such as `Transform`, `Mesh Rendered` or `Box Collider`.
These are the components/scripts attached to your object. By default, all GameObjects come with a Transform. 
It's the component handling the position, rotation and scale of your object in the scene. 
You can try changing the values and the cube should react accordingly
(you can also click and drag on the variable names (`x`, `y`...) to change the value).
Likewise, moving the object with the arrows handle on the scene window will change the value in the inspector.

We will now test our super game! To enter play mode, you can press the play button at the top center (or hit **Ctrl+P**). 
You should automatically be switched to the Game window. If you haven't moved your cube too far out, it should appear on the screen. 
What we currently see is the point of view of the camera object. You can select it in the hierachy and move it. 
You can also add other objects by right-clicking in the hierarchy.
![play mode](ClassTutorialAssets/playmode.png)
Now exit play mode (the stop button or **Ctrl+P**, not the pause one which lets you skip frame by frame, often used for debug).
Oh no! The second cube has disappeared, along with the modifications we made to the camera. Did we forget to save something? 
Actually, no. Even if we had tried to save our project, it wouldn't have worked. 
When you are in play mode, all changes that you make to the scene won't be saved. 
It is useful to test things without destroying the scene you just spent hours creating. 
However, remember to exit playmode before making permanent changes.

## Creating a simple scene
