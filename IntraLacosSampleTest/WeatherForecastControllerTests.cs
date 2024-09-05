using Moq;
using Microsoft.Extensions.Logging;
using IntraLacosSample.Controllers;

public class WeatherForecastControllerTests
{
    private readonly WeatherForecastController _controller;
    private readonly Mock<ILogger<WeatherForecastController>> _loggerMock;

    public WeatherForecastControllerTests()
    {
        _loggerMock = new Mock<ILogger<WeatherForecastController>>();
        _controller = new WeatherForecastController(_loggerMock.Object);
    }

    [Fact]
    public void Get_ShouldReturnFiveWeatherForecasts()
    {
        // Act
        var result = _controller.Get();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(5, result.Count()); // Verifica se o resultado contém 5 elementos
    }

    [Fact]
    public void Get_ShouldReturnDifferentWeatherForecastsEachTime()
    {
        // Act
        var firstResult = _controller.Get();
        var secondResult = _controller.Get();

        // Assert
        Assert.NotEqual(firstResult, secondResult); // Os resultados devem ser diferentes por causa do Random
    }
}