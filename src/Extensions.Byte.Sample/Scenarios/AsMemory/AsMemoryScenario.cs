namespace ReillyDigital.Extensions.Byte.Sample;

public static class AsMemoryScenario
{
	public static void Run()
	{
		Span<byte> bytes = [
			0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20,
			0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21
		];
		DoStuffAsync(bytes.ToMemory()).Wait();
	}

	private static async Task DoStuffAsync(Memory<byte> chunk)
	{
		await Task.Delay(100);
		Console.WriteLine(System.Text.Encoding.UTF8.GetString(chunk.Span));
	}
}
