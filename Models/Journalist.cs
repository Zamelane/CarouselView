using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarouselView.models
{
    public class Journalist
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Img { get; set; } = "";
        public ObservableCollection<Fact> Evidence { get; set; } = new ObservableCollection<Fact>();
    }
}
