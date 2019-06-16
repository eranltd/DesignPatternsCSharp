﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>

    /// The 'Memento' class

    /// </summary>

    class Memento

    {
        private string _state;

        // Constructor

        public Memento(string state)
        {
            this._state = state;
        }

        // Gets or sets state

        public string State
        {
            get { return _state; }
        }
    }
}
