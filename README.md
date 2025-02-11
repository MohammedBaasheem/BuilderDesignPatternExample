# Builder Design Pattern Example

This project demonstrates the Builder design pattern in C# for creating `Product` objects.  The Builder pattern is used to separate the construction of a complex object from its representation, allowing the same construction process to create different representations.

## Project Structure

The project consists of three main classes:

*   `Product`: Represents the complex object being built. It has properties like `Name`, `Description`, `Price`, `Category`, `Manufacturer`, and `Features`.
*   `ProductBuilder`:  The builder class responsible for constructing `Product` objects step-by-step.  It provides a fluent interface for setting the properties of the `Product`.
*   `Program`: Contains the `Main` method, which demonstrates how to use the `ProductBuilder` to create different `Product` instances.

## How the Builder Pattern is Applied

1.  **Product Class:** The `Product` class defines the structure of the object we want to build.  It's a relatively simple class with properties to hold the product's attributes.

2.  **ProductBuilder Class:** The `ProductBuilder` class is the core of the Builder pattern.  It holds an instance of the `Product` class (`_product`) that it's building.  Crucially, it provides methods like `SetName`, `SetDescription`, `SetPrice`, etc.  These methods *don't* directly set the properties of the `Product` instance. Instead, they modify the internal `_product` instance and, importantly, *return the `ProductBuilder` instance itself*. This is what enables the fluent interface (method chaining).

3.  **Fluent Interface (Method Chaining):** The `ProductBuilder`'s methods return `this` (the current `ProductBuilder` instance). This allows you to chain method calls together, making the code for building a `Product` very readable and concise.  For example:

    ```csharp
    Product product = new ProductBuilder()
        .SetName("iPhone 15")
        .SetDescription("A cutting-edge smartphone")
        .SetPrice(999)
        .SetCategory("Smartphones")
        .SetManufacturer("Apple")
        .SetFeatures(new List<string> { "OLED Display", "A15 Bionic Chip", "Dual Camera" })
        .Build();
    ```

4.  **Build Method:** The `Build()` method is the final step in the construction process.  It returns the fully constructed `Product` object that the builder has been working on.

## How to Run

1.  Make sure you have the .NET SDK installed.
2.  Navigate to the project directory in your terminal.
3.  Run `dotnet run`.

## Example Usage (from Program.cs)

The `Main` method in `Program.cs` demonstrates how to use the `ProductBuilder` to create two different `Product` objects with varying properties.  This highlights the key advantage of the Builder pattern: you can use the same construction process (the `ProductBuilder`) to create different representations of the `Product` object.

## Benefits of Using the Builder Pattern

*   **Clearer Object Creation:** The code for creating complex objects becomes more readable and maintainable.  The step-by-step construction makes it easy to understand what properties are being set.
*   **Immutable Objects (Optional):** While not implemented in this example, the Builder pattern can be easily adapted to create immutable `Product` objects.  This can help prevent accidental modification of the object's state after it's been created.
*   **Different Representations:** You can create different builders for different representations of the same object.  For example, you could have a `ProductBuilder` for creating a product description for a website and another `ProductBuilder` for creating a product description for a printed catalog.
*   **Reduced Constructor Complexity:**  Instead of having a complex constructor with many parameters (some of which might be optional), you can use the Builder pattern to set the properties individually. This makes the `Product` class simpler and easier to work with.
