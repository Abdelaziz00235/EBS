using EBS.WebUI.DTOs.EmployeeDtos;
using EBS.WebUI.Services.EmployeeServices;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EBS.WebUI.Controllers
{
    public class LoginController(IEmployeeService _employeeService) : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignInAsync(EmployeeLoginDto employeeLoginDto)
        {
            var userRole =await _employeeService.LoginAsync(employeeLoginDto);

            if (userRole == "SuperAdmin")
            {
                return RedirectToAction("Index", "SuperAdmin", new { Areas = "SuperAdmin" });
            }
            if (userRole == "Admin") 
            {
                return RedirectToAction("Index","Home",new {Areas="Admin"});
            }
            
            if (userRole == "Magasinier") 
            {
                return RedirectToAction("Index", "Magasinier", new {Areas= "Magasinier" });
            }
            if (userRole == "AssistantLogistique") 
            {
                return RedirectToAction("Index", "AssistantLogistique", new {Areas= "AssistantLogistique" });
            }
            if (userRole == "ResponsableLogistique") 
            {
                return RedirectToAction("Index", "ResponsableLogistique", new {Areas= "ResponsableLogistique" });
            }
            if (userRole == "GestionnaireDestock") 
            {
                return RedirectToAction("Index", "GestionnaireDestock", new {Areas= "Gestionnaire_de_stock" });
            }
            if (userRole == "Client") 
            {
                return RedirectToAction("Index", "Client", new {Areas= "Client" });
            }
            if (userRole == "Role1") 
            {
                return RedirectToAction("Index", "Home", new {Areas= "Role1" });
            }
            if (userRole == "Role2") 
            {
                return RedirectToAction("Index", "Role2", new {Areas= "Role2" });
            }
            else
            {
                ModelState.AddModelError("", "Email ou Mote de passe Incorrect");
                return View();
            }



        }
    }
}
