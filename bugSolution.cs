public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public void MyMethod() {
        // Initialize property before use
        MyProperty = 10; 
        int value = MyProperty * 2; 
    }
}