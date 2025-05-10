using Godot;
using System;
using System.Reflection.Metadata.Ecma335;

public partial class Coin : Area2D
{
    [Export] public Texture2D[] coins;
    [Export] public Sprite2D coin;
    [Export] public AnimationPlayer animPlayer;

    private int spriteIndex;

    public override void _Ready()
    {
        BodyEntered += HandleBodyEntered;
        
        spriteIndex = (int)(GD.Randi() % coins.Length);
        coin.Texture = coins[spriteIndex];
    }

    private void HandleBodyEntered(Node2D body)
    {
        //GD.Print($"Coin::HandleBodyEntered:body.Name = {body.Name}");
        if (body.Name == "Player") {
            animPlayer.Play("CollidedWithPlayer");
        }
    }
}
