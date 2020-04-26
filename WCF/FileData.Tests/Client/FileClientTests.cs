using FileData.Client;
using FileData.Helper;
using NUnit.Framework;
using FluentAssertions;
using Moq;

namespace FileData.Tests.Client
{
    public class FileClientTests
    {
        [Test]
        public void WhenGetMethodIsCalledWithValidInput_ThenItShoudReturn_ValidValue()
        {
            var fileProperty = new Mock<IProperty>();
            var ensure = new Mock<IEnsure>();
            var client = new FileClient(fileProperty.Object, ensure.Object);

            ensure.Setup(m => m.IsValidType(It.IsAny<string>())).Returns(true);
            fileProperty.Setup(m => m.Get<string>(It.IsAny<string>())).Returns("Version number");

            var result = client.Get<string>(It.IsAny<string>(), It.IsAny<string>());
            fileProperty.Verify(m => m.Get<string>(It.IsAny<string>()), Times.Once);
            ensure.Verify(m => m.IsValidType(It.IsAny<string>()), Times.Once);

            result.Should().BeOfType<string>();
            result.Should().Be("Version number");
        }


        [Test]
        public void WhenGetMethodIsCalledWithInvalidInput_ThenItShoudReturn_ValidValue()
        {
            var fileProperty = new Mock<IProperty>();
            var ensure = new Mock<IEnsure>();
            var client = new FileClient(fileProperty.Object, ensure.Object);

            ensure.Setup(m => m.IsValidType("Invalid input")).Returns(false);
            fileProperty.Setup(m => m.Get<string>(It.IsAny<string>())).Returns(It.IsAny<string>());

            var result = client.Get<string>(It.IsAny<string>(), It.IsAny<string>());

            fileProperty.Verify(m => m.Get<string>(It.IsAny<string>()), Times.Never);
            ensure.Verify(m => m.IsValidType(It.IsAny<string>()), Times.Once);

            result.Should().BeNullOrEmpty();
        }
    }
}
