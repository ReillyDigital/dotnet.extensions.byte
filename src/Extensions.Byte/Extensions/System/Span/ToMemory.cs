namespace ReillyDigital.Extensions.Byte;

public static partial class SpanExtensions
{
	/// <summary>
	/// Extension method to get this <see cref="Span{}" /> as a <see cref="Memory{}" />.
	/// </summary>
	/// <returns>
	/// A new <see cref="Memory{}" /> referencing a copy of the bytes from this <see cref="Span{}" />.
	/// </returns>
	public static Memory<T> ToMemory<T>(this Span<T> self) => self.ToArray();
}
