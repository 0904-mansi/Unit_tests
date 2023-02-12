using System;
namespace NetworkUtility.ping
{
	public class NetworkService
	{
		public string sent()
			{
			return "Ping sent";
			}

		public int ping_Time(int a, int b)
		{
			return a + b;
		} 
		public DateTime datetime()
		{
			return DateTime.Now;
		}

		public PingOptions PingOption()
		{
			return new PingOptions()
			{
				DontFragment = true,
				Ttl=1
			};
		}


        public IEnumerable<PingOptions> PingOption_()
        {
			IEnumerable<PingOptions> pingop = new[]{

			new PingOptions(){
					DontFragment = true,
				Ttl = 1
			},
			 new PingOptions()
			{
				DontFragment = true,
				Ttl = 1
			},
			 new PingOptions()
			{
				DontFragment = true,
				Ttl = 1
			},

			};

			return pingop;
		}
	    }

	}
