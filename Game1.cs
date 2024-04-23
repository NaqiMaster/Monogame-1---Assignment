using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame_1___Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        int randomXLocation, randomXLocation1, randomXLocation2, randomXLocation3;
        Texture2D blueTexture, redTexture, goldTexture, characterTexture, backgroundTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            Random generator = new Random();

            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 400; // Sets the height of the window
            _graphics.ApplyChanges();



            base.Initialize();
            randomXLocation = generator.Next(100,_graphics.PreferredBackBufferWidth);
            randomXLocation1 = generator.Next(100, _graphics.PreferredBackBufferWidth);
            randomXLocation2 = generator.Next(100, _graphics.PreferredBackBufferWidth);
            randomXLocation3 = generator.Next(0,100);




        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            blueTexture = Content.Load<Texture2D>("BlueCoin");
            redTexture = Content.Load<Texture2D>("RedCoin");
            goldTexture = Content.Load<Texture2D>("GoldCoin");
            characterTexture = Content.Load<Texture2D>("Character");
            backgroundTexture = Content.Load<Texture2D>("Background");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(backgroundTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(redTexture, new Vector2(randomXLocation1, 300), Color.White);
            _spriteBatch.Draw(goldTexture, new Vector2(randomXLocation, 300), Color.White);
            _spriteBatch.Draw(characterTexture, new Vector2(randomXLocation3, 140),Color.White);
            _spriteBatch.Draw(blueTexture, new Vector2(randomXLocation2, 300), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}