﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modas.Models;
using System.Linq;

namespace Modas.Controllers
{
    public class HomeController : Controller
    {
        private readonly int PageSize = 20;
        private IEventRepository repository;
        public HomeController(IEventRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(int page = 1) => View(new ViewEvents()
        {
            Events = repository.Events
            .Include(e => e.Location)
            .OrderByDescending(e => e.TimeStamp)
            .Skip((page - 1) * PageSize)
            .Take(PageSize),
            Pages = new Pages()
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalEvents = repository.Events.Count()
            }
        });

    }
}
