using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project_13WeatherApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/istanbul/EN"),
				Headers =
	{
		{ "x-rapidapi-key", "1ccc143384msh762637ad3480ecep1fe27djsndc8d1d7b2069" },
		{ "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var json = JObject.Parse(body);
				var fahrenheit = json["main"]["feels_like"].ToString();
				var windSpeed = json["wind"]["speed"].ToString();
				var humidity = json["main"]["humidity"].ToString();
				lblFahrenheit.Text = fahrenheit;
				lblHumidity.Text = humidity;
				lblWindSpeed.Text = windSpeed;
				double celcius = (double.Parse( fahrenheit) - 32);
				double celciusValue = celcius / 1.8;
				lblCelsius.Text = celciusValue.ToString("0.00");

				var weather = json["weather"][0]["main"].ToString();

				string filePath = @"C:\Users\Dell\source\repos\MyUdemy20Projects\Project_13WeatherApp\images\";
				string fileName = "";
				
				if (weather == "Clouds")
				{
					fileName = "cloud.png";
				}
				else if(weather == "Sun")
				{
					fileName = "sun.png";
				}
				else if(weather == "Snow")
				{
					fileName = "snow.png";
				}
				else if(weather == "Rain")
				{
					fileName = "rainy.png";
				}
				else if(weather == "Mist")
				{
					fileName = "mist.png";
				}

				string imagePath = Path.Combine(filePath, fileName);
				pictureBox1.Image = Image.FromFile(imagePath);
			}
		}
	}
}
