# Class 4

In this third class, you'll learn the following:
- Adding sound effects / music
- Importing unity packages
- Using Unity's AI Navigation system
- Spawning GameObjects
- Creating a custom shader

## Adding sound effects

We'll start off quite easily, since all you have to do for now is to import 
[this chest sound effect](ClassTutorialAssets/chest_opening.wav).
Once you're done, go to your chest prefab and add a `AudioSource`component. 
Assign the audio clip, untick the play on awake button and you're almost done. 

There are quite a lot of parameters to customize your sound, 
however there is no easy way to test the AudioSource in the editor 
*(mostly because it needs an AudioListener to spatialize the sound and 
using one on the editor camera could be very confusing when you don't know 
what's happening, but you can still write your own editor script to allow 
such a behaviour)*, so if you want to try out different settings, 
you could simply tick the PlayOnAwake and loop options before entering
play mode and then switching test the values. 

For now, just changing the pitch to 0.6 or leaving it as is should be enough
to get a decent sfx.

Now, the only thing left is to tell our chest to play the sound effect when opened.

```cs
// ...
AudioSource sfx;

private void Start()
{
	// ...
	sfx = GetComponent<AudioSource>();
}

public void Interact()
{
	// ...

	sfx.Play();
}

```

## Adding a slime

If you have correctly followed the previous classes, 
this part should not give you any trouble. 

Import the [Slime](ClassTutorialAssets/Class4/lp_slime.fbx) model 
and give him a collider (and a color if you want to). 
Add an animator controller to play the Idle animation. 
Don't forget to check the `Loop Time` import setting
in the model animation tab for the Idle animation, 
otherwise it will only play once.

![slime](ClassTutorialAssets/Class4/img/slime.png)


## The AI Navigation package

Now that we have an entity in our game, we will be adding it a 
pathfinding algorithm that will make it move wherever we want. 
Using such a tool will allow us to define different areas 
(like walkable, not walkable, swim area, etc) with different behaviours
and handle all interactions between moving entities automatically.

For that, we will need to import the Unity AI Navigation package.

### Importing the package

Go to Window->Package Manager. The first page shows you which packages 
are already installed in your project. You might already have the AI Navigation 
package installed. In that case, just check that you have the latest version and 
you're good to go. Otherwise, go to the Unity Registry tab and enter 'AI' 
in the search bar. You should see it appear. Click install.

![navigation package](ClassTutorialAssets/Class4/img/navigation_package.png)

### Creating the navmesh

Select your Environment GameObject, and add a `NavMeshSurface` component. 
This is where you will define the areas for the pathfinding. 
But before we create the navmesh, we will create a new agent type, 
since our slime is not `humanoid`. Click on Agent Type, and open the 
Navigation settings (or Window->AI->Navigation). 

Create a Slime agent, and set its values. I'll go for a radius and height of 
0.75, a slope of 50° and a step height of 0.6, but it's up to you to choose values that fit the way you want your 
characters to behave, so testing is often in order.

![slime agent type](ClassTutorialAssets/Class4/img/slime_agent_type.png)

Now, go back to your NavMeshSurface component.

Change the agent type, and under Object collection, 
select current object hierarchy to only use the objects children of the 
current one (our environment in that case). You can also specify which 
layers you want to include, in our case only the default and interactable ones.

Then, hit bake and you should see a lot of blue polygons appear on your scene.

![first navmesh](ClassTutorialAssets/Class4/img/first_navmesh.png)

If you take a closer look, you'll see that what's in blue defines the area 
(walkable in our case) we juste baked, and that there are holes around the trees.
This is almost perfect. The problem we have is that our chest was not taken into 
account when baking, even if it is inside the current hierarchy.

This comes from the fact that we baked using `Render meshes` as the `Use geometry`
option, and skinned meshes (what we have for animated meshes) are not compatible 
with this. Instead, you could use the `Physics colliders` option, but other problem
could arise. An alternative solution is adding the `NavMeshObstacle` component 
to the problematic object, which will let us define a custom bounding box which
the baking process will use. However, note that this method is usually used for 
moving objects.

Add one to your chest prefab, and select the `Carve` option. 
Adjust the size to your needs, you should see the surface update in realtime.

### Making an agent

#### Optimisation concerns

## Spawning the slimes

### Coroutines

### Instantiating

## Creating a custom shader



## Conclusion


---
*course by Julien Charvet for GCC*

[previous class](https://github.com/Skydrag42/GCC_Unity_Forma_Class3/)