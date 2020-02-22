# Implicit Constructor Calls

C# has many implicit behaviors - behaviors that happen automatically and invisibly - that can make it difficult to understand what is really happening under the hood. Some of these behaviors relate to constructors.

As you know, C# possesses an implicit behavior whereby it will provide a default no-arg constructor if you do not provide one. Additionally, the first thing any constructor must do is invoke another constructor. The exception to this rule is the constructor of the Object class, which actually creates an object in memory. This will happen implicitly, whether you write the code or not. If you rely on the implicit implementation of this requirement, your constructor will call the constructor of the base class before any other code in the constructor is executed.

That looks like this:

```c#
public class Animal {}

public class Dog : Animal {
    public string Name { get; set; }
    public string Breed; { get; set; }

    public Dog(string name, string breed) {
        base(); // implicit call to base class constructor
        Name = name;
        Breed = breed;
    }
}

```

The implicitly provided constructor call is to a no-arg constructor of the base class, using the base keyword. In the above example, The Dog() constructor invokes the Animal() constructor, which is the default no-arg constructor provided by the CLR, and which it has because no other is defined. The Animal() constructor will also invoke the no-arg() constructor of its base class, which by default is the Object class.

Just like you can provide your own constructor instead of using the default no-arg constructor, you can provide your own constructor call instead of using the implicit one. For example, this is acceptable:

```c#
class Animal {}

public class Dog : Animal {
    public string Name { get; set; }
    public string Breed { get; set; }

    public Dog(string name, string breed) {
        base(); // implicit call to base class constructor
        Name = name;
        Breed = breed;
    }

    public Dog() {
        this("Fido", "German Shepherd");
    }
}
```
In this example, the no-arg constructor of Dog will invoke the constructor that demands two String parameters, and will provide some default values for those parameters. Note that just like the "base" keyword is used to invoke the superclass constructor, the "this" keyword is used to invoke another constructor in the same class.

No matter how you chain constructors like this, eventually the base class constructor must be called. This ensures that at the end of the chain, the Object class constructor is getting called, so the object can actually be created in memory.

---

Created by:
Jesse Fore

service.awg@gmail.com

Updated:
22 February 2020

-_-
---
