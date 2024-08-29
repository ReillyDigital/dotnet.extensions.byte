namespace ReillyDigital.Extensions.Byte.Sample;

public static class ChunkScenario
{
	public static void Run()
	{
		Span<byte> bytes = System.Text.Encoding.UTF8.GetBytes(
			"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi "
			+ "hendrerit nisi maximus egestas luctus. Morbi porta diam bibendum "
			+ "metus lacinia, lobortis consequat sem dignissim. Proin neque risus, "
			+ "molestie nec posuere ac, commodo a quam. Donec id auctor mi."
		);
		foreach (var chunk in bytes.Chunk(32))
		{
			Console.WriteLine(System.Text.Encoding.UTF8.GetString(chunk.Span));
			Console.WriteLine();
		}
	}
}
