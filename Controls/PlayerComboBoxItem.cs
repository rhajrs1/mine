﻿using Mines.Manager.PlayerManager;
using PlayerInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mines.Controls
{
    class PlayerComboBoxItem
    {
        private string playerName;
        private PlayerGenerator playerGenerator;
        public PlayerGenerator PlayerGenerator { get { return this.playerGenerator; } }

        public PlayerComboBoxItem(string playerName, PlayerGenerator playerGenerator)
        {
            this.playerName = playerName;
            this.playerGenerator = playerGenerator;
        }

        public override string ToString()
        {
            return playerName;
        }
    }
}
