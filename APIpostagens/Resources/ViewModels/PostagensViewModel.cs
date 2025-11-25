using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIpostagens.Resources.ViewModels
{
    public class PostagensViewModel : ObservableObject
    {
        [ObservableProperty]    
        public int userid;
        public int Id;
        string Title;
        string Body;
    }
}
