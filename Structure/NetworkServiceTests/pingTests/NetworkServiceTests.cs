using System;
using Xunit;
using NetworkUtility.ping;
using FluentAssertions;
namespace NetworkUtility.Tests.pingTests
{
	public class NetworkServiceTests
	{
		[Fact]
		public void NetworkServiceTests1()
		{
			var obj = new NetworkService();

			var res = obj.sent();

			res.Should().NotBeNullOrWhiteSpace();
			res.Should().NotBeNullOrEmpty();
			res.Should().Be("Ping sent");
			res.Should().Contain("Ping", Exactly.Once());

		}

		[Theory]
		[InlineData(1,2,3)]
		[InlineData(3,4,7)]

		public void return_int(int a, int b, int expected)
		{
			var obj = new NetworkService();
			var res = obj.ping_Time(a,b);

			res.Should().Be(expected);
			res.Should().BeGreaterThan(2);

		}

	}
}

