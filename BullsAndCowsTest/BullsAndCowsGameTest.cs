using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_return_4A0B_when_guess_given_guess_is_same_as_secret()
        {
            //given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(x => x.GenerateSecret()).Returns("1 2 3 4");
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            var res = game.Guess("1 2 3 4");
            //then
            Assert.Equal("4A0B", res);
        }

        [Fact]
        public void Should_return_2A0B_when_guess_given_2_digits_of_guess_is_same_as_secret()
        {
            //given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(x => x.GenerateSecret()).Returns("1 2 3 4");
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            var res = game.Guess("1 2 5 6");
            //then
            Assert.Equal("2A0B", res);
        }
    }
}
