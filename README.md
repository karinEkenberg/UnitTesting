# Unit Testing README

This project contains a simple unit test for the `ReturnsSnowballIfZero` method in the `Function` class.

## Purpose

The purpose of this unit test is to verify that the `ReturnsSnowballIfZero` method returns the correct string based on the input integer.

## Running the Test

To run the unit test, follow these steps:

1. Ensure you have the necessary dependencies installed, including a .NET runtime environment.
2. Clone this repository to your local machine.
3. Open the solution in your preferred IDE or text editor.
4. Build the solution to ensure all dependencies are resolved.
5. Navigate to the `Program.cs` file within the `UnitTesting` project.
6. Run the `Main` method.

Upon running the `Main` method, the unit test will execute, and you will see output indicating whether the test passed or failed.

## Test Details

- **Test Method:** `Function_ReturnsSnowballIfZero_ReturnString`
- **Input:** `num = 0`
- **Expected Output:** `"Snowballed!"`

If the test passes, you will see the message: `PASSED: Function.ReturnsSnowballIfZero_ReturnsString`.
If the test fails, you will see the message: `FAILED: Function.ReturnsSnowballIfZero_ReturnsString`, along with any relevant exception details.

## Troubleshooting

If you encounter any issues while running the unit test, please ensure that all dependencies are correctly installed and that the solution is built successfully before running the test again.
