using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using VirusBuster.Base;

namespace VirusBuster.Utility;

public static class ScreenUtility
{
    private static Random rng = new Random();
    public static Vector2 GetRandomOffscreenPosition(int width, int height)
    {
        int screenW = GameCore.GraphicsDevice.Viewport.Width;
        int screenH = GameCore.GraphicsDevice.Viewport.Height;

        int offset = Math.Max(width, height); // enemy size determines how far offscreen it spawns

        int side = rng.Next(4); // 0=top, 1=right, 2=bottom, 3=left

        return side switch
        {
            0 => new Vector2(rng.Next(0, screenW), -offset),          // top
            1 => new Vector2(screenW + offset, rng.Next(0, screenH)), // right
            2 => new Vector2(rng.Next(0, screenW), screenH + offset), // bottom
            _ => new Vector2(-offset, rng.Next(0, screenH))           // left
        };
    }
    public static Vector2 GetScreenCenter()
    {
        return new Vector2(
            GameCore.GraphicsDevice.Viewport.Width / 2f,
            GameCore.GraphicsDevice.Viewport.Height / 2f);
    }
}
