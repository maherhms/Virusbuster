using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using VirusBuster.Base;
using VirusBuster.Utility;

namespace VirusBuster.Enemies;

public class RedRectangularEnemy : RectangularEnemy
{
    private const int WIDTH = 20;
    private const int HEIGHT = 20;
    private static Color COLOR = Color.Red;
    public RedRectangularEnemy(Vector2 position , float health , float speed) : base(position, COLOR , health , speed , WIDTH, HEIGHT)
    {
    }
    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(
            _texture,
            new Rectangle((int)_position.X, (int)_position.Y, _width, _height),
            _color
        );
    }
    public override void Update(GameTime gameTime)
    {
        float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

        // Simple movement to the right
        _position.X += _speed * dt;
    }
}