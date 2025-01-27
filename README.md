# Unleash Client Benchmark Test

This project benchmarks the performance of the Unleash Client for methods like `IsEnabled` and `GetVariant`.

## How to Run the Benchmark

1. **Upgrade the `Unleash.Client` to Your Desired Version**:
    - Open the `UnleashClientBenchmarkTest.csproj` file.
    - Update the `Unleash.Client` package reference to the desired version:
      ```xml
      <PackageReference Include="Unleash.Client" Version="x.x.x" />
      ```
      Replace `x.x.x` with the version you want to test.

    - Restore dependencies:
      ```bash
      dotnet restore
      ```

2. **Run the Benchmark**:
    - Open a terminal in the folder containing the `UnleashClientBenchmarkTest.csproj` file.
    - Execute the following command in the terminal:
      ```bash
      dotnet run --configuration Release
      ```

3. **View the Results**:
    - The benchmark output will include metrics such as execution time, memory allocations, and garbage collection information for each tested method.

## Example Output

| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| TestIsEnabled  | 2.931 us | 0.0585 us | 0.0928 us | 0.1678 |   2.09 KB |
| TestGetVariant | 4.950 us | 0.0976 us | 0.0913 us | 0.2899 |   3.67 KB |

## Notes
- Ensure that the `Unleash` instance URL in the benchmark setup points to your Unleash instance.
- Ensure that the `Authorization` header in the benchmark setup contains a valid API token for your Unleash instance.
- Add Properties to the `UnleashContext` in the benchmark setup as needed. 
- The benchmark is executed using the `Release` configuration.
- Results may vary based on the environment and configuration used during the test.

