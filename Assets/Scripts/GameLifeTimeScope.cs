using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;


public class GameLifeTimeScope : LifetimeScope
{
    [SerializeField] private Dispatcher _dispatcher;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<RoundsSystem>(Lifetime.Scoped);
        builder.RegisterComponent(_dispatcher);
    }
}
