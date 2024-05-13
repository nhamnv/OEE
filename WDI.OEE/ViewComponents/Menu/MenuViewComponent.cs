﻿using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace WDI.OEE.ViewComponents.Menu
{
    [ViewComponent]
    public class MenuViewComponent : ViewComponent
    {
        private readonly IData_MenuService _data_MenuService;
        public MenuViewComponent(IData_MenuService data_MenuService)
        {
            _data_MenuService = data_MenuService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _data_MenuService.GetList();

            return await Task.FromResult(View(model));
        }
    }
}
