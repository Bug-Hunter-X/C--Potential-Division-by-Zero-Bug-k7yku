public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        // Initialize MyProperty to a non-zero value
        MyProperty = 10;
    }

    public void MyMethod() {
        //Check if MyProperty is 0 before using it in a calculation
        if (MyProperty != 0)
        {
            int result = 100 / MyProperty; // No longer a potential division by zero
        }
        else
        {
            Console.WriteLine("MyProperty is zero. Cannot perform division.");
        }
    }
}    