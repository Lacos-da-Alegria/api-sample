using IntraLacosSample;

namespace IntraLacosSampleTest;

public class WeatherForecastTests
{
    [Fact]
    public void TemperatureF_Should_Calculate_Correctly()
    {
        // Arrange
        var forecast = new WeatherForecast
        {
            TemperatureC = 0
        };

        // Act
        var temperatureF = forecast.TemperatureF;

        // Assert
        Assert.Equal(32, temperatureF); // 0°C should be 32°F
    }

    [Fact]
    public void Summary_Should_Be_Set_And_Retrieved_Correctly()
    {
        // Arrange
        var forecast = new WeatherForecast
        {
            Summary = "Sunny"
        };

        // Act
        var summary = forecast.Summary;

        // Assert
        Assert.Equal("Sunny", summary);
    }

    [Fact]
    public void Date_Should_Be_Set_And_Retrieved_Correctly()
    {
        // Arrange
        var date = new DateOnly(2024, 9, 5);
        var forecast = new WeatherForecast
        {
            Date = date
        };

        // Act
        var forecastDate = forecast.Date;

        // Assert
        Assert.Equal(date, forecastDate);
    }
}