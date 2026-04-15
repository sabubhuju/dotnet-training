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

HelloWorld helloWorld = new HelloWorld();
helloWorld.Greet("Alice");

class HelloWorld
{
    public string Greet(string name)
    {
        return $"Hello, {name}";
    }
}
