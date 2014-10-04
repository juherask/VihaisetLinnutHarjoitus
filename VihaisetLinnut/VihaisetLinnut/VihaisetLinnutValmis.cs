using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Effects;
using Jypeli.Widgets;

public class VihaisetLinnutValmis : PhysicsGame
{
    PhysicsObject lintu;
    PhysicsObject possu;

    public override void Begin()
    {
        lintu = new PhysicsObject(40, 40, Shape.Circle);
        lintu.Color = Color.Red;
        lintu.X = -400;
        lintu.Y = -350;
        lintu.IgnoresGravity = true;
        Add(lintu);

        PhysicsObject maa = Level.CreateBottomBorder();

        possu = new PhysicsObject(40, 40, Shape.Circle);
        possu.Color = Color.Green;
        possu.X = +400;
        possu.Y = -350;
        Add(possu);
        AddCollisionHandler(possu, PossuunOsuu);

        Gravity = new Vector(0, -500);
        LisaaKentta();

        IsMouseVisible = true;
        Mouse.Listen(MouseButton.Left, ButtonState.Released, AmmuLintu, "Ammu lintu hiirellä");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }

    void LisaaKentta() {
        PhysicsObject palikka1 = new PhysicsObject(120, 20);
        palikka1.Position = new Vector(+400, -250);
        Add(palikka1);
        PhysicsObject palikka2 = new PhysicsObject(20, 100);
        palikka2.Position = new Vector(+440, -350);
        Add(palikka2);
        PhysicsObject palikka3 = new PhysicsObject(20, 100);
        palikka3.Position = new Vector(+360, -350);
        Add(palikka3);
    }

    void AmmuLintu()
    {
        lintu.Hit((Mouse.PositionOnScreen - lintu.Position) * -4.0);
        lintu.IgnoresGravity = false;
    }

    void PossuunOsuu(PhysicsObject tormaaja, PhysicsObject kohde)
    {
        if (tormaaja.Velocity.Magnitude > 200 || kohde.Velocity.Magnitude > 200)
            possu.Destroy();
    }
}
