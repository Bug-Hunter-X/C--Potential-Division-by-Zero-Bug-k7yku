public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        // Initialize MyProperty to a non-zero value
        MyProperty = 10;
    }

    public void MyMethod() {
        //Check if MyProperty is 0 before using it in a calculation
        if(MyProperty != 0){
            int result = 100 / MyProperty; //potential division by zero if MyProperty is 0
        } else {
            Console.WriteLine("MyProperty is zero");
        }
    }
}