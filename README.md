# Virtual Reality Maps 


## What you built? 

[Here](https://drive.google.com/file/d/1BVI_sUoJLSAAz9lWY9VyjIrlZ_J9pcT9/view?usp=sharing) is the full video of the project. 

Include some screenshots.

(Preview 1.png)
(Preview 2.png)

I created a little demo of a room with a map in it that a user can scroll around in virtual reality using a physical joystick with a compass design. It used the Mapbox SDK to generate 3d maps with satellite data. I added a marker onto the map using provided mapbox scripts and then made it so that when you tap the marker it shows pictures that were taken at that location. For this demo I chose Lake Tahoe California.  I also put a very large version of the map outside to see what sense of place that would give the user. Finally I added a small pointer stick the user could toggle with their controller just to give a tease of what type of virtual reality features might be nice. 

## What you learned

I couldn't really notice too many differences with this newer unity version I had never used before (I usually use 2019.17 and this was 2020.3), I didn't notice any differences with the XR toolkit, things seemed to work pretty similar to how they used to with the now depracted Oculus integration package. In fact there still is an oculus integration package so I guess its just things not visible to a common developer. 

Immediately mapbox failed to work with Universal Render Pipeline. There were some workarounds I found on github and such but it was pretty frustrating. Additionally none of the Oculus starter scenes which I wanted to use to remind me everything I need for distance grabbing were made for URP. I tried upgrading materials but some materials just didn't look right after upgrading. So I started over with Standard Pipeline.

[Here](https://drive.google.com/file/d/151UgOTYEX5MHRy5lbHFl1-75C6ausnJg/view?usp=sharing ) is a video of the issues I was experiencing using URP with the mapbox SDK 





Then I lost a few hours of work because Unity didn't save... I haven't ever had that happen on 2019.17, so maybe that's a 2020.3 issue or I just got extremely unlucky 

Anyways, the mapbox SDK was very very easy to get up and running and then very difficult to do anything past the most basic map. It's like they made it too user friendly that it became black boxed and hard to customize. I was able to read through the AbstractMap.cs code and make use of some basic functions to change the center of the map. I assume they are just doing some sort of height map shader based on elevation data queried from mapbox database, but for somereason changing the center of the map physically moves the map plane in a glitchy sort of way. I tried to stop that from happening but couldn't figure out a way to do so as why this was actually happening is probably an artifact of the core shader they use (assuming that is how they do this). I know they also use things called "tiles" to represent sections of the map and it appeared tha the map would move physical location until it switched tiles. So it was properly changing the center of the map while inproperly movinging the actual physical map.


I can certainly imagine some powerful uses of this sdk and already it felt very cool to manipulate maps in a virtual space. I think an interesting project would be to develop a virtual reality meeting area that allows full use of these maps. That way search and rescue, military, or recreational teams could collaborate around a map without actually having to be with each other. 

The satellite image quality was a little dissapointing but there were other map types to be explored and being able to toggle between the different ones would be useful. However going onto the porch of the room I created and staring out at the large lake tahoe did feel pleasant. It was inbetween cartoonish / animated landscapes typically found in virtual reality and HDR image skyboxes that still feel a little 2d. 

## Authors

James Fleming

## Acknowledgments

I used some materials and the starting room from the Oculus Sample Framework which helped me get a moving character with hands up and running immediately. 

I used a compass image from : 
https://www.cleanpng.com/png-compass-png-56780/

This is the "tutorial" I used (hardly a tutorial)
https://docs.mapbox.com/help/tutorials/create-a-map-in-unity/
