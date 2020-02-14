Overloading Methods

A class can define multiple methods.

At times we may want the same type of functionality of one method but use it for different inputs. For example, let's consider an add() method that can take an int or double.

We may write one method as such:
```c#
public int add(int a, int b){
  return a + b;
}
If we also want to support the double datatype, then we may have something like this:

public double addDouble(double a, double b){
  return a + b;
}```

Based on the above scenario, we have two methods that essentially accomplish the same thing, but operator on different types of parameters. The first method is called add() and the second is called addDouble().

But why make the distinction?

It's not necessary. When writing code, you want to create components that are easy to use and easy to remember. It would be poor design to specify several different names of methods solely on the difference of input types.

To support a better design, C# allows you to overload a method. To overload a method you use the same name as another method, but use different parameters.

The following example demonstrates the add method being overloaded:
```c#
public int add(int a, int b){
  return a + b;
}

public double add(double a, double b){
  return a + b;
}```
The following are rules related to overloading:

An overloaded method must have a different number of and/or types of parameters and/or order of parameters
An overloaded method can throw Exceptions
An overloaded method can return a different datatype
