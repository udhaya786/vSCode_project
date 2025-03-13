public class Calculator {

    // Sum method
    public int sum(int a, int b) {
        return a + b;
    }

    // Minus method (corrected)
    public int minus(int a, int b) {
        return a - b;  
    }

    // Divide method
    public int divide(int a, int b) {
        if (b == 0) {
            throw new ArithmeticException("Cannot divide by zero");
        }
        return a / b;
    }

    // Multiply method
    public int multiply(int a, int b) {
        return a * b;
    }
}
