﻿using EBS.WebUI.DTOs.ContactDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ContactController : Controller
    {

        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultContactDto>>("contacts");
            return View(values); 
        }

        public async Task<IActionResult> DeleteContact(int id)
        {
            await _client.DeleteAsync($"contacts/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto  )
        {
            await _client.PostAsJsonAsync("contacts", createContactDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> UpdateContact(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateContactDto>($"contacts/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto  )
        {
            await _client.PutAsJsonAsync("contacts", updateContactDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DetailsContact(int? id)
        {
            var value = await _client.GetFromJsonAsync<ResultContactDto>($"contacts/{id}");
            return View(value);
        }


        public async Task<IActionResult> ContactChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateContactDto>($"Contacts/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Contacts", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ContactChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateContactDto>($"Contacts/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Contacts", values);
            return RedirectToAction(nameof(Index));
        }
    }
}
