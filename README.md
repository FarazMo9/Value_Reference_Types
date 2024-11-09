# Value_Reference_Types

We will discuss about two categories of types in C#. That would be value types and reference types. The difference between these items would be on how they will be managed in memory.

Value Types
The value type category comprises most of the built-in types like all numeric types, Boolean, Char, structs and also Enum types.
The content of a value type in memory is totally a value. For example, the int is 32 bits data in memory.


Reference Types
The reference type category includes all classes, interfaces, delegates, array and also the string type. This category’s concept is that the type is pointing to a reference of an object in memory. So, when the initialized object is copied to another one, the reference of that is copied and by changing the first entity’s reference the second item would be changed too.

For a better understanding of these categories the sample source code is prepared to show how it’s done.
