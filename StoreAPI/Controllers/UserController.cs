﻿using Microsoft.AspNetCore.Mvc;
using StoreProjectModels.DatabaseModels;
using StoreServices;
using StoreServices.Interfaces;

namespace StoreAPI.Controllers
{
	[Route("api/user")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		[Route("getAllUsers")]
		public IActionResult GetAllUsers()
		{
			return Ok(_userService.GetAllUsers());
		}
		[HttpGet]
		[Route("getUser")]
		public IActionResult GetUser(string userId)
		{
			return Ok(_userService.GetUser(userId));
		}
		[HttpPost]
		[Route("addUser")]
		public IActionResult AddUser(User user)
		{
			return Ok(_userService.AddUser(user));
		}
		[HttpPut]
		[Route("updateUser")]
		public IActionResult UpdateUser(User user)
		{
			return Ok(_userService.UpdateUser(user));
		}
		[HttpDelete]
		[Route("deleteUser")]
		public IActionResult DeleteUser(string userId)
		{
			return Ok(_userService.DeleteUser(userId));
		}
	}
}
