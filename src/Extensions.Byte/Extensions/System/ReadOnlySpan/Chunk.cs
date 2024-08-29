namespace ReillyDigital.Extensions.Byte;

public static partial class ReadOnlySpanExtensions
{
	/// <summary>
	/// Extension method to get a copy of this <see cref="ReadOnlySpan{}" /> as a <see cref="ReadOnlyMemory{}" /> split
	/// into blocks of bytes of the specified size.
	/// </summary>
	/// <param name="size">The number of bytes to return in each block.</param>
	/// <returns>
	/// A new <see cref="ReadOnlyMemory{}" /> referencing a copy of the bytes from this <see cref="ReadOnlySpan{}" /> as
	/// a collection of blocks.
	/// </returns>
	public static IEnumerable<ReadOnlyMemory<T>> Chunk<T>(this ReadOnlySpan<T> self, int size) =>
		self.ToMemory().Chunk(size);
}
