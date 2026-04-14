using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace VirusBuster.Enemies;

public abstract class Enemy
{
    protected Vector2 _position;
    protected Color _color;
    protected float _health;
    protected float _speed;

    public Vector2 Position
    {
        get => _position;
        set => _position = value;
    }
    public Color Color => _color;
    public float Health => _health;
    public float Speed => _speed;
    protected Enemy(Vector2 position, Color color , float health , float speed)
    {
        _position = position;
        _color = color;
        _health = health;
        _speed = speed;
    }
    public abstract void Update(GameTime gameTime);
    public abstract void Draw(SpriteBatch spriteBatch);
    public abstract void LoadEnemyContent();
}