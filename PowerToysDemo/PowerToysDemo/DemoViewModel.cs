using System.Collections.ObjectModel;
using MvvmHelpers;

namespace PowerToysDemo
{
    public class DemoViewModel
    {
        public ObservableRangeCollection<DemoClass> ThisDoesntWork { get; } = new ObservableRangeCollection<DemoClass>();
        //public ObservableCollection<DemoClass> ThisWorks { get; } = new ObservableCollection<DemoClass>();

    }
}
