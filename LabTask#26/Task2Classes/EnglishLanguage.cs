﻿using LabTask_26.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_26.Task2Classes
{
    internal class EnglishLanguage : ILanguage
    {
        public void Speak()
        {
            Console.WriteLine("Hello! How are you?"); ;
        }
    }
}
