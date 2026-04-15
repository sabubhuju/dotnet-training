//compilation
//--> compile .exe dil (intermediate language - IL)
//clr --> comman language runtime
//verifies code, manage menory, exceptions handling
//garbage collection
//--> remove unused objects from memory
//--> prevents memory leaks

//jit --> just in time compiler
//methods only when use
//not all program




//OOP - Object Oriented Programming
//Classes and Objects
//Access Modifiers
//Properties
//Constructors

HelloWorld helloWorld = new HelloWorld();
helloWorld.Greet("Alice");

class HelloWorld
{
    public string Greet(string name)
    {
        return $"Hello, {name}";
    }
}

/*
Access Modifiers:
public = anywhere accessible
private = only accessible inside same classes
protected = inside same class and derived classes
internal = inside same assembly, same project
protected internal = same class, chil class, or any class withi same assembly/project
private protected = inside same class and derived classes (but not accessible from outside)
*/