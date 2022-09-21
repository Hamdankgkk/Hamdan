﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0
{
    public class ItemFactory
    {
        private Texture2D Arrow;
        private Texture2D BlueCandle;
        private Texture2D Bomb;
        private Texture2D Boomerang;
        private Texture2D Bow;
        private Texture2D Clock;
        private Texture2D Compass;
        private Texture2D Fairy;
        private Texture2D Food;
        private Texture2D Heart;
        private Texture2D HeartContainer;
        private Texture2D Key;
        private Texture2D Letter;
        private static ItemFactory instance = new ItemFactory();
        public static ItemFactory Instance
        {
            get
            {
                return instance;
            }
        }
        private ItemFactory() { }
        public void LoadTextures(ContentManager content)
        {
            Arrow = content.Load<Texture2D>("ZeldaSpriteArrow");
            BlueCandle = content.Load<Texture2D>("ZeldaSpriteBlueCandle");
            Bomb = content.Load<Texture2D>("ZeldaSpriteBomb");
            Boomerang = content.Load<Texture2D>("ZeldaSpriteBoomerang");
            Bow = content.Load<Texture2D>("ZeldaSpriteBow");
            Clock = content.Load<Texture2D>("ZeldaSpriteClock");
            Compass = content.Load<Texture2D>("ZeldaSpriteCompass");
            Fairy = content.Load<Texture2D>("ZeldaSpriteFairy");
            Food = content.Load<Texture2D>("ZeldaSpriteFood");
            Heart = content.Load<Texture2D>("ZeldaSpriteHeart");
            HeartContainer = content.Load<Texture2D>("ZeldaSpriteHeartContainer");
            Key = content.Load<Texture2D>("ZeldaSpriteKey");
            Letter = content.Load<Texture2D>("ZeldaSpriteLetter");
        }

        public Sprite ZeldaArrow(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Arrow, ItemRectangle.BowArrow, spriteBatch, position, velocity);
        }

        public Sprite ZeldaBlueCandle(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(BlueCandle, ItemRectangle.Candle, spriteBatch, position, velocity);
        }

        public Sprite ZeldaBomb(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Bomb, ItemRectangle.Bomb, spriteBatch, position, velocity);
        }

        public Sprite ZeldaBoomerang(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Boomerang, ItemRectangle.Boomerang, spriteBatch, position, velocity);
        }

        public Sprite ZeldaBow(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Bow, ItemRectangle.BowArrow, spriteBatch, position, velocity);
        }

        public Sprite ZeldaClock(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Clock, ItemRectangle.Clock, spriteBatch, position, velocity);
        }

        public Sprite ZeldaCompass(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Compass, ItemRectangle.Compass, spriteBatch, position, velocity);
        }

        public Sprite ZeldaFairy(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Fairy, ItemRectangle.Fairy, spriteBatch, position, velocity);
        }

        public Sprite ZeldaFood(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Food, ItemRectangle.Food, spriteBatch, position, velocity);
        }

        public Sprite ZeldaHeart(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Heart, ItemRectangle.Heart, spriteBatch, position, velocity);
        }

        public Sprite ZeldaHeartContainer(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(HeartContainer, ItemRectangle.HeartContainer, spriteBatch, position, velocity);
        }

        public Sprite ZeldaKey(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Key, ItemRectangle.Key, spriteBatch, position, velocity);
        }

        public Sprite ZeldaLetter(SpriteBatch spriteBatch, Vector2 position, Vector2 velocity)
        {
            return new Sprite(Letter, ItemRectangle.Letter, spriteBatch, position, velocity);
        }

    }
}