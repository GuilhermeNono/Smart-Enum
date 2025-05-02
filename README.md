# 🚀 Smart Enum

A smart enum implementation for C# projects. 🧠✨

## 🌟 Overview

Smart Enum is a simple and flexible implementation of enums in C#. This approach allows you to extend enumerations with additional functionality, making your enums smarter and your code more expressive.

## ✨ Features

- 🔧 **Custom Functionality**: Easily extend enums with custom methods and properties.
- ✅ **Type Safety**: Maintain compile-time safety for enum operations.
- 📖 **Readable Code**: Write enums that are easy to read and maintain.
- ⚡ **Practical Implementation**: Designed to be directly integrated into your C# projects.

## 🛠️ Usage

### Example

Here's an example of how to use the Smart Enum implementation in your C# project:

```csharp
public class Color : SmartEnum<Color>
{
    public static readonly Color Red = new Color("Red", 1);
    public static readonly Color Blue = new Color("Blue", 2);

    private Color(string name, int value) : base(name, value) { }
}

// Usage
var redColor = Color.Red;
Console.WriteLine(redColor.Index); // Output: 1
Console.WriteLine((int)redColor); // Output: 1
Console.WriteLine(redColor); // Output: Red
```

This implementation allows you to define enums with custom behavior, improving modularity and expressiveness in your code. 🌈

## 🤝 Contributing

Although this is an implementation rather than a library, feedback and suggestions are always welcome! Feel free to open an issue in the [Issues](https://github.com/GuilhermeNono/Smart-Enum/issues) tab if you have ideas or improvements.

## 📜 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## 💬 Feedback

If you have any questions or feedback, don't hesitate to reach out by opening an issue on this repository. Your input is greatly valued! ❤️
