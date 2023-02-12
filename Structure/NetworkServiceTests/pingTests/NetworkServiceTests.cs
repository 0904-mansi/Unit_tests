using System;
using Xunit;
using NetworkUtility.ping;
using FluentAssertions;
using FluentAssertions.Extensions;
using System.Net.NetworkInformation;	
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
[Fact]

		public void return_date()
		{
			var res = pingservice.datetime();

			res.Should().BeBefore(1. January(2030));
			res.Should().BeAfter(1.January(2020));
		}

		[Fact]
		public void return_object()
		{

			var expected = new PingOptions()
			{
				DontFragment = true,
				Ttl = 1
			};

			var res = pingservice.PingOption();
			res.Should().BeOfType<PingOptions>();
			res.Should().BeEquivalentTo(expected);
			res.Ttl.Should().Be(1);
		}


        [Fact]
        public void return_ping_object()
        {

            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            var res = pingservice.PingOption_();
            //res.Should().BeOfType<PingOptions>();
            res.Should().ContainEquivalentOf(expected);
	    res.Should().Contain(x => x.DontFragment == true);
        }
    }
}


