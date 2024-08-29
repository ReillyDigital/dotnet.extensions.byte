namespace ReillyDigital.Extensions.Byte;

public static partial class MemoryExtensions
{
	/// <summary>
	/// Extension method to split this <see cref="Memory{}" /> into blocks of bytes of the specified size. The final
	/// block will contain the remainder of bytes when not evenly divisible by the provided size.
	/// </summary>
	/// <param name="size">The number of bytes to return in each block.</param>
	/// <returns>
	/// Bytes from this <see cref="Memory{}" /> as a collection of blocks.
	/// </returns>
	public static IEnumerable<Memory<T>> Chunk<T>(this Memory<T> self, int size)
	{
		for (var offset = 0; offset < self.Length; offset += size)
		{
			yield return self.Slice(offset, Math.Min(size, self.Length - offset));
		}
	}
}
