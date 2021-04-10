using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace $PROJECT_NAME$.IntegrationTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public async Task AsyncTest()
        {
            using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            var cancellationToken = cancellationTokenSource.Token;

            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
        }
		
        [TestMethod]
        public void Test()
        {
			"".Should().Be("");
        }
    }
}
