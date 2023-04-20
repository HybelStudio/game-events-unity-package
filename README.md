# Game Events

This package allows you to create Game-Wide triggered events. Powered by Scriptable Objects, use the create menu to create a new event and assign them in the inspector where you wish to invoke, or subscribe to the event.

## Adding the package to your Unity project

Open the package manager in unity by navigating to "Window/Package Manager". Then click the plus icon in the top-left, add package from git URL, and paste [https://github.com/HybelStudio/game-events-unity-package.git](https://github.com/HybelStudio/game-events-unity-package.git) into the text box, and press Add.

## Usage

To create a new Game Event, in your Project view, right click and navigate to "Create/Game Event" and then choose which type of event you want to use. The one called Game Event is a trigger without arguments passed into the event.

There are a few helpful components you can use to convert a Game Event into a Unity Event. They all have "EventListener" in their name. The basic one is the GameEventListener. After adding that component to an object you can assign the Game Event you created in the inspector as long as the listener is the same type as the event itsef. Then you can use the unity event as normal to invoke functions on your other components.

To invoke the Game Event you will need to write some code.\
Create a new C# Script from the create menu and make a field with GameEvent type:
```csharp
public class GameEventTest : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;
}
```

Then anywhere in your code you can invoke the event by calling the Invoke() method on the GameEvent.

```csharp
public class GameEventTest : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;

    private void Start()
    {
        gameEvent.Invoke();
    }
}
```

This fires the event on all loaded listeners.

When creating your own class which subscribes to the event, your should unsubscribe when the object is destroyed or becomes disabled.

```csharp
public class GameEventListeningTest : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;

    private void Awake()
    {
        gameEvent += OnGameEventInvoked;
    }

    private void OnDestroy()
    {
        gameEvent -= OnGameEventInvoked;
    }

    private void OnGameEventInvoked()
    {
        // Funky game code here.
    }
}
```

Note that i'm using the '+=' and '-=' operators here. This is similar to how C# events work, but you can use the `Subscribe()` and `Unsubscribe()` methods instead if you prefer.

## Caveats

* Unlike C# events, these events can easily be invoked from anywhere in your project. This is working as intended since you might use the same event in different scenes. However if you have multiple objects invoking it you might get unintended behaviour.
* Game-Wide, but not actually. The events, once invoked will broadcast to anything that is subscribed, however unloaded objects, *obviously* arent subscribed and therefor wont be notified when the event is raised. This means you can't have an event fire in one scene and a door be opened in another scene (which is current unloaded) just by using this system. You'd have to write some logic to store the state of that door between scenes and have that logic be called when the event is raised.

## Contributing

**Bug Reports & Feature Requests**

Please use the [issue tracker](https://github.com/HybelStudio/game-events-unity-package/issues) to report bugs or file features.

Pull requests are welcome. To begin developing, do this under the assets folder of a Unity project.

```sh
git clone https://github.com/HybelStudio/game-events-unity-package.git\
```

Then open your Unity project and start developing :D

## License

[CC0](https://creativecommons.org/publicdomain/zero/1.0/)
