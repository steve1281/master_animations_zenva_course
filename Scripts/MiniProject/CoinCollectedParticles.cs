using Godot;
using System;

public partial class CoinCollectedParticles : CpuParticles2D
{
    public void Emit(Color coinColor) {
        Emitting = true;
        Color = coinColor;
    }
}
