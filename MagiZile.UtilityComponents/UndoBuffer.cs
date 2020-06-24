using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.UtilityComponents
{
    public class UndoBuffer
    {
        string filePath = "";
        int maxUndos = 10;
        int undoIndex = 0;
        public List<string[]> objectStates = new List<string[]>();
        public List<object> programObjects = new List<object>();

        /// <summary>
        /// Initializes a new UndoBuffer object.
        /// </summary>
        /// <param name="maxUndos">The maximum number of allowed undos.</param>
        /// <param name="programObjects">The list of object states.</param>
        public UndoBuffer(List<object> programObjects, int maxUndos)
        {
            this.maxUndos = maxUndos;
            this.programObjects = programObjects;
        }

        public class UndoRedoEventArgs : EventArgs
        {
            public UndoRedoEventArgs(int data)
            {
                newUndoIndex = data;
            }

            int newUndoIndex = 0;

            public int NewUndoIndex
            {
                get
                {
                    return newUndoIndex;
                }
            }
        }

        public delegate void UndoRedoEventHandler(object sender, UndoRedoEventArgs e);

        /// <summary>
        /// Deletes the temporary file associated with the current UndoBuffer object.
        /// </summary>
        ~UndoBuffer()
        {
            File.Delete(filePath);
        }

        /// <summary>
        /// Occurs when the Undo method is invoked.
        /// </summary>
        public event UndoRedoEventHandler OnUndo;

        /// <summary>
        /// Occurs when the Redo method is invoked.
        /// </summary>
        public event UndoRedoEventHandler OnRedo;

        /// <summary>
        /// Reverts the state of all objects in the object list to the previous state.
        /// </summary>
        public void Undo()
        {
            undoIndex--;
            OnUndo?.Invoke(this, new UndoRedoEventArgs(undoIndex));
            string[] objects = new string[programObjects.Count]; //Used for saving the current state of the objects to the objectStates list.
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i] = programObjects[i].ToString();
            }
            objectStates.Add(objects);
        }

        /// <summary>
        /// Reverts the objects in the object list to the state before the Undo method was invoked.
        /// </summary>
        public void Redo()
        {
            undoIndex++;
            OnRedo?.Invoke(this, new UndoRedoEventArgs(undoIndex));
            string[] objects = new string[programObjects.Count]; //Used for saving the current state of the objects to the objectStates list.
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i] = programObjects[i].ToString();
            }
            int j = undoIndex;
            while (j < objectStates.Count) //Remove the arrays after the current undo index.
            {
                objectStates.RemoveAt(j);
            }
            objectStates.Add(objects);
        }
    }
}
