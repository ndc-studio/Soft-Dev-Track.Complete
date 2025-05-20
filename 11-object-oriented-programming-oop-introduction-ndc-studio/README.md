[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/IYv_eOsx)
# 11. Object-Oriented Programming (OOP) : introduction

OOP stands for **Object-Oriented Programming**

## 1. What is an object and a class? 

Before diving into the world of OOP in C#, let's clarify what a `class` and an `object` are. An object can represent anything in the real world or a concept in software, such as a `car`, a `chair`, a `house`, or even a `client` or a `cat` (for all the cat lovers out there).

Let’s use the example of a `Car` object (a classic example in programming!).

A car has various characteristics (known as `fields` or `attributes`) and `functionalities` like Starting engine.

However, we don’t just have one car on the road but thousands.

If a factory wants to produce cars quickly, they need a blueprint that describes both the attributes (like color, make, model) and functionalities (like starting the engine or honking the horn) of each car.

In OOP, this "blueprint" is called a class.

## 2. Create our first Class

Good news: you have already created your first class in previous exercises! Now, let’s build upon that understanding.

To get started, create a new `solution` and add a `project` named `OOP`.

Inside, create a new class called `Car`:

```csharp
namespace Clients
{
    internal class Car
    {
    }
}
```

Oh, wait! What does `internal` mean? And what about public? Quick explanation:

- An `internal` class is accessible only within the `project` where it’s defined.
- A `public` class is accessible across the entire `solution`.


### A. Fields (attributes)

In our `Car` class, we need to specify properties like its color, brand, and more. These characteristics are represented by fields (or attributes) in OOP. Fields hold the values that define an object’s state.

Here’s an example of fields in our `Car` class:

```csharp
namespace Clients
{
    internal class Car
    {
        public string Color;
        public string Brand;
    }
}
```

These fields are currently accessible from anywhere in the code because they’re marked as `public`.

***Quick Tips on Access Modifiers:***:
- **private** (default if no modifier is specified): The member can only be accessed within the same class.
- **protected**: The member is accessible within its own class and in any derived classes.
- **internal**: The member is accessible anywhere within the current assembly (or project).
- **public**: No access restrictions; the member is accessible from any part of the code.

### B. Object 
Now that we have our `Car` class, let’s create our first object, `car`:

```csharp
namespace Clients
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Color = "red"; // Set the color to "red"
            Console.WriteLine(car.Color); // Display the color
        }
    }
}
```

While this code works, there’s a better approach for setting and retrieving field values. We can currently access `Color` directly because of the `public` modifier on the field. However, a best practice in OOP is to control access to fields by using getters and setters, also known as accessors.

Here’s an improved example using accessors:

```csharp
namespace Clients
{
    internal class Car
    {
        private string _color;
        private string _brand;

        public string GetColor ()
        {
            return _color;
        }

        public void SetColor (string color) 
        {
            _color = Color;
        }
    }
}
```

### C. Properties

In C#, properties allow us to control access to fields in a more concise way than using separate `get` and `set` methods.

Here’s an example of properties in our `Car` class:

```csharp
namespace Clients
{
    internal class Car
    {
        public string Color { get; set; } // Simple property with get and set
        private string _brand;
        public string Brand {
            get {
                return _brand;
            }
            set{
                _brand = Brand;
            }
        }
    }
}
```

This approach is cleaner, but we can refine it further.

Imagine we want to prevent users from changing the car’s color after it’s been set, as you typically wouldn’t change a car's color after purchasing it. To make a property settable only during initialization, we have a few options: using `private set`, `init`, or `readonly`.

#### 1. Setting Read-Only Properties

There are three ways to set a property once and prevent modification afterward:

- Using `private set`: This allows a property to be assigned internally, typically through a constructor or method, while making it read-only from outside the class.

```csharp
public string Color { get; private set; } // Accessible only within the class
```

- Using `init` (C# 9+): Properties with `init` can be assigned only when the object is created, making them immutable after initialization.

```csharp
public string Color { get; init; } // Can only be set at object creation
```

- Using `readonly` (for fields): For fields rather than properties, `readonly` makes a field assignable only once, either at declaration or within the constructor.

```csharp
public readonly string Model; // Assignable only once
```

#### 2. Initializing Properties with Default Values or Constructors
Here’s how to initialize properties with the above options:

- ***Default Value***: If all cars should have the same color by default, we can set it directly within the property.

```csharp
public string Color { get; private set; } = "Red";
```

- ***Constructor***: If each car should have a unique color, a constructor can set the property or field at object creation.

```csharp
internal class Car
{
    public string Color { get; init; } // Using init to allow only initial assignment
    public readonly string Model;

    public Car(string color, string model)
    {
        Color = color; // Set color once during initialization
        Model = model; // Set only in the constructor
    }
}
```

| Summary of Differences       | `public readonly string Text`                         | `public string Text { get; private set; }`               | `public string Text { get; init; }`                  |
|------------------------------|------------------------------------------------------|----------------------------------------------------------|------------------------------------------------------|
| **Modifiable**               | Once only (at declaration or in the constructor)     | Internally modifiable multiple times                     | Only during initialization                           |
| **External Modification**    | Not allowed                                          | Not allowed                                              | Not allowed after initialization                     |
| **Typical Usage**            | Immutable values after initialization                | Access control with internal flexibility                 | Immutable values with simpler initialization         |


## 3. Constructors

In C#, a constructor is a special method that initializes a new object’s properties when it is created. Constructors allow us to set required values directly at the time of object creation.

Here’s an example of a constructor in the `Car` class:

```csharp
namespace Clients
{
    internal class Car
    {
        public string Color { get; private set; }
        public string Brand { get; private set; }

        public Car(string color, string Brand)
        {
            Color = color;
            this.Brand = Brand; // Using `this` to distinguish between the parameter and the field
        }
    }
}

Car Toyota = new Car("Blue", "Toyota"); // Constructor-based initialization
```

**Note**: In the constructor parameters, we use lowercase (`color` and `brand`). For the second parameter, `brand`, the name matches the class field name `Brand`. To distinguish them, we use `this.Brand`, where this refers to the current instance of the class.

**Expression-Bodied Constructors?**

Expression-bodied constructors are ideal when you have a simple assignment or a straightforward expression to execute. However, for more complex logic (such as validations or multiple assignments), the traditional constructor format is generally clearer.

```csharp
public class Engine
{
    public string Type { get; set; }

    public Engine(string type)
    {
        Type = type;
    }
}

public class Engine
{
    public string Type { get; set; }

    // Constructor using expression-bodied syntax
    public Engine(string type) => Type = type;
}
```

**Object Initializers and required**

In addition to constructors, C# offers object initializers for setting properties when creating an object. Object initializers provide a flexible syntax, allowing you to set properties in any order and without defining a specific constructor.

With C# 11, you can use the `required` keyword to enforce that certain properties must be initialized at the time of object creation, even with initializers. Properties marked with `required` must be set in the initializer; otherwise, a compilation error will occur.

Here’s an example with `required`:

```csharp
namespace Clients
{
    internal class Car
    {
        public required string Color { get; init; } // Must be initialized
        public string Brand { get; set; } // Optional initialization
    }
}

// Using an object initializer
Car Toyota = new Car { Color = "Blue", Brand = "Toyota" }; // Valid

// Omitting required property (will cause a compilation error)
Car Honda = new Car { Brand = "Honda" }; // Error: 'Color' is required
```

**Note**: `required` properties in object initializers allow you to enforce essential values without needing a constructor. This adds flexibility by letting you mix `required` and optional properties in a more readable format.

| Feature                      | Constructor                             | Object Initializer with `required`                  |
|------------------------------|-----------------------------------------|----------------------------------------------------|
| **Initialization Syntax**    | Uses a method-like parameter list      | Uses `{ property = value }` syntax                 |
| **Enforces Required Fields** | Yes, via constructor parameters        | Yes, with `required` properties                    |
| **Order of Properties**      | Fixed order in parameter list          | Any order in initializer                           |
| **Private/Read-Only Fields** | Can set private or readonly fields     | Limited to public properties with `init` or `set`  |
| **Code Readability**         | Clear but verbose for many properties  | Concise, especially for multiple optional fields   |
| **When to Use**              | Essential properties, complex setup    | Required and optional properties, flexible syntax  |

## Exercices

### 1. Creating a Book Class

- A. Create a `Book` class with the following properties:
    - `Title` (string): Represents the title of the book.
    - `Author` (string): Represents the author of the book.
    - `Pages` (int): Represents the number of pages in the book.

- B. Ensure that the `Title` property is read-only after initialization using `init`.
- C. Create a `Book` object using an object initializer.
- D. Add a method that returns the title, the author and the total pages of the book.

```csharp
using OOP_Introduction;

namespace Test_OOP_Intro
{
    public class TestBook
    {

        private Book _book;

        [SetUp]
        public void Setup()
        {
            _book = new Book() { Author = "John Doe", Title = "How to learn C#", Pages = 100 };
        }

        [Test]
        public void TestDisplay()
        {
            // Act
            string input = "Author : John Doe - Title : How to learn C# - Page : 100";
            string result = _book.Display();

            // Assert
            Assert.That(input,Is.EqualTo(result));
        }
    }
}
```

### 2. Using a Constructor for a Person Class

- A. Create a `Person` class with a constructor that takes the following properties as parameters:
    - `Name` (string): The person’s name.
    - `Age` (int): The person’s age.

- B. Ensure that the `Name` and `Age` properties cannot be modified after the object is created by using `private set`.
- C. Create a method that check if the person is an adult (it returns a boolean).
- D. Add a method that returns the name and the age, including if the person is a teenager or an adult.
- E. Instantiate the `Person` class and call the `Displa()y` method.

**Please use expression-bodied members for the two methods.**

```csharp
using OOP_Introduction;

namespace Test_OOP_Intro
{
    public class TestPerson
    {
        private Person _adultPerson;
        private Person _childPerson;

        [SetUp]
        public void Setup()
        {
            _adultPerson = new Person("John", 23);
            _childPerson = new Person("Hector", 12);
        }

        [Test]
        public void Display_ReturnsCorrectDescriptionForAdult()
        {
            // Act
            string expected = "John is 23 years old : Adult";
            string actual = _adultPerson.Display();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsAdult_ReturnsTrueForAdults()
        {
            // Act
            bool isAdult = _adultPerson.IsAdult();

            // Assert
            Assert.That(isAdult, Is.True);
        }

        [Test]
        public void IsAdult_ReturnsFalseForChildren()
        {
            // Act
            bool isAdult = _childPerson.IsAdult();

            // Assert
            Assert.That(isAdult, Is.False);
        }
    }
}
```

### 3. Rectangle Class.

- A. Create a `Rectangle` class with two properties:
    - `Length` (double): The length of the rectangle.
    - `Width` (double): The width of the rectangle.

- B  Update the `get;` method and throw a new exception if the number is 0 or negative.
- C. Add a `CalculateArea()` method that returns the area of the rectangle.
- D. Instantiate a `Rectangle` object and display its area.

```csharp
// Example
private double _length;

public double Length
{ 
    get => _length;

    set
    {
        if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value), "Length cannot be zero or negative.");
        _length = value;
    }
}
```

```csharp
using OOP_Introduction;


namespace Test_OOP_Intro
{
    public class TestRectangle
    {

        private RectangleEx _rectangle;

        [SetUp]
        public void Setup()
        {
            _rectangle = new RectangleEx() 
            { 
                Length = 4d,
                Width = 2d
            };
        }

        [Test]
        public void TestValidDimensions()
        {

            double l = _rectangle.Length = 2d;
            double w = _rectangle.Width = 5d;

            Assert.That(l, Is.EqualTo(2d));
            Assert.That(w, Is.EqualTo(5d));
        }

        [Test]
        public void Length_SetToNegativeValue_ThrowsArgumentOutOfRangeException()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _rectangle.Length = -1);
            Assert.That(ex.ParamName, Is.EqualTo("value"), "Should throw an ArgumentOutOfRangeException for the 'value' parameter.");
            Assert.That(ex.Message, Does.StartWith("Length cannot be zero or negative."));
        }

        [Test]
        public void Width_SetToNegativeValue_ThrowsArgumentOutOfRangeException()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _rectangle.Width = -1);
            Assert.That(ex.ParamName, Is.EqualTo("value"), "Should throw an ArgumentOutOfRangeException for the 'value' parameter.");
            Assert.That(ex.Message, Does.StartWith("Width cannot be zero or negative."));
        }

        [Test]
        public void Test_Area()
        {
            double result = _rectangle.CalculateArea();

            Assert.That(result, Is.EqualTo(8d));
        }
    }
}
```

--- 

![](https://media4.giphy.com/media/v1.Y2lkPTc5MGI3NjExZWlld29hbTR4dWF5dG1kOGhpcHl3ODJrcGQxZHJoaDJrcWJ4ejB2YSZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/RJbLRsWSh9jRtksVs0/giphy.gif)