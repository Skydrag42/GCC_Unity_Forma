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

### Basic shapes

Now that you know how to get around the editor a little, let's have a little fun by creating a small scene. 
I'll only use cubes, but you can try the other primitives too (cylinder, sphere, etc). 
The shortcut **Ctrl+D** lets you duplicate the currently selected object.
Don't forget to rename your objects to keep your scene hierarchy tidy.
By rotating, moving and scaling the objects, you can easily get sometehing that looks like this:

![cubic scene](ClassTutorialAssets/cube_scene.png)

### Colors
Although, even if the scene looks better now, it's still missing something to make it interesting.
So, how do we add colors? By creating what's called `Materials`. 
They are assets that define the looks of an object (colors, textures, shaders...), 
and they can be assigned to a `Renderer` component for the engine to use them. 
If you look at the inspector of any of your cubes, you should see a `MeshRenderer` component.
It has a field named `Materials` where you can assign multiple materials (though we'll only use one for each object).

![renderer materials](ClassTutorialAssets/renderer_materials.png)

To create a new material, we will go to our Project window at the bottom. 
First, we will create a new folder (Right-click, Create -> Folder) inside the Assets folder and name it *Materials*.
Then, the same way, we will create a Material in it and name it *Black*
(or *MaterialBlack*, or any other name that will help you know what it represents).
You should see it appear along with new inspector options on the right.

![material inspector](ClassTutorialAssets/material_inspector.png)

For now, we will only be interestede in one setting, `Base Map` under `Surface Inputs`. 
You can then click on the white bar (the color slot) and choose the color of your material (black here).
Once that's done, you can drag and drop your material to any object on your scene and it should automatically apply itself to the renderer
(you can check by yourself, though the apparent color should be a great indicator).

With this, try and make your scene a little more colorful. Mine looks like this:

![colored scene](ClassTutorialAssets/colored_scene.png)

### Prefabs
Let's say you made a cool structure, and you want to reuse it. 
Do you have to select all the items that make it, then duplicate them and move them in place?
Quite tedious, and not very scalable. But of course, there's a solution for that. 
First, lets make a small ramp with two cubes. We will also create an empty object and call it *Ramp*. 
Then, we drag and drop (in the hierarchy) the two cubes that make up our ramp to the empty *Ramp* object to make them childs of it.

![cube ramp](ClassTutorialAssets/cube_ramp.png)

That way, we can already duplicate our ramp more easily by only selecting the parent object. 
It is also a way to organize and tidy our hierarchy. I will do something similar with our objects by making an empty *Environment*
that will contain all of the environment props. And just before adding any children to it, I'll make sure its transform 
is reset to default values to avoid strange problems later down the line 
(you can do so by Right-clicking on the Transform component and selecting `reset`).

![environment empty object](ClassTutorialAssets/environment_empty_object.png)

But our work here is not done. You might want to reuse this structure in another scene (we'll have a look at scene in another class), 
or even be able to make one change and have it applied to all instances of your structure, like a different color.
For that, we are going to use `Prefabs`. Prefabs are assets (meaning they are stored in your project files, not in the scene)
and can be reused from anywhere in your project or even your friend's.
To create a prefab, simply drag and drop the object you want to make a prefab of to your `Project` window. 
It should now appear blue in the hierarchy. 
Don't forget to keep your project tidy by placing your assets in corresponding folders.

![ramp prefab](ClassTutorialAssets/ramp_prefab.png)

You can now simply drag and drop your prefab from your project files to the scene (or the hierarchy) and it will be added.
You might notice some offset between your cursor and the prefab while dragging it, or the ramp floating in the air when you drop it.
That is because the ramp object itself has a default position that is not zero, and the object that compose it are not centered around
the empty object. To fix that, we will enter `Prefab mode` by double clicking on the prefab 
(or clicking the little arrow left of the instanciated prefab in the hierarchy to see it in context mode).

We can start by resetting the transform of the prefab 
(if you can't, that's because you are in context mode and some settings can't be changed there, try opening from the project window).
The ramp should disappear from the view. That's because the position of a child is relative to that of its parent.
So we now have to move the children back to the center of the object.
To facilitate the task, you can add a plane or any other primitive and set its position to zero so you have a visual cue.
Once you're done, don't forget to save your prefab, 
and you might have to move your ramp back on the scene as the changes we made to the prefab were also applied to the instances.

### Physics

Finally, we will add a sphere juste above the ramp so it will roll down and position our camera. 
An easy way to setup the camera is to move the view where you want, an then select the camera, go to `GameObject` and `Align With View`.

![camera and sphere setup](ClassTutorialAssets/camera_and_sphere_setup.png)

Now hit play and...
Well, that's a bummer. The sphere didn't roll down as we expected.

That is because we haven't told the engine that we wanted to simulate our object, so it doesn't do anything. 
And if we were to simulate all objects, it would make it way too slow and often unrealistic 
as static objects would sometimes move due to small errors.
However, by default each primitive comes with its own collider, which will define where the object will collide with simulated objects.

To simulate the sphere, simply go to its inspector and click on `Add Component` at the bottom. 
You can then type `Rigidbody` and select the corresponding component (not the 2D one).
Hit play again, and this time it works! Yay!

## Adding a player

