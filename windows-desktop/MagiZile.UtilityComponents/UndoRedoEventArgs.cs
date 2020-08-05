using System;

namespace MagiZile.UtilityComponents
{
    public class UndoRedoEventArgs : EventArgs
    {
        public UndoRedoEventArgs(int data)
        {
            NewUndoIndex = data;
        }

        public int NewUndoIndex { get; } = 0;
    }
}
