﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.ViewComponents
{
    public class DataListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string name)
        {
            var data = await GetByNameAsync(name);
            return View(data);
        }

        private Task<IEnumerable<Data>> GetByNameAsync(string name)
        {
            return Task.FromResult(GetByName(name));
        }

        private IEnumerable<Data> GetByName(string name)
        {
            DataService service = new DataService();
            return service.GetDataByName(name);
        }
    }
}
