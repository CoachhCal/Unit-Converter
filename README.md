# Unit Converter

![gui](https://github.com/user-attachments/assets/144c013d-8331-4deb-b61f-986eda38cfde)


A Windows Forms application developed in Visual Studio (2022 Community Edition).

The unit converter application has 10 physical quantities to choose from, with a total of 91 units of measurment.

Conversion factors were taken from the default unit converter in google chrome and https://www.unitconverters.net/.

<details>
  <summary>See Units of Measurement</summary>
  

  | **Physical Quantity** | **Units of Measurement**                                                                                                                |
  |-----------------------|-----------------------------------------------------------------------------------------------------------------------------------------|
  | **Volume**            | US liquid gallon, US liquid quart, US liquid pint, US cup, US fluid ounce, US tablespoon, US teaspoon, Cubic meter, Liter, Milliliter, Imperial gallon, Imperial quart, Imperial pint, Imperial cup, Imperial fluid ounce, Imperial tablespoon, Imperial teaspoon, Cubic foot, Cubic inch |
  | **Time**              | Nanosecond, Microsecond, Millisecond, Second, Minute, Hour, Day, Week, Month, Calendar year, Decade, Century, Millennium |
  | **Length**            | Nanometer, Micrometer, Millimeter, Centimeter, Inch, Foot, Yard, Meter, Kilometer, Mile, Nautical mile |
  | **Area**              | Square millimeter, Square centimeter, Square inch, Square foot, Square yard, Square meter, Acre, Hectare, Square Kilometer, Square mile |
  | **Mass**              | Microgram, Milligram, Gram, Ounce, Pound, Kilogram, Stone (UK), US ton, Imperial ton, Metric ton |
  | **Energy**            | Joule, Kilojoule, Calorie, Kilocalorie, Watt-hour, Kilowatt-hour, Foot-pound, British thermal unit (IT), Therm (EC) |
  | **Pressure**          | Bar, Pascal, Kilopascal, Pound per square inch, Kilopound per square inch, Torr, Standard atmosphere |
  | **Speed**             | Foot per second, Meter per second, Kilometer per hour, Mile per hour, Knot |
  | **Frequency**         | Hertz, Kilohertz, Megahertz, Gigahertz |
  | **Temperature**       | Celsius, Fahrenheit, Kelvin |
  
</details>

## Installation

- ### Source Code

  Clone the repo:

  ```
  git clone https://github.com/CoachhCal/Unit-Converter.git
  ```

  Run the solution:
  ```Unit_Converter.sln```

## Customizing the Unit Converter

1) **Add to the dictionary**
   
   - ```Form1.cs```
   
   - To add a unit of measurement to a pre-exisitng physical quantity, simply append the name of the unit to the array of strings
   - To add a new physical quantity, add a new key-value pair to the dictionary, which includes the name of the physical qunatity and all of its units of measurement.

        ![dict](https://github.com/user-attachments/assets/bc35ca87-ed7a-4b61-a69b-bd1dfe03b8de)


2) **Add to the conversion methods**

   - ```ConversionMethods.cs```
     
   - To add a unit of measurement, create a new case clause in <ins>each method under the appropriate physical quantity</ins>.
   - To add a new physical quantity, create a new method for each unit of measurement, which should include case clauses for each unit.

       ![method](https://github.com/user-attachments/assets/2ada5bff-0150-4b70-a846-56afeec850eb)

**Note:**
  - The names of the units of measurement must be exactly the same in both the case clauses and values in the dictionary.
  - The method name must exactly match the above when all non-letter characters are removed.
      - For example, the string "Therms (EC)" will match the method name "ThermsEC". The "ModifyString" method in Form1.cs handles this. 

