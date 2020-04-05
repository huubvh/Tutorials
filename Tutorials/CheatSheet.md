
### Numbers
Signed integral types
- sbyte  : -128 to 127
- short  : -32768 to 32767
- int    : -2147483648 to 2147483647
- long   : -9223372036854775808 to 9223372036854775807

Unsigned integral types:
- byte   : 0 to 255
- ushort : 0 to 65535
- uint   : 0 to 4294967295
- ulong  : 0 to 18446744073709551615

Floating point types:
- float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
- double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
- decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)

### Changing data types
- parse (don't use this)
- try parse (use this)
- convert (use this for converting from floating point to integral, because it round up mathematically


### Getting data
#### based on string value
- Methods that either add blank spaces for formatting purposes (PadLeft(), PadRight())
- Methods that either compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
- Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
- Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
- Methods that turn a string into an array of strings or characters (Split(), ToCharArray())