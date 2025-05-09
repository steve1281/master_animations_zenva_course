using Godot;
using System;

public partial class Player : RigidBody2D
{
    [Export] public bool CanJump {get; private set;} = true;
    [Export] private AnimationPlayer animPlayer;

    public override void _Ready()
    {
        BodyEntered += HandleBodyEntered;
    }

    private void HandleBodyEntered(Node body)
    {
        if (body.IsInGroup("TileMapLayer")) {
            animPlayer.Play("Idle");    

        }
    }


    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("jump")  && CanJump) {
            animPlayer.Play("Jump");    
        } 
    }

}
