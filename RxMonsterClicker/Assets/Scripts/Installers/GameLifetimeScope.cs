using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] private MonsterModel monsterModel;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(monsterModel);
        builder.Register<MonsterViewModel>(Lifetime.Singleton);
    }
}
