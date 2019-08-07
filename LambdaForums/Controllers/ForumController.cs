﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lambdaForums.data;
using lambdaForums.data.Models;
using LambdaForums.Models.Forum;
using Microsoft.AspNetCore.Mvc;

namespace LambdaForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }

        public IActionResult Index()
        {
            //get list of forum
          var forums = _forumService.Getall().Select(forum => new ForumListingModel {
                Id = forum.Id,
                Name=forum.Title,
                Description=forum.Description
            });
            var model = new ForumIndexModel
            {
                ForumList = forums
            };
            return View(model);
        }
        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
        }
    }
}