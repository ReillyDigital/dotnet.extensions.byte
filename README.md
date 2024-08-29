# ReillyDigital.Extensions.Byte

Extension methods for working with bytes.

## Usage

### AsMemory

Given a `Span<byte>` value:
```csharp
Span<byte> bytes = [
	0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21
];
```

And given an `async` function which cannot work with `Span<byte>` types as input or output, but it is desired to work with in-memory references:
```csharp
public static async Task DoStuffAsync(Memory<byte> chunk)
{
	await Task.Delay(100);
	Console.WriteLine(System.Text.Encoding.UTF8.GetString(chunk.Span));
}
```

The convenience function `.ToMemory` can be used to explicitly copy the `Span<byte>` to a `Memory<byte>` value.
```csharp
DoStuffAsync(bytes.ToMemory()).Wait();
```

Albeit there is an implicit cast from `T[]` to `Memory<T>`, and the `Span<T>` type has a method `ToArray` which can be used to assign a value to a `Memory<T>` using that implicit cast; however, it may be more preferrable in some scenarios to use the explicit `ToMemory` extension method, such as when creating a variable reference using the implicit `var` keyword where the desire is to assign a `Memory<T>` rather than a `T[]`.

### Chunk

Given a `Span<byte>` value:
```csharp
Span<byte> bytes = System.Text.Encoding.UTF8.GetBytes(
	"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi "
	+ "hendrerit nisi maximus egestas luctus. Morbi porta diam bibendum "
	+ "metus lacinia, lobortis consequat sem dignissim. Proin neque risus, "
	+ "molestie nec posuere ac, commodo a quam. Donec id auctor mi."
);
```

The `Span<byte>` can be split into blocks of values for individual processing.
```csharp
foreach (var chunk in bytes.Chunk(32))
{
	Console.WriteLine(System.Text.Encoding.UTF8.GetString(chunk.Span));
	Console.WriteLine();
}
```

The chunks are provided as an enumerator so that large amounts of data can be processesed without copying an entire `Span<T>` to a new `T[]` or `Memory<T>` in full.

Albeit the `Span<T>` type has a method `Slice` that can be used to process smaller chuncks without a copy; however, this is not feasible in scenarios such as `async` methods which cannot take a `Span<T>` as input or output. Or in such scenarios as functions that need to provide an `IEnumerable<>` for each chunk, but a `Span<T>` cannot be used as a type parameter.

## Links

Sample Project:
https://gitlab.com/reilly-digital/dotnet/extensions.byte/-/tree/main/src/Extensions.Byte.Sample

NuGet:
https://www.nuget.org/packages/ReillyDigital.Extensions.Byte
