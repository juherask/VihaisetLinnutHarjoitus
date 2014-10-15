using System;

static class Ohjelma
{
#if WINDOWS || XBOX
    static void Main(string[] args)
    {
#if !DEBUG
        using (VihaisetLinnutValmis game = new VihaisetLinnutValmis())
        {

            game.IsFullScreen = true;

            game.Run();
        }
#else
        using (VihaisetLinnut game = new VihaisetLinnut())
        {

            game.IsFullScreen = true;

            game.Run();
        }
#endif

    }
#endif
}
