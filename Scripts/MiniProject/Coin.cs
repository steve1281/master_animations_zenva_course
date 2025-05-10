using Godot;
using System;
using System.Reflection.Metadata.Ecma335;

public partial class Coin : Area2D
{
    [Export] public Texture2D[] coins;
    [Export] public Sprite2D coin;

    private int spriteIndex;

    public override void _Ready()
    {
        spriteIndex = (int)(GD.Randi() % coins.Length);
        coin.Texture = coins[spriteIndex];
    }

}
