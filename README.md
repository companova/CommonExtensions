# .NET Common Extensions
A collection of simple but useful extensions to .NET basic objects

# Example:
```csharp
IsNullOrEmpty();
```
Replaces a common practice to check whether a List or Array is null or empty. 
```csharp
void foo(List<T> listOfTs)
{
    // Use the extension to check whether the List is null or empty.
    // Instead of this:
    if(listOfTs == null || listOfTs.Count == 0)
        return;

    // Use this:
    if(listOfTs.IsNullOrEmpty())
        return;
        
    // There is some data in the List. Continue on
}
```
