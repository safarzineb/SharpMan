using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Sharpman;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        //sharpman textures
        Texture2D SharpManTexture;
       
        //phantoms textures
        //phantom1
        //phantom2
        //phantom4
        //phantom4
        
        //walls texture
        
        //floor texture
        
        //plus texture
        
        //hashtag texture
        
        //cherry texture
        
        //
        
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        //suck up map for XML built maps
        //ahmed does this
        _graphics.isFullScreen = false;
        _graphics.PreferredBackBufferHeight = 800;
        _graphics.PreferredBackBufferWidth = 1280;
        _graphics.ApplyChanges();
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        //suck up all the sprites needed
        //place every sprite with function
        //pauls does this
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        //reads input

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Green);
        //farah 
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}