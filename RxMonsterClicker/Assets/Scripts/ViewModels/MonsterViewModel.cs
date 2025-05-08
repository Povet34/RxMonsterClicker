using R3;
using UnityEngine;

public class MonsterViewModel
{
    private readonly MonsterModel _model;

    public ReactiveProperty<int> TotalClicks { get; } = new(0);

    public MonsterViewModel(MonsterModel model)
    {
        _model = model;
    }

    public void Click()
    {
        TotalClicks.Value += _model.clickPower;
    }
}