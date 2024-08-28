namespace ReillyDigital.Extensions.Byte;

public static partial class SpanExtensions
{
	public static Memory<T> ToMemory<T>(this Span<T> self) => self.ToArray();
}
