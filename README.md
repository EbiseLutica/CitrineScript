# CitrineScript

A procedural script language.

## Build

1. git clone https://github.com/xeltica/citrinescript
2. cd citrinescript/Example
3. dotnet run


## LICENSE

Under [the MIT License](LICENSE)

## Example

### Hello, world

```c
println("Hello, world!");
```

### printf

```cs
printf("You are %d years old", 30);
println();

// printf + println
printfln("I have %d yen", 5000);
```

### declare a variable

```cs
var a = 30;
println(a); // 30

// undeclared variable has a initial value
println(b); // 0
```

### input

```cs
// input numeric
var a = input("a> ");
var b = input("b> ");

// input string
var op = inputln("+, -, *, / >");
```

### strict mode

```cs
#option strict

a = 4; // ERROR!
```

### if / for / while / loop

```cs
if (input() > 0)  println("it's a natural number");

for (i = 1; i < 100; i++)
{
    if (i % 15 == 0) 
        println("Fizz Buzz");
    else if (i % 3 == 0) 
        println("Fizz");
    else if (i % 5 == 0) 
        println("Buzz");
    else 
        print(i);
}
while (true)
    if (inputln("Input CAT") == "CAT")
        break;

loop
    println("You can't escape from this loop :)");
```

### Block

```cs
var a = 3;

// statements enclosed by a `{}` makes a block.
{
    // variables in scopes become local variables
    var b = 4;
    // local variables are used in same or child scopes.
    print(b);
    // you also use global variables in the scope
    print(a);
}

print(b); // ERROR!

// often used with if, for, while, loop statement
if (a > 4)
{
    return "It's greater than 4"
}
```

### Define functions

```cs

println(deg2rad(180)); // 3.14159...

def deg2rad(angle)
{
    return angle / 2 * pi();
}
```

### Array

```cs
var a[10]; // alloc an array of 10 elements

// array has no type-constraint so you can contains any types of value
a[2] = 4;
a[5] = "Crab";

// array literal
var b = [ 3, 10, "Cat", [1, 2, 3] ];

println(b[0]); // 3
println(b[3][1]); // 2

println([ 1, 1, 2, 3, 5, 8, 13, 21 ]); // Inspect

```

### each

Each statement iterates an array:

```cs
each i in [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ]
{
    println(i);
}

// Output:
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9
// 10
```

It also works with string:

```cs
each i in "Hello, world!"
{
    println(i);
}

// Output: 
// H
// e
// l
// l
// o
// ,
//  
// w
// o
// r
// l
// d
// !
```

### object

var obj = {
    a: 34,
    b: "neko"
};

println(obj.b);

// add elements dynamicly
obj.c = [ 114, 514 ];

