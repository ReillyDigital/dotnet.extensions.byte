namespace ReillyDigital.Extensions.Byte;

public static partial class ReadOnlySpanExtensions
{
	public static IEnumerable<ReadOnlyMemory<T>> Chunk<T>(this ReadOnlySpan<T> self, int size) =>
		self.ToMemory().Chunk(size);
}
