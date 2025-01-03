﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace _09ActionResultFilter.Filters
{
    public class DynamicLayoutFilter :IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Controller is Controller controller)
            {
                var actionName = context.RouteData.Values["action"].ToString();
                if (actionName == "About")
                {
                    controller.ViewData["Layout"] = "~/Views/Shared/_Layout1.cshtml";
                }
            }

        }
        public void OnResultExecuted(ResultExecutedContext context)
        {
            //Nothing here...
        }


    }
}