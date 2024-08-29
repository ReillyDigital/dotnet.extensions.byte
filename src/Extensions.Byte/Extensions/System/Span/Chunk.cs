namespace ReillyDigital.Extensions.Byte;

public static partial class SpanExtensions
{
	/// <summary>
	/// Extension method to get a copy of this <see cref="Span{}" /> as a <see cref="Memory{}" /> split into blocks of
	/// bytes of the specified size. The final block will contain the remainder of bytes when not evenly divisible by
	/// the provided size.
	/// </summary>
	/// <param name="size">The number of bytes to return in each block.</param>
	/// <returns>
	/// A new <see cref="IEnumerable{}"> of <see cref="Memory{}" /> referencing a copy of the bytes from this
	/// <see cref="Span{}" /> as a collection of blocks.
	/// </returns>
	public static IEnumerable<Memory<T>> Chunk<T>(this Span<T> self, int size) => self.ToMemory().Chunk(size);
}
