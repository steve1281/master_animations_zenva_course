using Godot;
using System;

public partial class Project : Node
{
    [Export] public PackedScene coin {get; private set;}

    public void SpawnNewCoin() {
        Area2D coinInstance = (Area2D)coin.Instantiate();
        AddChild(coinInstance);
        coinInstance.Position = new Vector2(576, 248);

    }

}
