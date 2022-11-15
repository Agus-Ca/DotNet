# DotNet
Este proyecto se crea con la finalidad de practicar y estudiar distintas librerias tanto de C# como de .NET.

---

## Benchmark
Para hacer benchmarking en C# necesitaremos:
1. Instalar desde NuGet **"BenchmarkDotNet"**
2. Crear una clase **ClassBenchmark.cs** (donde Class es el nombre de la clase a trabajar)
3. Agregar todos los metodos de los cuales se quiere hacer un benchmark con el decoraador **[Benchmark]**
4. En la clase **Program.cs** agregar la linea `BenchmarkRunner.Run<ClassBenchmark>();`

### For more information visit *https://benchmarkdotnet.org/index.html*

---