﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkFive.Model;

namespace HomeworkFive.Factory
{
    public class TasteSnakeFactory : IFactory
    {
        public BaseDish CreateDish()
        {
            return new TasteSnake();
        }
    }
}