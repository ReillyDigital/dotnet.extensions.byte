namespace ReillyDigital.Extensions.Byte;

public static partial class ReadOnlySpanExtensions
{
	public static ReadOnlyMemory<T> ToMemory<T>(this ReadOnlySpan<T> self) => self.ToArray();
}
