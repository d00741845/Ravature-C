# C# == vs .Equals() LAB

### What is the difference between Equals() and == ?

Difference between the method Equals() and the == relational operator.

Both are used to compare. 

Two things are return a boolean value, however, they are used in different scenarios.

The operator == is used to compare the value of primitives as in the following scenario:

```c#
int x = 6;
int y = 5;
if (x == 6){ .. }
```

If you compare two reference variables using the == operator will compare the reference address of the objects each variable points to. It may not return true even if the contents of those two objects are the same.

For example, comparing two strings (when one is created using the new operator) will return false.

```c#
string s = "Hello";
string s2 = "Hello".substring(0, 5);
if (s == s2) {..}
```
The above if-statement will not execute because s is not equal to s2.

In the case of objects (yes, strings are objects), the == operator compares the memory location of these variables. Objects have their own place in memory and each time you create a new object, it'll have its own memory address and thus the == operator will return false.

This is why we use the Equals() method with objects. It is expected to that it will help us compare the values of objects with one another.

Thus in our String example, we would use equals() instead of == and the if-statement would execute:

```c#
string s = "Hello";
string s2 = "Hello".substring(0, 5);
if (s.Equals(s2)) { ... }
```

This is because the equals() method of the String class has been overridden to compare the contents of the current string and one passed in as an argument.
