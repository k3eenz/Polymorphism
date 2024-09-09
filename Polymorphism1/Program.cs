using Polymorphism1;
using System;

CustomConverter converter = new CustomConverter();
converter.Converter("123", out int intResult);
converter.Converter("123,45", out double doubleResult);
converter.Converter("true", out bool boolResult);
