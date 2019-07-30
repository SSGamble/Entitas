//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MultiReactive.NameComponent multiReactiveName { get { return (MultiReactive.NameComponent)GetComponent(GameComponentsLookup.MultiReactiveName); } }
    public bool hasMultiReactiveName { get { return HasComponent(GameComponentsLookup.MultiReactiveName); } }

    public void AddMultiReactiveName(string newName) {
        var index = GameComponentsLookup.MultiReactiveName;
        var component = (MultiReactive.NameComponent)CreateComponent(index, typeof(MultiReactive.NameComponent));
        component.name = newName;
        AddComponent(index, component);
    }

    public void ReplaceMultiReactiveName(string newName) {
        var index = GameComponentsLookup.MultiReactiveName;
        var component = (MultiReactive.NameComponent)CreateComponent(index, typeof(MultiReactive.NameComponent));
        component.name = newName;
        ReplaceComponent(index, component);
    }

    public void RemoveMultiReactiveName() {
        RemoveComponent(GameComponentsLookup.MultiReactiveName);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMultiReactiveName;

    public static Entitas.IMatcher<GameEntity> MultiReactiveName {
        get {
            if (_matcherMultiReactiveName == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MultiReactiveName);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMultiReactiveName = matcher;
            }

            return _matcherMultiReactiveName;
        }
    }
}