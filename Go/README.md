# Go LeetCode Problem Solving

This project is a workspace for solving LeetCode problems using Go. It's structured to keep the solutions organized and easy to test.

## Project Structure

```
.
├── go.mod                # Go module definition
├── main.go               # Main application file (if needed)
├── main_test.go          # Main test file for running all problem tests
└── problems/             # Directory for individual LeetCode problem solutions
    └── twosum.go         # Example solution file
```

- **`go.mod`**: Defines the Go module path and dependencies.
- **`main.go`**: The main entry point of the application. Can be used for running specific solutions or for testing purposes.
- **`main_test.go`**: Contains the test runners for the LeetCode solutions.
- **`problems/`**: Each file in this directory should correspond to a single LeetCode problem.

## How to Use

### Adding a New Problem

1.  Create a new file in the `problems/` directory (e.g., `problems/addtwonumbers.go`).
2.  Write your Go solution in that file. Make sure it's part of the `main` package.
3.  Add a corresponding test function for your solution in `main_test.go`.

### Running Tests

To run the tests for all the implemented solutions, execute the following command in the root directory of the project:

```bash
go test
```
