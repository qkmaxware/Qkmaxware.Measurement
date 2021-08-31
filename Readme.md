<p align="center">
  <img width="120" height="120" src="logo.svg">
</p>

# Qkmaxware.Measurement
A C# library for dealing with measurements including storage, and conversion in high precision.

## High Precision Numbers
The core of this library is the `Scientific` class which is performs high precision arithmetic. The Scientific class stores all values in normalized scientific notation thereby attempting to avoid the issues with floating point precision when values get extremely large. This is slower than using the built-in primitive types of float or double as it performs more arithmetic as well as performing all arithmetic in a checked context to throw exceptions in the case of overflows or underflows. 

To construct an object of type `Scientific` there are 3 possible way. The first way is by using implicit conversions from privitive types.
```cs
Scientific real1 = 3.1415;
Scientific real2 = 8;
```
As demonstrated above, these implicit conversions will convert from float, double, int, and more to a `Scientific` object. This method is the easiest way of creating scientific values. If this is not desired, one can use the construtor or the x10 extension method which both do the same thing, but arguably the extension method is more readable as to its intent.
```cs
// Using the constructor
Scientific real1 = new Scientific(144, -2); // The same as 1.44 or 144 x 10^-2

// Using the "x10" extention method
var real2 = 144.x10(-2);        // The same as above, but arguably more readable 
```

Additionally, there is another class `Arbitrary` which supports arbitrary precsion arithmetic. This is the slowest way to perform high precision calculations but will, in most cases, create better overall results at the cost of much higher computation time. If this level of precision for a particular calculation is desired, it is recommended to perform the caluations using the `Arbitrary` class before down-casting to a `Scientific` for its smaller storage cost and faster arithmetic properties. For example wrapping very large angles can be done in arbitrary precision then converted to a the scientific value notation as values between 0 and 360 can be well represented the scientific notation class without too much loss of precision.

## Measurements
Besides the arbitrary precision arithmetic functionalities, this library contains classes that abstract the concepts of measured quantities. These abstractions let us define quantities by thier context using whatever units are available and then be able to freely convert between allowable units for that kind of context. Internally these quantities will be stored with a specific unit, but we may used whatever unit we want to define the quantity and can convert to other units easily enough.

Measurements support any operators that will not change the units involved. Examples of such operator include addition, subtraction, and scalar multiplication. In some cases additional operators are provided that do change the units and produce objects of a different measurement type. For instance dividing a Length object by a Duration object will create an object of type Speed. 

Since each kind of measurement is represented by an object class, we can create methods that restruct the desired inputs to only measurements of quanties that we want as can be seen in the example below. In this example we are performing the `D = S * T` equation, but restricting our arguments to specific object types indicative of their overall purpose. Unlike if we just used doubles for the parameters, a user of this method cannot confuse which parameter is which because the objects provide context and restrictions. Additionally the user may choose whatever units they want to define the speed or time but the method will work regardless of which units those were defined initially in. 

```cs
public Length DistanceAfterTime(Speed speed, Duration time) {
    return Length.Metres(speed.TotalMetresPerSecond() * time.TotalSeconds());
}
```

## Mass
The mass measurement defines a quantity that represents the mass of an object. Internally all masses are stored in the SI unit of grams. To define a mass, use one of the static constructor methods, each one specific to a certain unit that can be used to measure mass. Examples of these static constructors can be seen below.

```cs
Mass m1 = Mass.Kilograms(5);
Mass m2 = Mass.Milligrams(400);
```

To obtain the measured quantity in another unit of mass, you can use the `Mass.Total*` methods. For each static constructor method, there is an equivalent `Total*` method which can be used to obtain the results in that unit of measure. For instance:

```cs
Mass m2 = Mass.Kilograms(5);
var r1 = m2.TotalGrams();
```

## Angle
The Angle measurement defines angular measurements. Internally the quantity is stored in degrees. Similar to [Mass](#mass), you construct an angular measurement using static constructor methods and can obtain the results of the measure in other units by using the `Total*` methods. 

```cs
Angle angle = Angle.Degrees(45);
var value = angle.TotalRadians();
```

In many cases it makes sense to limit an angle to between 0 and 360 degrees (exclusive). The `Wrap` function will perform the correct wrapping to ensure the resulting angle is within this range. For cases where it only makes sense for a variable to be a wrapped angle I suggest using properties to automatically call the `Wrap` method as seen below.

```cs
class MyClass {
  private Angle _angle;
  public Angle AutoWrappedAngle {
    get => _angle;
    set => _angle = value.Wrap();
  }
  ...
}
```

Additionally wrapping will be performed automatically on the stored value when using the utility trigonometric functions `Sin`, `Cos`, and `Tan`.This allows these functions to work well even for very large angular measures. 

## Length
The Length measurement defines distance measurements. Internally the quantity is stored in metres. Similar to [Mass](#mass), you construct a length measurement using static constructor methods and can obtain the results of the measure in other units by using the `Total*` methods.

```cs
Length length = Length.Kilometres(100);
var value = length.TotalMetres();
```

## Duration
The Duration measurement defines amounts of time. Internally the quantity is stored in seconds. Similar to [Mass](#mass), you construct a duration measurement using static constructor methods and can obtain the results of the measure in other units by using the `Total*` methods.

```cs
Length length = Length.Seconds(6);
var value = length.TotalNanoseconds();
```

## Temperature
The Temperature measurement defines a measure of temperature. Internally the quantity is stored in degrees Kelvin and limited such that the quantity cannot go below 0 degrees kelvin. Similar to [Mass](#mass), you construct a temperature measurement using static constructor methods and can obtain the results of the measure in other units by using the `Total*` methods.

```cs
Temperature length = Temperature.Kelvin(6);
var value = length.TotalCelsius();
```
