using FileData.Helper;
using NUnit.Framework;
using FluentAssertions;

namespace FileData.Tests.Client
{
    public class SizeTests
    {
        [Test]
        public void WhenGetMethodIsCalledWithValidInput_ThenItShoudReturn_ValidValue()
        {
            var version = new Size();
            var result = version.Get<string>("valid path");

            result.Should().NotBeEmpty();
        }
    }
}
