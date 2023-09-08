﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SuperCarteInfiniMVC.Data;
using SuperCarteInfiniMVC.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SuperCarteInfiniMVC.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        readonly UserManager<IdentityUser> UserManager;
        readonly ApplicationDbContext _context;
        readonly SignInManager<IdentityUser> SignInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterDTO register)
        {
            if (register.Password != register.ConfirmPassword)
            {
                return StatusCode(StatusCodes.Status400BadRequest,
                    new { Message = "Les deux mots de passe spécifiés sont différents." });
            }
            IdentityUser user = new IdentityUser()
            {
                UserName = register.Email,
                Email = register.Email
            };
            IdentityResult identityResult = await this.UserManager.CreateAsync(user, register.Password);
            if (!identityResult.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Message = "La création de l'utilisateur a échoué." });
            }
            return Ok(new { Message = "Inscription réussie ! 🥳" });
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginDTO login)
        {
            var result = await SignInManager.PasswordSignInAsync(login.UserName, login.Password, true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return Ok();
            }

            return NotFound(new { Error = "L'utilisateur est introuvable ou le mot de passe de concorde pas" });
        }

        [Authorize]
        public ActionResult<string[]> Data()
        {
            return new string[] { "figue", "banane", "noix" };
        }

        public async Task<ActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return Ok();
        }
    }
}
