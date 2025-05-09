using Godot;
using System;

public partial class Ship : Sprite2D
{
    [Export] public bool IsMoving { get; private set;}
    [Export] public int Speed {get; private set;}

    public override void _Process(double delta)
    {
        //GD.Print($"Ship::_Process:IsMoving = {IsMoving}");
        //GD.Print($"Ship::_Process:Speed = {Speed}");
    }


    public void NotMoving()
    {
        GD.Print($"Ship::NotMoving called.");
    }

    public void PrintNumber(int number) {

        GD.Print($"Ship::PrintNumber {number}.");
    }
}
