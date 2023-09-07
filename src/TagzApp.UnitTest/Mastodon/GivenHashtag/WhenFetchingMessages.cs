namespace TagzApp.UnitTest.Mastodon.GivenHashtag;
// Ignore Spelling: Sut

using TagzApp.Providers.Mastodon;
public class WhenFetchingMessages
{

	public readonly Hashtag Given = new Hashtag()
	{
		Text = "dotnet"
	};

	public MastodonProvider _Sut;

	public WhenFetchingMessages()
	{
		_Sut = new MastodonProvider();
	}

	[Fact]
	public async Task ShouldReceiveMessages()
	{

		// act
		var messages = await _Sut.GetContentForHashtag(Given, DateTimeOffset.UtcNow.AddHours(-1));

		// assert
		Assert.NotEmpty(messages);
	}

}