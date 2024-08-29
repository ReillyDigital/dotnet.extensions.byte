namespace ReillyDigital.Extensions.Byte;

public static partial class ReadOnlyMemoryExtensions
{
	/// <summary>
	/// Extension method to split this <see cref="ReadOnlyMemory{}" /> into blocks of bytes of the specified size.
	/// </summary>
	/// <param name="size">The number of bytes to return in each block.</param>
	/// <returns>
	/// Bytes from this <see cref="ReadOnlyMemory{}" /> as a collection of blocks.
	/// </returns>
	public static IEnumerable<ReadOnlyMemory<T>> Chunk<T>(this ReadOnlyMemory<T> self, int size)
	{
		for (var offset = 0; offset < self.Length; offset += size)
		{
			yield return self.Slice(offset, Math.Min(size, self.Length - offset));
		}
	}
}
