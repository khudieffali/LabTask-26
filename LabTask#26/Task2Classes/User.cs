using LabTask_26.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_26.Task2Classes
{
    internal class User
    {
       private ILanguage _language;
        public User(ILanguage language)
        {
            _language = language;
        }
            
        public void Speak()
        {
            _language.Speak();
        }
    }
}
