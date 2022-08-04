# Velentr.AbstractShapes
A library containing a variety of definitions for basic shapes. Meant to be used internally in other packages to allow for easier abstraction between Monogame and FNA, etc.

# Installation
There are nuget packages available for Monogame and FNA:
- Generic [![NuGet version (Velentr.AbstractShapes)](https://img.shields.io/nuget/v/Velentr.AbstractShapes.svg?style=flat-square)](https://www.nuget.org/packages/Velentr.AbstractShapes/): [Velentr.AbstractShapes](https://www.nuget.org/packages/Velentr.AbstractShapes/)
- Monogame [![NuGet version (Velentr.AbstractShapes.Monogame)](https://img.shields.io/nuget/v/Velentr.AbstractShapes.Monogame.svg?style=flat-square)](https://www.nuget.org/packages/Velentr.AbstractShapes.Monogame/): [Velentr.AbstractShapes.Monogame](https://www.nuget.org/packages/Velentr.AbstractShapes.Monogame/)
- FNA [![NuGet version (Velentr.AbstractShapes.FNA)](https://img.shields.io/nuget/v/Velentr.AbstractShapes.FNA.svg?style=flat-square)](https://www.nuget.org/packages/Velentr.AbstractShapes.FNA/): [Velentr.AbstractShapes.FNA](https://www.nuget.org/packages/Velentr.AbstractShapes.FNA/)

# Supported Shapes
All shapes support a variety of different mathematical operations on themselves (addition, subtraction, etc.) and have helpful additional methods where it felt appropriate.

| Name | Description | Example | Implicit Conversion To | Implicit Conversion From | Comments |
| ---- | ----------- | ------- | ---------------------- | ------------------------ | -------- |
| Circle | Represents a circle, uses ints for coordinates and radius | `var circle = new Circle(0, 0, 5);` | CircleD, CircleM, string | CircleD, CircleM, Point, PointI, System.Drawing.Point, System.Drawing.PointF |  |
| CircleD | Represents a circle, uses doubles for coordinates and radius | `var circle = new CircleD(0d, 0d, 5d);` | Circle, CircleM, string | Circle, CircleM, Point, PointI, System.Drawing.Point, System.Drawing.PointF |  |
| CircleM | Represents a circle, uses ints for coordinates and a double radius | `var circle = new CircleM(0, 0, 5d);` | Circle, CircleD, string | Circle, CircleD, Point, PointI, System.Drawing.Point, System.Drawing.PointF |  |
| Dimensions | Represents the width and height of an object, uses ints for both | `var dimensions = new Dimensions(16, 16);` | string |  |  |
| Point | Represents a point in a 2D space. Uses doubles for x and y | `var point = new Point(32, 32);` | PointI, System.Drawing.Point, System.Drawing.PointF, string | PointI, System.Drawing.Point, System.Drawing.PointF |  |
| PointI | Represents a point in a 2D space. Uses ints for x and y | `var point = new PointI(32, 32);` | Point, System.Drawing.Point, System.Drawing.PointF, string | Point, System.Drawing.Point, System.Drawing.PointF |  |
| Rectangle | Represents a rectangle in a 2D space. Uses ints for x, y, width, and height | `var rectangle = new Rectangle(0, 0, 32, 32);` | RectangleD, System.Drawing.Rectangle, System.Drawing.RectangleF, string | RectangleD, System.Drawing.Rectangle, System.Drawing.RectangleF |  |
| RectangleD | Represents a rectangle in a 2D space. Uses doubles for x, y, width, and height | `var rectangle = new Rectangle(0, 0, 32, 32);` | Rectangle, System.Drawing.Rectangle, System.Drawing.RectangleF, string | Rectangle, System.Drawing.Rectangle, System.Drawing.RectangleF |  |

NOTE: Extension methods are available using the Monogame and FNA versions of the package that allow conversion to/from XNA-versions of the shapes to these versions (ex.: `var point = new Point(0, 0).ToXnaPoint()` or `var point = new Microsoft.Xna.Framework.Point(1, 1).ToVelentrPoint()`). Make sure to install the appropriate package to enable these extra conversions.

# Future Plans
See list of issues under the Milestones: https://github.com/vonderborch/Velentr.AbstractShapes/milestones
