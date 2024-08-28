namespace ReillyDigital.Extensions.Byte;

public static partial class ReadOnlyMemoryExtensions
{
	public static IEnumerable<ReadOnlyMemory<T>> Chunk<T>(this ReadOnlyMemory<T> self, int size)
	{
		for (var offset = 0; offset < self.Length; offset += size)
		{
			yield return self.Slice(offset, Math.Min(size, self.Length - offset));
		}
	}
}
