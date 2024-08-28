namespace ReillyDigital.Extensions.Byte;

public static partial class MemoryExtensions
{
	public static IEnumerable<Memory<T>> Chunk<T>(this Memory<T> self, int size)
	{
		for (var offset = 0; offset < self.Length; offset += size)
		{
			yield return self.Slice(offset, Math.Min(size, self.Length - offset));
		}
	}
}
