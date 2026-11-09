using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace G26W08WPFCounter;

//[ObservableObject]
public partial class CounterViewModel(CounterModel model) : ObservableObject
{
    [ObservableProperty]
    private int _count = model.Count;

    [RelayCommand]
    private void Increment() => Count = model.Increment();
    //private void Increment() {
    //    Count = model.Increment();
    //}

    [RelayCommand]
    private void Decrement() => Count = model.Decrement();
    //private void Decrement() {
    //    Count = model.Decrement();
    //}
}
