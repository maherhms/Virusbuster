using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using VirusBuster.Base;
using VirusBuster.Utility;

namespace VirusBuster.Player;

public class PlayerMouse
{
    private Rectangle _attackRectangle;
    private Rectangle _aimRectangle;
    private Texture2D _attackRectangleTexture;
    private Texture2D _aimRectangleTexture;
    private Texture2D _mouseContourTexture;
    private int _contourThickness = 5;

    private readonly Color _mouseColor = new Color(144, 213, 255, 50);
    private readonly Color _contourColor = new Color(Color.White, 0.35f);
    private readonly Color _geometryTint = Color.White;

    public void LoadContent()
    {
        InitializeMouseTexture();
        InitializeCenterMouseTexture();
    }

    private void InitializeMouseTexture()
    {
        _attackRectangle = new Rectangle(
            0, 0,
            (int)GameState.Instance.PlayerStats.CurrentAttackSize.X,
            (int)GameState.Instance.PlayerStats.CurrentAttackSize.Y
        );

        _attackRectangleTexture = GeometryFactory.CreateFilledTexture(GameCore.GraphicsDevice,_attackRectangle.Width, _attackRectangle.Height, _geometryTint);
        _mouseContourTexture = _attackRectangleTexture;
    }

    private void InitializeCenterMouseTexture()
    {
        _aimRectangle = new Rectangle(0, 0, 5, 5);
        _aimRectangleTexture = GeometryFactory.CreateFilledTexture(GameCore.GraphicsDevice,_aimRectangle.Width, _aimRectangle.Height, _geometryTint);
    }

    public Vector2 GetCenteredMousePosition(Rectangle rectangle)
    {
        return new Vector2(
            Mouse.GetState().X - rectangle.Width / 2f,
            Mouse.GetState().Y - rectangle.Height / 2f
        );
    }

    public Vector2 GetMousePosition()
    {
        return new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
    }

    public Rectangle GetAttackRectangle() => _attackRectangle;
    public Texture2D GetPlayerMouseTexture() => _attackRectangleTexture;
    public Color GetPlayerMouseColor() => _mouseColor;

    public void DrawPlayerMouse()
    {
        GameCore.SpriteBatch.Draw(_attackRectangleTexture, GetCenteredMousePosition(_attackRectangle), _mouseColor);
        GameCore.SpriteBatch.Draw(_aimRectangleTexture, GetCenteredMousePosition(_aimRectangle), Color.White);
        DrawOutline(GameCore.SpriteBatch, GetCenteredMousePosition(_attackRectangle), _contourColor);
    }

    public void DrawOutline(SpriteBatch spriteBatch, Vector2 position, Color color)
    {
        // Top Left
        spriteBatch.Draw(_mouseContourTexture, new Rectangle((int)position.X, (int)position.Y, _attackRectangle.Width / 5, _contourThickness), color);

        // Top Right
        spriteBatch.Draw(_mouseContourTexture, new Rectangle((int)position.X + (4 * _attackRectangle.Width / 5), (int)position.Y, _attackRectangle.Width / 5, _contourThickness), color);

        // Bottom Left
        spriteBatch.Draw(_mouseContourTexture, new Rectangle((int)position.X, (int)position.Y + _attackRectangle.Height - _contourThickness, _attackRectangle.Width / 5, _contourThickness), color);

        // Bottom Right
        spriteBatch.Draw(_mouseContourTexture, new Rectangle((int)position.X + (4 * _attackRectangle.Width / 5), (int)position.Y + _attackRectangle.Height - _contourThickness, _attackRectangle.Width / 5, _contourThickness), color);

        // Left Up
        spriteBatch.Draw(_mouseContourTexture, new Rectangle((int)position.X, (int)position.Y, _contourThickness, _attackRectangle.Height / 5), color);

        // Left Bottom
        spriteBatch.Draw(_mouseContourTexture, new Rectangle((int)position.X, (int)position.Y + (4 * _attackRectangle.Height / 5), _contourThickness, _attackRectangle.Height / 5), color);

        // Right Up
        spriteBatch.Draw(_mouseContourTexture, new Rectangle((int)position.X + _attackRectangle.Width - _contourThickness, (int)position.Y, _contourThickness, _attackRectangle.Height / 5), color);

        // Right
        spriteBatch.Draw(_mouseContourTexture, new Rectangle((int)position.X + _attackRectangle.Width - _contourThickness, (int)position.Y + (4 * _attackRectangle.Height / 5), _contourThickness, _attackRectangle.Height / 5), color);
    }
}
