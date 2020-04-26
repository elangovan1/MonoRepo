using NUnit.Framework;
using System;
using FileData.Helper;
using FluentAssertions;

namespace FileData.Tests.Client
{
    public class EnsureTests
    {
        [Test]
        public void WhenIsValidTypeMethodIsCalledWithValidInput_ThenItShoudReturn_True()
        {
            var ensure = new Ensure();
            var result = ensure.IsValidType("-s");

            result.Should().BeTrue();
        }

        [Test]
        public void WhenIsValidTypeMethodIsCalledWithValidInput_ThenItShoudReturnException()
        {
            var ensure = new Ensure();
            Action result = () => ensure.IsValidType("-sssss"); 
            result.Should().Throw<ArgumentException>();
        }
    }
}
