﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.AboutDtos
{
    public class ResultAboutDto
    {
        public int AboutID { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; } //Başlık
        public string Description { get; set; } //Açıklama
    }
}
