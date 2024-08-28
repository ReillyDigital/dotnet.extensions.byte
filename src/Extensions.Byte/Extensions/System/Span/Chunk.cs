namespace ReillyDigital.Extensions.Byte;

public static partial class SpanExtensions
{
	public static IEnumerable<Memory<T>> Chunk<T>(this Span<T> self, int size) => self.ToMemory().Chunk(size);
}
