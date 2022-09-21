﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0.Item
{
    internal class Heart : ICommand
    {
        private Game1 game;
        public Heart(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            if (this.game.player is Sprite)
            {
                Sprite item = (Sprite)this.game.item;
                item.SourceRectangle = ItemRectangle.Heart;
                item.Frame = 0;
                item.Velocity = new Vector2(0, 0);
            }
        }
    }
}

