# Unity Parallax
Script for creating 2d infinite scrolling background in Unity with parallax effect from [the article](https://suvitruf.ru/2019/12/23/7150/platformer-unity-background-parallax/).

## Usage
All magic in the script [ParallaxScript.cs](https://github.com/Suvitruf/unity-parallax/blob/master/Assets/Scripts/ParallaxScript.cs). 

First you need to add 3 copies of background with offset.
![Create gameobjects](https://user-images.githubusercontent.com/1946939/71331732-7ccc7780-2544-11ea-986a-7091fdfc9d14.gif)

Nested objects should have offset by X axes. One with negative offset and one with positive. As a result root element will be in the middle, and 2 nested elements on the sides.

![Backgrounds offset](https://user-images.githubusercontent.com/1946939/71331731-7ccc7780-2544-11ea-90fe-a4ace85f99f8.png)

Now you just need to add ParallaxScript.cs to the root element and add ref to the camera in the Editor. And the result will look like this.

![Фон с параллакс эфектом](https://user-images.githubusercontent.com/1946939/71331843-e2b8ff00-2544-11ea-9a27-cdff55bf5b28.gif)
