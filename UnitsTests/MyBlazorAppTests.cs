using BlazorApp.Pages;
using Bunit;
using Xunit;

namespace UnitTests
{
    public class MyBlazorAppTests : TestContext
    {
        [Fact]
        public void Counter_Increments_Count_When_Button_Is_Clicked()
        {
            // Arrange
            var cut = RenderComponent<Counter>();

            // Act
            cut.Find("button").Click();

            // Assert
            var actualCount = int.Parse(cut.Find("#current-count").InnerHtml);
            Assert.Equal(1, actualCount);
        }

        /*[Theory]
        [InlineData("John")]
        [InlineData("Jane")]
        public void Greeting_Displays_Correct_Message(string name)
        {
            // Arrange
            var cut = RenderComponent<Greetings>(
                ("Name", name));

            // Assert
            cut.MarkupContains($"Hello, {name}!");
        }*/
    }
}