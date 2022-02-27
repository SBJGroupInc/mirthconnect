﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirthConnectClient
{
    public static class BindingListExtensions
    {
        public static void AddRange<T>(this System.ComponentModel.BindingList<T> bindingList, IEnumerable<T> collection)
        {
            // The given collection may not be null.
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            // Remember the current setting for RaiseListChangedEvents
            // (if it was already deactivated, we shouldn't activate it after adding!).
            var oldRaiseEventsValue = bindingList.RaiseListChangedEvents;

            // Try adding all of the elements to the binding list.
            try
            {
                bindingList.RaiseListChangedEvents = false;

                foreach (var value in collection)
                    bindingList.Add(value);
            }

            // Restore the old setting for RaiseListChangedEvents (even if there was an exception),
            // and fire the ListChanged-event once (if RaiseListChangedEvents is activated).
            finally
            {
                bindingList.RaiseListChangedEvents = oldRaiseEventsValue;

                if (bindingList.RaiseListChangedEvents)
                    bindingList.ResetBindings();
            }
        }
    }
}
