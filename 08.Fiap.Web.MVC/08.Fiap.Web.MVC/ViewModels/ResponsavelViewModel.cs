﻿using _08.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08.Fiap.Web.MVC.ViewModels
{
    public class ResponsavelViewModel
    {
        public Responsavel Responsavel { get; set; }
        public SelectList Responsaveis { get; set; }
    }
}