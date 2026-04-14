using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace VirusBuster.Enemies;

public abstract class Enemy
{
    protected Vector2 _position;
    protected Color _color;

    public Vector2 Position
    {
        get => _position;
        set => _position = value;
    }

    public Color Color => _color;

    protected Enemy(Vector2 position, Color color)
    {
        _position = position;
        _color = color;
    }

    public abstract void Update(GameTime gameTime);
    public abstract void Draw(SpriteBatch spriteBatch);
}