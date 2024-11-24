﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Context;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WeathersController : ControllerBase
	{
		WeatherContext context = new WeatherContext();
		// her bir api işleminin ne iş yapacağını köşeli parantizler içerisindeki etrübütler aracılığıyla programı iletiyoruz.
		[HttpGet]
		public IActionResult WeatherCityList() // asp.net core projelerinde backend kodları method içerisine yazılıyor
		{
			var values = context.Cities.ToList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateWeatherCity(City city)
		{
			context.Cities.Add(city);
			context.SaveChanges();
			return Ok("Şehir Eklendi");
		}

		[HttpDelete]
		public IActionResult DeleteWeatherCity(int id)
		{
			var value = context.Cities.Find(id);
			context.Cities.Remove(value);
			context.SaveChanges();
			return Ok("Şehir Silindi");
		}

		[HttpPut]
		public IActionResult UpdateWatherCity(City city)
		{
			var value = context.Cities.Find(city.CityId);
			value.CityName = city.CityName;
			value.Detail = city.Detail;
			value.Temp = city.Temp;
			value.Country = city.Country;
			context.SaveChanges();
			return Ok("Şehir Güncellendi");
		}

		[HttpGet("GetByIdWeatherCity")]
		public IActionResult GetByIdWeatherCity(int id)
		{
			var value = context.Cities.Find(id);
			return Ok(value);
		}

		//TOPLAM ŞEHİR SAYISINI VEREN APİ KODU
		[HttpGet("TotalCityCount")]
		public IActionResult TotalCityCount()
		{
			var value = context.Cities.Count();
			return Ok(value);
		}

		// EN DÜŞÜK SICAKLIK VE EN YÜKSEK SICAKLIK ŞEHİRLER
		[HttpGet("MaxTempCityName")]
		public IActionResult MaxTempCityName()
		{
			var value = context.Cities.OrderByDescending(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
			return Ok(value);
		}

		[HttpGet("MinTempCityName")]
		public IActionResult MinTempCityName()
		{
			var value = context.Cities.OrderBy(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
			return Ok(value);
		}
	}
}