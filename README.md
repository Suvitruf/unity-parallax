# Unity Parallax
Скрипт для создания бесконечно прокручивающегося фона на Unity с эффектом параллакса из [статьи](https://suvitruf.ru/2019/12/23/7150/platformer-unity-background-parallax/).

## Использование
Вся магия в скрипте [ParallaxScript.cs](https://github.com/Suvitruf/unity-parallax/blob/master/Assets/Scripts/ParallaxScript.cs). 

Для начала вам нужно добавить на сцену 3 копии фона с отступами.
![Create gameobjects](https://user-images.githubusercontent.com/1946939/71331732-7ccc7780-2544-11ea-986a-7091fdfc9d14.gif)

У вложенных объектов нужно выставить по координате X оффсет на размер спрайта. У одного с плюсом, а другого с минусом. В итоге корневой элемент будет по центру, а два вложенных по бокам.

![Backgrounds offset](https://user-images.githubusercontent.com/1946939/71331731-7ccc7780-2544-11ea-90fe-a4ace85f99f8.png)

Теперь нужно просто закинуть ParallaxScript.cs на корневой объект и добавить ссылку на камеру в редакторе. В итоге получим что-то такое.

![Фон с параллакс эфектом](https://user-images.githubusercontent.com/1946939/71331843-e2b8ff00-2544-11ea-9a27-cdff55bf5b28.gif)
