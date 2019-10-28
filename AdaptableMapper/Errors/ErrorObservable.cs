﻿using System.Collections.Generic;

namespace AdaptableMapper.Errors
{
    public sealed partial class ErrorObservable
    {
        private ErrorObservable() 
        {
            _observers = new List<ErrorObserver>();
        }

        private List<ErrorObserver> _observers;

        public void Register(ErrorObserver errorObserver)
        {
            _observers.Add(errorObserver);
        }

        public void Unregister(ErrorObserver errorObserver)
        {
            _observers.Remove(errorObserver);
        }

        public void Raise(string message)
        {
            var error = new Error(message);

            _observers.ForEach(o => o?.ErrorOccured(error));
        }
    }
}