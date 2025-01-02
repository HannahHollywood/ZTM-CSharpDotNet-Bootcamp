// Implicit Conversions: No special syntax, no data loss, no precision loss
// Explicit Conversions: Castings, potential data loss, potential precision loss

int age = 31;
float weight = 70.1f;

Console.WriteLine($"age: {age}, weight: {weight}");

// implicit conversion
long myAge = age;

// explicit conversion
int lessWeight = (int)weight;
int notMyAge = (int)myAge;

long bigNumber = 11111111111;
int smallerType = (int)bigNumber;

Console.WriteLine(smallerType);

// NOTES:
// Integral numeric types = int & long