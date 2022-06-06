﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomerMusicApp.Factories
{
    public interface IFactory<T> where T : class
    {
        public T Create();
    }
}
