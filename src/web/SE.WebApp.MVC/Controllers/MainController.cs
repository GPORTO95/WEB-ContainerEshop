﻿using Microsoft.AspNetCore.Mvc;
using SE.WebApp.MVC.Models;

namespace SE.WebApp.MVC.Controllers
{
    public class MainController : Controller
    {
        protected bool ResponsePossuiErros(ResponseResult resposta)
        {
            if (resposta != null && resposta.Errors.Mensagens.Any())
                return true;

            return false;
        }
    }
}
