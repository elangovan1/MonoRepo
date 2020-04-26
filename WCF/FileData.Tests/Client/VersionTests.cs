using FileData.Helper;
using NUnit.Framework;
using FluentAssertions;

namespace FileData.Tests.Client
{
    public class VersionTests
    {
        [Test]
        public void WhenGetMethodIsCalledWithValidInput_ThenItShoudReturn_ValidValue()
        {
            var version = new Version();
            var result = version.Get<string>("valid path");

            result.Should().NotBeEmpty();
        }
    }
}
