using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomerMusicApp.Views
{
    public interface IView<T>
    {
        public void DisplaySingle(T entity);
        public void DisplayAll(List<T> entities);
    }
}
