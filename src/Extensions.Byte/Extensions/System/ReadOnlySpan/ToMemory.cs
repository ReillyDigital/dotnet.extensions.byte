namespace ReillyDigital.Extensions.Byte;

public static partial class ReadOnlySpanExtensions
{
	/// <summary>
	/// Extension method to get this <see cref="ReadOnlySpan{}" /> as a <see cref="ReadOnlyMemory{}" />.
	/// </summary>
	/// <returns>
	/// A new <see cref="ReadOnlyMemory{}" /> referencing a copy of the bytes from this <see cref="ReadOnlySpan{}" />.
	/// </returns>
	public static ReadOnlyMemory<T> ToMemory<T>(this ReadOnlySpan<T> self) => self.ToArray();
}
