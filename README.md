### Build Status:

master | dev
------------ | -------------
[![Build Status](https://dev.azure.com/cn-github-builds/GitHub%20Builds/_apis/build/status/companova.CommonExtensions?branchName=master)](https://dev.azure.com/cn-github-builds/GitHub%20Builds/_build/latest?definitionId=1&branchName=master)|[![Build Status](https://dev.azure.com/cn-github-builds/GitHub%20Builds/_apis/build/status/companova.CommonExtensions?branchName=dev)](https://dev.azure.com/cn-github-builds/GitHub%20Builds/_build/latest?definitionId=1&branchName=dev)

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
