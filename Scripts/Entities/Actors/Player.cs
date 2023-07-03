using Godot;
using System;

public partial class Player : Actor
{
    public override void _Ready()
    {
        maxSpeed = 400;
        jumpStrength = -400;
        displayName = "Gop";
        intName = "player";
        base._Ready();
    }

    public override void _Input(InputEvent @event)
    {

        if (@event.IsActionPressed("moveLeft"))
        {
            this.velocity.X = -1 * maxSpeed;
        }

        if (@event.IsActionPressed("moveRight"))
        {
            this.velocity.X = maxSpeed;
        }

        base._Input(@event);
    }
}
