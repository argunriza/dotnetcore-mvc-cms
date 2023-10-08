﻿using Cms.Data.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Doctor.Controllers
{
	public class DoctorController : Controller
	{

		private readonly HttpClient _httpClient;
		private readonly string _apiDoctor = "https://localhost:7078/api/Doctors";

		public DoctorController(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<ActionResult> Index()
		{
			var model = await _httpClient.GetFromJsonAsync<List<DoctorEntity>>(_apiDoctor);

			return View(model);
		}

		public async Task<ActionResult> Detail(int id)
		{
			// Belirli bir doktorun detaylarını getir.
			var doctor = await _httpClient.GetFromJsonAsync<DoctorEntity>($"{_apiDoctor}/{id}");

			if (doctor == null)
			{
				// Belirli bir doktor bulunamazsa hata sayfasına yönlendirme yapılabilir.
				return NotFound();
			}

			return View(doctor);
		}
	}
}
