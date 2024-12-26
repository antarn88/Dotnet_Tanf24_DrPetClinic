// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using DrPetClinic.Data.Entities;
using DrPetClinic.Bll.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using DrPetClinic.Data.Enums;


namespace DrPetClinic.Web.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<Employee> _userManager;
        private readonly SignInManager<Employee> _signInManager;
        private readonly IWebHostEnvironment _environment;

        public IndexModel(
            UserManager<Employee> userManager,
            SignInManager<Employee> signInManager,
            IWebHostEnvironment environment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _environment = environment;
        }

        public string Username { get; set; }


        [TempData]
        public string StatusMessage { get; set; }


        [BindProperty]
        public InputModel Input { get; set; }

        public EmployeeType EmployeeType { get; set; }


        public class InputModel
        {
            [Required]
            [Display(Name = "Name")]
            public string Name { get; set; }

            [Display(Name = "Description")]
            public string Description { get; set; }

            // [Required]
            [Display(Name = "Type")]
            public string Type { get; set; }


            [Display(Name = "Image")]
            public IFormFile Image { get; set; }


            [Display(Name = "ImageFileName")]
            public string ImageFileName { get; set; }

        }

        private async Task LoadAsync(Employee user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var userCustomData = await _userManager.GetUserAsync(User);

            Username = userName;
            EmployeeType = userCustomData.Type;

            Input = new InputModel
            {
                Name = userCustomData.Name,
                Description = userCustomData.Description,
                Type = userCustomData.Type.ToString(),
                ImageFileName = userCustomData.ImageFileName
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var userCustomData = await _userManager.GetUserAsync(User);
            if (Input.Name != userCustomData.Name)
            {
                user.Name = Input.Name;
                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set users custom data.";
                    return RedirectToPage();
                }
            }

            if (Input.Description != userCustomData.Description)
            {
                user.Description = Input.Description;
                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set users custom data.";
                    return RedirectToPage();
                }
            }

            // Képfeltöltés
            if (Input.Image == null || Input.Image.Length == 0)
            {
                user.ImageFileName = "no_pics.jpg";
                var result = await _userManager.UpdateAsync(user);

                if (!result.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set users custom data.";
                    return RedirectToPage();
                }
            }
            else
            {
                var fileName = Input.Image.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    var ext = Path.GetExtension(fileName).ToLowerInvariant();

                    if (string.IsNullOrEmpty(ext))
                    {
                        ModelState.AddModelError("Input.Image", "A kép kiterjesztése nem megfelelő");
                        return RedirectToPage();
                    }

                    var guid = Guid.NewGuid();
                    var directoryPath = Path.Combine(_environment.WebRootPath, "images/profileImages");
                    var filePath = Path.Combine(directoryPath, $"{guid}{ext}");

                    user.ImageFileName = $"{guid}{ext}";

                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await Input.Image.CopyToAsync(stream);
                        var result = await _userManager.UpdateAsync(user);

                        if (!result.Succeeded)
                        {
                            StatusMessage = "Unexpected error when trying to set users custom data.";
                            return RedirectToPage();
                        }
                    }
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }

        public string TypeDescription => Utils.GetEnumDescription(EmployeeType);
    }
}
